using ChainPattern;

public class RealGameConfigValidationResolver_Result : IAsynPieceResult
{
    public const string PUBLIC_KEY = "RealGameConfigValidationResolver_Result";

    private bool _success;

    public RealGameConfigValidationResolver_Result(bool success)
    {
        _success = success;
    }

    public bool Success { get => _success; set => _success = value; }

    public string GetKey()
    {
        return PUBLIC_KEY;
    }
}
