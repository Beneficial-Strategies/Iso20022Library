// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the corporate action proceeds are taxable at issuer level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0EPMQIlyEeavwKddCbm3hg")]
[Description(@"Specifies whether the corporate action proceeds are taxable at issuer level.")]
[DerivedFrom(typeof(IssuerTaxabilityV2Code))]
public enum IssuerTaxability2Code
{
    /// <summary>
    /// The relevant proceeds are taxable.
    /// Encoded/decoded by serializers as &quot;TXBL&quot;.
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_3na_IYlyEeavwKddCbm3hg")]
    [Description(@"The relevant proceeds are taxable.")]
    Taxable = IssuerTaxabilityV2Code.Taxable, // same ordinal as derivation source for type conversions
    
}
