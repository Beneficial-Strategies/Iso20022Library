// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a suspended status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQzbBtp-Ed-ak6NoX_4Aeg_1875327691")]
[Description(@"Specifies the reason for a suspended status.")]
[DerivedFrom(typeof(SuspendedStatusReasonCode))]
public enum SuspendedStatusReason3Code
{
    /// <summary>
    /// There is a suspension of pricing. The order will stay on the books until the next pricing.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_ZQzbB9p-Ed-ak6NoX_4Aeg_1892876189")]
    [Description(@"There is a suspension of pricing. The order will stay on the books until the next pricing.")]
    PriceSuspension = SuspendedStatusReasonCode.PriceSuspension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is a fund overflow.
    /// Encoded/decoded by serializers as &quot;FLOW&quot;.
    /// </summary>
    [EnumMember(Value = "FLOW")]
    [IsoId("_ZQzbCNp-Ed-ak6NoX_4Aeg_1892876206")]
    [Description(@"There is a fund overflow.")]
    Overflow = SuspendedStatusReasonCode.Overflow, // same ordinal as derivation source for type conversions
    
}
