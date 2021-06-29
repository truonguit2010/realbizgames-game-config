
namespace RealbizGames.Settings
{
    public class RealGameConfigLocalRepository : GenericMasterDataRepository<RealGameConfigEntity>
    {
        private static RealGameConfigLocalRepository _Instance;
        public static RealGameConfigLocalRepository DefaultInstance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RealGameConfigLocalRepository("game_config");
                }
                return _Instance;
            }
        }

        public RealGameConfigLocalRepository(string filePath) : base(filePath)
        {

        }
    }
}