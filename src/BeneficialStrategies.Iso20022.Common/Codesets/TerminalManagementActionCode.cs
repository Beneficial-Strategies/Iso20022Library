// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KTocs31DEeCF8NjrBemJWQ_1816233839")]
[Description(@"Types of terminal management action to be performed by a point of interaction.")]
[Derivations(
    typeof(TerminalManagementAction4Code),
    typeof(TerminalManagementAction1Code),
    typeof(TerminalManagementAction2Code),
    typeof(TerminalManagementAction3Code),
    typeof(TerminalManagementAction5Code)
)]
public enum TerminalManagementActionCode
{
    /// <summary>
    /// Request to activate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_KToctH1DEeCF8NjrBemJWQ_144688973")]
    [Description(@"Request to activate the element identified inside the message exchange.")]
    Activate,

    /// <summary>
    /// Request to deactivate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DCTV&quot;.
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_KToctX1DEeCF8NjrBemJWQ_-139344905")]
    [Description(@"Request to deactivate the element identified inside the message exchange.")]
    Deactivate,

    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_KToctn1DEeCF8NjrBemJWQ_-484952670")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete,

    /// <summary>
    /// Request to download the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DWNL&quot;.
    /// </summary>
    [EnumMember(Value = "DWNL")]
    [IsoId("_KToct31DEeCF8NjrBemJWQ_1240301516")]
    [Description(@"Request to download the element identified inside the message exchange.")]
    Download,

    /// <summary>
    /// Request to install the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_KTocuH1DEeCF8NjrBemJWQ_-958484136")]
    [Description(@"Request to install the element identified inside the message exchange.")]
    Install,

    /// <summary>
    /// Request to restart the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_KTocuX1DEeCF8NjrBemJWQ_-1341808276")]
    [Description(@"Request to restart the element identified inside the message exchange.")]
    Restart,

    /// <summary>
    /// Request to upload the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;UPLD&quot;.
    /// </summary>
    [EnumMember(Value = "UPLD")]
    [IsoId("_KTxmoH1DEeCF8NjrBemJWQ_482605373")]
    [Description(@"Request to upload the element identified inside the message exchange.")]
    Upload,

    /// <summary>
    /// Request to update the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_Dyi3AI3iEeW32YMP0mBeyw")]
    [Description(@"Request to update the element identified inside the message exchange.")]
    Update,

    /// <summary>
    /// Request to create or add the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;CREA&quot;.
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_i61isI34EeWRwov1g9WL_A")]
    [Description(@"Request to create or add the element identified inside the message exchange.")]
    Create,

    /// <summary>
    /// Request sent to a POI to bind with a server.
    /// Encoded/decoded by serializers as &quot;BIND&quot;.
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_RHCooN6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to bind with a server.")]
    Bind,

    /// <summary>
    /// Request sent to a POI to unbind with a server.
    /// Encoded/decoded by serializers as &quot;UBND&quot;.
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_UT4_IN6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to unbind with a server.")]
    Unbind,

    /// <summary>
    /// Request sent to a POI to rebind with a server.
    /// Encoded/decoded by serializers as &quot;RBND&quot;.
    /// </summary>
    [EnumMember(Value = "RBND")]
    [IsoId("_XS2qoN6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to rebind with a server.")]
    Rebind,

    /// <summary>
    /// Request to execute a device request.
    /// Encoded/decoded by serializers as &quot;DEVR&quot;.
    /// </summary>
    [EnumMember(Value = "DEVR")]
    [IsoId("_0cc9MCixEeurkfo6MpvKDA")]
    [Description(@"Request to execute a device request.")]
    DeviceRequest,
}
