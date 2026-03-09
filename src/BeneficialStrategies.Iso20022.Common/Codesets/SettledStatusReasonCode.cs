// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a partially settled status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKsL9dp-Ed-ak6NoX_4Aeg_-13240435")]
[Description(@"Specifies the reason for a partially settled status.")]
[Derivations(typeof(SettledStatusReason1Code),typeof(SettledStatusReason2Code))]
public enum SettledStatusReasonCode
{
    /// <summary>
    /// Units are partially settled.
    /// Encoded/decoded by serializers as &quot;UPST&quot;.
    /// </summary>
    [EnumMember(Value = "UPST")]
    [IsoId("_ZKsL9tp-Ed-ak6NoX_4Aeg_606549659")]
    [Description(@"Units are partially settled.")]
    UnitsPartiallySettled,
    
    /// <summary>
    /// Cash is partially settled.
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_ZKsL99p-Ed-ak6NoX_4Aeg_606549702")]
    [Description(@"Cash is partially settled.")]
    CashPartiallySettled,
    
    /// <summary>
    /// Units and cash are both partially settled.
    /// Encoded/decoded by serializers as &quot;UCPS&quot;.
    /// </summary>
    [EnumMember(Value = "UCPS")]
    [IsoId("_ZKsL-Np-Ed-ak6NoX_4Aeg_606549719")]
    [Description(@"Units and cash are both partially settled.")]
    UnitsCashPartiallySettled,
    
    /// <summary>
    /// Redemption has been gated, all settlement will be done at the same price.
    /// Encoded/decoded by serializers as &quot;GAT1&quot;.
    /// </summary>
    [EnumMember(Value = "GAT1")]
    [IsoId("_1jZr8EgWEea9YuSvQGoi-w")]
    [Description(@"Redemption has been gated, all settlement will be done at the same price.")]
    GatedOneNAV,
    
    /// <summary>
    /// Redemption has been gated. Multiple redemptions and multiple prices will be required.
    /// Encoded/decoded by serializers as &quot;GATM&quot;.
    /// </summary>
    [EnumMember(Value = "GATM")]
    [IsoId("_4wRQkEgWEea9YuSvQGoi-w")]
    [Description(@"Redemption has been gated. Multiple redemptions and multiple prices will be required.")]
    GatedMultipleNAV,
    
}
