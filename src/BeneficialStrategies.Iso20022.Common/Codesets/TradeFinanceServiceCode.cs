// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of bank service selected by the user.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YmyNoNp-Ed-ak6NoX_4Aeg_243553548")]
[Description(@"Specifies the type of bank service selected by the user.")]
[Derivations(typeof(TradeFinanceService2Code))]
public enum TradeFinanceServiceCode
{
    /// <summary>
    /// Code for purchase order services.
    /// Encoded/decoded by serializers as &quot;PORS&quot;.
    /// </summary>
    [EnumMember(Value = "PORS")]
    [IsoId("_YmyNodp-Ed-ak6NoX_4Aeg_274027739")]
    [Description(@"Code for purchase order services.")]
    PurchaseOrderServices,

    /// <summary>
    /// Code for level 1 services.
    /// Encoded/decoded by serializers as &quot;LEV1&quot;.
    /// </summary>
    [EnumMember(Value = "LEV1")]
    [IsoId("_YmyNotp-Ed-ak6NoX_4Aeg_-1329776224")]
    [Description(@"Code for level 1 services.")]
    Level1Services,

    /// <summary>
    /// Code for level 2 services.
    /// Encoded/decoded by serializers as &quot;LEV2&quot;.
    /// </summary>
    [EnumMember(Value = "LEV2")]
    [IsoId("_YmyNo9p-Ed-ak6NoX_4Aeg_-1329775933")]
    [Description(@"Code for level 2 services.")]
    Level2Services,

    /// <summary>
    /// Code for level 3 services.
    /// Encoded/decoded by serializers as &quot;LEV3&quot;.
    /// </summary>
    [EnumMember(Value = "LEV3")]
    [IsoId("_YmyNpNp-Ed-ak6NoX_4Aeg_-1329775916")]
    [Description(@"Code for level 3 services.")]
    Level3Services,
}
