using System.Collections;
using UnityEngine;
#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif
using Google.Maps.Coord;
using Google.Maps.Examples.Shared;

namespace Google.Maps.Examples {
  [RequireComponent(typeof(MapsService), typeof(ErrorHandling))]
  public class PlayerLocationFollower : MonoBehaviour
  {
    public Transform PlayerIconObject;
    
    #if PLATFORM_ANDROID
    GameObject dialog = null;
    #endif
    
    private MapsService MapsService;

    private LatLng PreviousLocation;
    
    private void Start() {
      GetPermissions();
      StartCoroutine(Follow());
    }

    /*private void TestCoords()
    {
      PreviousLocation =
        new LatLng(55.724224, 37.562856);
      MapsService = GetComponent<MapsService>();
      MapsService.InitFloatingOrigin(PreviousLocation);
      MapsService.LoadMap(ExampleDefaults.DefaultBounds, ExampleDefaults.DefaultGameObjectOptions);
      
      LatLng latLng = new LatLng(55.724224, 37.562856);
      Debug.Log(MapsService.Projection.IsFloatingOriginSet);
      Vector3 pos = MapsService.Projection.FromLatLngToVector3(latLng);
      Debug.Log(pos);
    }*/

    private IEnumerator Follow() {

      #if PLATFORM_IOS
      // The location permissions request in IOS does not seem to get invoked until it is called for
      // in the code. It happens at runtime so if the code is not trying to access the location
      // right away, it will not pop up the permissions dialog.
      Input.location.Start();
      #endif

      while (!Input.location.isEnabledByUser) {
        Debug.Log("Waiting for location services to become enabled..");
        yield return new WaitForSeconds(1f);
      }
      Debug.Log("Location services is enabled.");

      #if !PLATFORM_IOS
      Input.location.Start();
      #endif

      Input.compass.enabled = true;

      // Wait for the location service to start.
      while (true) {
        if (Input.location.status == LocationServiceStatus.Initializing) {
          // Starting, just wait.
          yield return new WaitForSeconds(1f);
        } else if (Input.location.status == LocationServiceStatus.Failed) {
          // Failed, abort the coroutine.
          Debug.LogError("Location Services failed to start.");
          yield break;
        } else if (Input.location.status == LocationServiceStatus.Running) {
          // Started, continue the coroutine.
          break;
        }
      }

      // Get the MapsService component and load it at the device location.
      PreviousLocation =
          new LatLng(Input.location.lastData.latitude, Input.location.lastData.longitude);
      MapsService = GetComponent<MapsService>();
      MapsService.InitFloatingOrigin(PreviousLocation);
      MapsService.LoadMap(ExampleDefaults.DefaultBounds, ExampleDefaults.DefaultGameObjectOptions);
    }
    
    private void Update() {
      if (MapsService == null) {
        return;
      }

      // Get the current map location.
      LatLng currentLocation =
          new LatLng(Input.location.lastData.latitude, Input.location.lastData.longitude);
      Vector3 currentWorldLocation = MapsService.Projection.FromLatLngToVector3(currentLocation);

      // Move the camera to the current map location.
      Vector3 targetCameraPosition = new Vector3(currentWorldLocation.x,
          PlayerIconObject.position.y, currentWorldLocation.z);
      PlayerIconObject.position = Vector3.Lerp(PlayerIconObject.position,
          targetCameraPosition, Time.deltaTime * 5);

      // Only move the map location if the device has moved more than 2 meters.
      if (Vector3.Distance(Vector3.zero, currentWorldLocation) > 2) {
        MapsService.MoveFloatingOrigin(currentLocation, new[] { PlayerIconObject.gameObject });
        MapsService.LoadMap(ExampleDefaults.DefaultBounds,
            ExampleDefaults.DefaultGameObjectOptions);
        PreviousLocation = currentLocation;
      }
    }

    private void GetPermissions() {
      #if PLATFORM_ANDROID
      if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation)) {
        Permission.RequestUserPermission(Permission.FineLocation);
        dialog = new GameObject();
      }
      #endif // Android
    }

    void OnGUI() {
      #if PLATFORM_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation)) {
          dialog.AddComponent<PermissionsRationaleDialog>();
            return;
        }
        else if (dialog != null) {
            Destroy(dialog);
        }
        #endif
    }
  }
}
