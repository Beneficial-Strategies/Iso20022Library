// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for time-out.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vr6_Adp-Ed-ak6NoX_4Aeg_1010349399")]
[Description(@"Specifies the reason for time-out.")]
[Derivations(typeof(TimeOut1Code))]
public enum TimeOutCode
{
    /// <summary>
    /// Reason for time-out is the reaching of latest shipment date.
    /// Encoded/decoded by serializers as &quot;LSDD&quot;.
    /// </summary>
    [EnumMember(Value = "LSDD")]
    [IsoId("_Vr6_Atp-Ed-ak6NoX_4Aeg_1039902628")]
    [Description(@"Reason for time-out is the reaching of latest shipment date.")]
    LatestShipmentDateDue,

    /// <summary>
    /// Reason for time-out is the lack of action from the user side.
    /// Encoded/decoded by serializers as &quot;NACT&quot;.
    /// </summary>
    [EnumMember(Value = "NACT")]
    [IsoId("_Vr6_A9p-Ed-ak6NoX_4Aeg_1081458249")]
    [Description(@"Reason for time-out is the lack of action from the user side.")]
    NoAction,
}
