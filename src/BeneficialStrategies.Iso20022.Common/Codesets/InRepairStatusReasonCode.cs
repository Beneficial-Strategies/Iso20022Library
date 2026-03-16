// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a In Repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWsFB9p-Ed-ak6NoX_4Aeg_1106691227")]
[Description(@"Specifies the reason for a In Repair status.")]
[Derivations(typeof(InRepairStatusReason1Code))]
public enum InRepairStatusReasonCode
{
    /// <summary>
    /// Order has been accepted and centralised before the cut off, but with different sales agreement than the one provided in the order.
    /// Encoded/decoded by serializers as &quot;COMA&quot;.
    /// </summary>
    [EnumMember(Value = "COMA")]
    [IsoId("_aW12ANp-Ed-ak6NoX_4Aeg_1620170310")]
    [Description(
        @"Order has been accepted and centralised before the cut off, but with different sales agreement than the one provided in the order."
    )]
    CommercialAgreement,
}
