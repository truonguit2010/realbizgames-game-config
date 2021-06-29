namespace RealbizGames.Settings
{
    /// <summary>
    /// {
    /// "android": {
    ///     "id": "android",
    ///     "ironsourceAppId": "fb6feaf1",
    ///     "facebookId": 232093648330457
    /// },
    /// "ios": {
    ///     "id": "ios",
    ///     "ironsourceAppId": "fb702479",
    ///     "facebookId": 232093648330457
    /// }
    /// }
    /// </summary>
    [System.Serializable]
    public class RealGameConfigEntity
    {
        public string id;
        public string ironsourceAppId;
        public string facebookId;
    }
}