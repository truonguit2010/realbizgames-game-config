
namespace RealbizGames.Settings
{
    public interface IRealGameConfigService : IMasterDataService<RealGameConfigDTO>
    {
        RealGameConfigDTO GetByPlatform();
        RealGameConfigDTO GetAndroidConfig();
        RealGameConfigDTO GetIOSConfig();
    }
}