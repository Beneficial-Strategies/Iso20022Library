// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4wFuwIMlEeeBDNMiErKunw")]
[Description(
    @"Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalTaxAmountType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalTaxAmountTypeCode>))]
#endif
public enum ExternalTaxAmountTypeCode
{
    /// <summary>
    /// Tax accessed by city jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;CITY&quot;.
    /// </summary>
    [EnumMember(Value = "CITY")]
    [IsoId("_uMAeufRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by city jurisdications within a country.")]
    CityTax,

    /// <summary>
    /// Tax accessed by county jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;CNTY&quot;.
    /// </summary>
    [EnumMember(Value = "CNTY")]
    [IsoId("_uMAevPRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by county jurisdications within a country.")]
    CountyTax,

    /// <summary>
    /// Tax accessed by local jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_uMKPsPRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by local jurisdications within a country.")]
    LocalTax,

    /// <summary>
    /// Tax accessed by province jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_uMKPs_RYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by province jurisdications within a country.")]
    ProvinceTax,

    /// <summary>
    /// Tax accessed by state jurisdications within a country.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_uMKPtvRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by state jurisdications within a country.")]
    StateTax,
}
