using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Maps;
using Google.Maps.Examples;
using Grpc.Core;
using UnityEngine;
using UnityEngine.Networking;
using You.Facade.Proxies.v1;
using LatLng = Google.Maps.Coord.LatLng;

namespace MetaYouGo.Scripts.Server
{
    public class ServerConnector : MonoBehaviour
    {
        //server settings
        public string Host = "qa.api.youengine.com";
        public int Port = 8445;
        public MapsService MapsService;
        public BaseMapLoader BaseMapLoader;
        
        private Channel Channel;
        private List<Basket> Baskets = new List<Basket>();
        private List<PrizeByBasketResponse> Prizes = new List<PrizeByBasketResponse>();
        private List<HistoryResponse> PrizesInventory = new List<HistoryResponse>();

        void Awake()
        {
            Channel = new Channel(Host, Port, ChannelCredentials.SecureSsl);
        }

        public async Task<List<Basket>> GetBasketsAsync(LatLng _currentLatLng)
        {
            Baskets.Clear();
            
            YgBasketRequest request = new YgBasketRequest();
            request.Latitude = _currentLatLng.Lat;
            request.Longitude = _currentLatLng.Lng;

            var reply = await new YouGoDemoService.YouGoDemoServiceClient(Channel).GetBasketsAsync(request);

            foreach (var basket in reply.Baskets)
            {
                Baskets.Add(basket);
            }

            return Baskets;
        }

        public async Task<List<PrizeByBasketResponse>> GetPrizesAsync(Basket _basket)
        {
            Prizes.Clear();
            
            PrizeByBasketRequest prizeByBasketRequest = new PrizeByBasketRequest
            {
                BasketId = _basket.BasketId,
                BasketType = _basket.BasketType
            };

            var prizeReply =
                await new YouGoDemoService.YouGoDemoServiceClient(Channel).GetPrizesByBasketAsync(prizeByBasketRequest);
            
            foreach (var prize in prizeReply.Prizes)
            {
                Prizes.Add(prize);
            }

            return Prizes;
        }

        public async Task<bool> LockPrizeAsync(ulong _prizeID)
        {
            PrizeRequest prizeRequest = new PrizeRequest
            {
                PerkId = _prizeID
            };

            var lockReply = await new YouGoDemoService.YouGoDemoServiceClient(Channel).LockPrizeAsync(prizeRequest);

            if (lockReply.Status == ResponseStatus.Success)
            {
                return true;
            }

            return false;
        }

        public async Task<List<HistoryResponse>> GetPrizesInInventory()
        {
            PrizesInventory.Clear();

            var prizesInInventoryReply 
                = await new YouGoDemoService.YouGoDemoServiceClient(Channel).GetHistoryAsync(new Empty());

            if (prizesInInventoryReply.Status == ResponseStatus.Success)
            {
                foreach (var history in prizesInInventoryReply.History)
                {
                    PrizesInventory.Add(history);
                }
            }

            return PrizesInventory;
        }
        
        public async Task<Texture2D> GetTextureByURL(string url)
        {
            using( UnityWebRequest www = UnityWebRequestTexture.GetTexture(url) )
            {
                var asyncOp = www.SendWebRequest();

                while (asyncOp.isDone == false)
                    await Task.Delay(1000 / 30);
                    
                if( www.isNetworkError || www.isHttpError )
                {
                    return null;
                }
                else
                {
                    return DownloadHandlerTexture.GetContent(www);
                }
            }
        }
    }
}