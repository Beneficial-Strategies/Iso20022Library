// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tax role capacity of the instructing party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YiBCYdp-Ed-ak6NoX_4Aeg_230817252")]
[Description(@"Specifies the tax role capacity of the instructing party.")]
[DerivedFrom(typeof(TaxLiabilityCode))]
public enum TaxLiability1Code
{
    /// <summary>
    /// Settlement party is acting as a principal for tax liability.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_YiBCYtp-Ed-ak6NoX_4Aeg_-1137204905")]
    [Description(@"Settlement party is acting as a principal for tax liability.")]
    TaxPrincipal = TaxLiabilityCode.TaxPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement party is acting as an agent for tax liability.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YiBCY9p-Ed-ak6NoX_4Aeg_1016400725")]
    [Description(@"Settlement party is acting as an agent for tax liability.")]
    TaxAgent = TaxLiabilityCode.TaxAgent, // same ordinal as derivation source for type conversions
}
