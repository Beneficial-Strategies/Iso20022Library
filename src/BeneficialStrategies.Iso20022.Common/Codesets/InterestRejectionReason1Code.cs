// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the interest request is rejected due a value date or an interest amount difference.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbKMcdp-Ed-ak6NoX_4Aeg_228557165")]
[Description(@"Indicates whether the interest request is rejected due a value date or an interest amount difference.")]
[DerivedFrom(typeof(InterestRejectionReasonCode))]
public enum InterestRejectionReason1Code
{
    /// <summary>
    /// Indicates whether the interest request is rejected due a value date difference.
    /// Encoded/decoded by serializers as &quot;VADA&quot;.
    /// </summary>
    [EnumMember(Value = "VADA")]
    [IsoId("_YbKMctp-Ed-ak6NoX_4Aeg_-74499350")]
    [Description(@"Indicates whether the interest request is rejected due a value date difference.")]
    ValueDate = InterestRejectionReasonCode.ValueDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates whether the interest request is rejected due an interest amount difference.
    /// Encoded/decoded by serializers as &quot;DIAM&quot;.
    /// </summary>
    [EnumMember(Value = "DIAM")]
    [IsoId("_YbKMc9p-Ed-ak6NoX_4Aeg_1862725823")]
    [Description(@"Indicates whether the interest request is rejected due an interest amount difference.")]
    DisputeAmount = InterestRejectionReasonCode.DisputeAmount, // same ordinal as derivation source for type conversions
    
}
