using System.Collections.Generic;
using UnityEngine;

namespace RealbizGames.Settings
{
    public class RealGameConfigServiceImpl : IRealGameConfigService
    {
        public const string KEY_IOS = "ios";
        public const string KEY_ANDROID = "android";
        
        private static RealGameConfigServiceImpl _Instance;
        public static RealGameConfigServiceImpl DefaultInstance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RealGameConfigServiceImpl();
                }
                return _Instance;
            }
        }

        private RealGameConfigLocalRepository localRepository = RealGameConfigLocalRepository.DefaultInstance;
        public RealGameConfigDTO Get(string id)
        {
            RealGameConfigEntity e = localRepository.FindById(id);
            RealGameConfigDTO dto = RealGameConfigDTOConvertor.Instance.From(e);
            return dto;
        }

        public List<RealGameConfigDTO> GetAll()
        {
            List<RealGameConfigEntity> e = localRepository.FindAll();
            List<RealGameConfigDTO> dto = RealGameConfigDTOConvertor.Instance.From(e);
            return dto;
        }

        public void init()
        {
            localRepository.init();
        }

        public void lazyInit()
        {
            localRepository.lazyInit();
        }

        public void refresh()
        {
            localRepository.refresh();
        }

        public RealGameConfigDTO GetByPlatform()
        {
            return Get(id: platformKey);
        }

        public RealGameConfigDTO GetAndroidConfig()
        {
            return Get(id: KEY_ANDROID);
        }

        public RealGameConfigDTO GetIOSConfig()
        {
            return Get(id: KEY_IOS);
        }

        private string platformKey {
            get {
                if (Application.platform == RuntimePlatform.IPhonePlayer) {
                    return KEY_IOS;
                } else if (Application.platform == RuntimePlatform.Android) {
                    return KEY_ANDROID;
                } else {
                    return KEY_IOS;
                }
            }
        }
    }
}