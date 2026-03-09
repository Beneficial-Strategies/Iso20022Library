// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of overnight index swap transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_K7_KQLu9EeSXxOgurgHGgw")]
[Description(@"Specifies the type of overnight index swap transaction.")]
[DerivedFrom(typeof(OvernightIndexSwapTypeCode))]
public enum OvernightIndexSwapType1Code
{
    /// <summary>
    /// Fixed interest rate is paid by the reporting agent.
    /// Encoded/decoded by serializers as &quot;PAID&quot;.
    /// </summary>
    [EnumMember(Value = "PAID")]
    [IsoId("_MMw1obu9EeSXxOgurgHGgw")]
    [Description(@"Fixed interest rate is paid by the reporting agent.")]
    Paid = OvernightIndexSwapTypeCode.Paid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fixed interest rate is received by the reporting agent.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_MTdTg7u9EeSXxOgurgHGgw")]
    [Description(@"Fixed interest rate is received by the reporting agent.")]
    Received = OvernightIndexSwapTypeCode.Received, // same ordinal as derivation source for type conversions
    
}
