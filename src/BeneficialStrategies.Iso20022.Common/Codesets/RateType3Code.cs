// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZcZqNp-Ed-ak6NoX_4Aeg_-1424495957")]
[Description(@"Specifies the type of tax rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType3Code
{
    /// <summary>
    /// Imputed tax.
    /// Encoded/decoded by serializers as &quot;IMPU&quot;.
    /// </summary>
    [EnumMember(Value = "IMPU")]
    [IsoId("_ZZcZqdp-Ed-ak6NoX_4Aeg_-1424495955")]
    [Description(@"Imputed tax.")]
    Imputed = RateTypeCode.Imputed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate is a precompte.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_ZZmKoNp-Ed-ak6NoX_4Aeg_-1424495946")]
    [Description(@"Rate is a precompte.")]
    Precompte = RateTypeCode.Precompte, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate is a one tier tax.
    /// Encoded/decoded by serializers as &quot;TIER&quot;.
    /// </summary>
    [EnumMember(Value = "TIER")]
    [IsoId("_ZZmKodp-Ed-ak6NoX_4Aeg_-1424495927")]
    [Description(@"Rate is a one tier tax.")]
    OneTierTax = RateTypeCode.OneTierTax, // same ordinal as derivation source for type conversions
    
}
