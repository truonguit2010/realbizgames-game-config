using System.Collections.Generic;

namespace RealbizGames.Settings
{
    public class RealGameConfigDTOConvertor : IDataConvertor<RealGameConfigEntity, RealGameConfigDTO>
    {
        private static RealGameConfigDTOConvertor _Instance;
        public static RealGameConfigDTOConvertor Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RealGameConfigDTOConvertor();
                }
                return _Instance;
            }
        }

        public RealGameConfigDTO From(RealGameConfigEntity f)
        {
            RealGameConfigDTO dto = new RealGameConfigDTO();

            dto.Id = f.id;
            dto.IronsourceAppId = f.ironsourceAppId;
            dto.FacebookId = f.facebookId;

            return dto;
        }

        public List<RealGameConfigDTO> From(List<RealGameConfigEntity> fs)
        {
            List<RealGameConfigDTO> r = new List<RealGameConfigDTO>();
            foreach (var item in fs)
            {
                r.Add(From(item));
            }
            return r;
        }
    }
}