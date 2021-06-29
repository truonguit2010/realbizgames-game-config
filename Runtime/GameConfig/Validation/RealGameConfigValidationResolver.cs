using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChainPattern;
using RealbizGames.Settings;

public class RealGameConfigValidationResolver : IAsynPieceExecutor
{
    const string TAG = "RealGameConfigValidationResolver";

    private IRealGameConfigService service;

    public bool IsDone => _result != null;

    public IAsynPieceResult Result => _result;

    private RealGameConfigValidationResolver_Result _result;

    public RealGameConfigValidationResolver(IRealGameConfigService service)
    {
        this.service = service;
    }

    public void Execute(IAsynChainResult data)
    {
        Debug.LogFormat("{0} - Execute", TAG);

        List<RealGameConfigDTO> l = service.GetAll();
        string msg = ToStringUtils.ToStringForList<RealGameConfigDTO>(l);

        // #if UNITY_EDITOR
        Debug.LogFormat("{0} - {1}", TAG, msg);
        // #endif

        _result = new RealGameConfigValidationResolver_Result(success: true);

        Debug.LogFormat("{0} - End", TAG);
    }
}