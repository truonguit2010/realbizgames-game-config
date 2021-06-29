
namespace RealbizGames.Settings
{
    [System.Serializable]
    public class RealGameConfigDTO
    {
        private string id;
        private string ironsourceAppId;
        private string facebookId;

        public string Id { get => id; set => id = value; }
        public string IronsourceAppId { get => ironsourceAppId; set => ironsourceAppId = value; }
        public string FacebookId { get => facebookId; set => facebookId = value; }


        public override string ToString()
        {
            return ToStringUtils.ToStringFor(this);
        }
    }
}