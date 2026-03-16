// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t99_JFkyEeGeoaLUQk__nA_700990481")]
[Description(
    @"Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalTaxAmountTypeCode))]
public enum ExternalTaxAmountType1Code
{
    /// <summary>
    /// Tax accessed by city jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;CITY&quot;.
    /// </summary>
    [EnumMember(Value = "CITY")]
    [IsoId("_uMAeu_RYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by city jurisdications within a country.")]
    CityTax = ExternalTaxAmountTypeCode.CityTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax accessed by county jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;CNTY&quot;.
    /// </summary>
    [EnumMember(Value = "CNTY")]
    [IsoId("_uMAevvRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by county jurisdications within a country.")]
    CountyTax = ExternalTaxAmountTypeCode.CountyTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax accessed by local jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_uMKPsvRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by local jurisdications within a country.")]
    LocalTax = ExternalTaxAmountTypeCode.LocalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax accessed by province jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_uMKPtfRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by province jurisdications within a country.")]
    ProvinceTax = ExternalTaxAmountTypeCode.ProvinceTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax accessed by state jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_uMKPuPRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by state jurisdications within a country.")]
    StateTax = ExternalTaxAmountTypeCode.StateTax, // same ordinal as derivation source for type conversions
}
