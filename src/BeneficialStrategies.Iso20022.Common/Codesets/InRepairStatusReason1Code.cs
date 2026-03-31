// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a In Repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWsFBdp-Ed-ak6NoX_4Aeg_2109635063")]
[Description(@"Specifies the reason for a In Repair status.")]
[DerivedFrom(typeof(InRepairStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InRepairStatusReason1Code>))]
#endif
public enum InRepairStatusReason1Code
{
    /// <summary>
    /// Order has been accepted and centralised before the cut off, but with different sales agreement than the one provided in the order.
    /// Encoded/decoded by serializers as &quot;COMA&quot;.
    /// </summary>
    [EnumMember(Value = "COMA")]
    [IsoId("_aWsFBtp-Ed-ak6NoX_4Aeg_2109635082")]
    [Description(
        @"Order has been accepted and centralised before the cut off, but with different sales agreement than the one provided in the order."
    )]
    CommercialAgreement = InRepairStatusReasonCode.CommercialAgreement, // same ordinal as derivation source for type conversions
}
