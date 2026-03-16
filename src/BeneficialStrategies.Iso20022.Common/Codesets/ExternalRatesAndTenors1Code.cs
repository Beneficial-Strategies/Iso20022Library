// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external rates and tenors code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ukpS8JkYEeu3i5QmrY5b7Q")]
[Description(
    @"Specifies the external rates and tenors code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalRatesAndTenorsCode))]
public enum ExternalRatesAndTenors1Code
{
    /// <summary>
    /// Euro interbank offered rate (3 months, 6 months and other tenors).
    /// Encoded/decoded by serializers as &quot;EURI&quot;.
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_9lCmAQTyEey95qpfbNuEwg")]
    [Description(@"Euro interbank offered rate (3 months, 6 months and other tenors).")]
    Euribor = ExternalRatesAndTenorsCode.Euribor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro Overnight Index Swap (ESTROIS) 1 day, 1 week, other tenors.
    /// Encoded/decoded by serializers as &quot;ESOI&quot;.
    /// </summary>
    [EnumMember(Value = "ESOI")]
    [IsoId("_9rTmEQTyEey95qpfbNuEwg")]
    [Description(@"Euro Overnight Index Swap (ESTROIS) 1 day, 1 week, other tenors.")]
    EuroOvernightIndexSwap = ExternalRatesAndTenorsCode.EuroOvernightIndexSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro short-term rate.
    /// Encoded/decoded by serializers as &quot;ESTR&quot;.
    /// </summary>
    [EnumMember(Value = "ESTR")]
    [IsoId("_9w0YMQTyEey95qpfbNuEwg")]
    [Description(@"Euro short-term rate.")]
    EuroShortTermRate = ExternalRatesAndTenorsCode.EuroShortTermRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pound sterling London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate.
    /// Encoded/decoded by serializers as &quot;GBPO&quot;.
    /// </summary>
    [EnumMember(Value = "GBPO")]
    [IsoId("_97sLcQTyEey95qpfbNuEwg")]
    [Description(
        @"Pound sterling London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate."
    )]
    GBPLibor = ExternalRatesAndTenorsCode.GBPLibor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other floating rates and tenors.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-FiD8QTyEey95qpfbNuEwg")]
    [Description(@"Other floating rates and tenors.")]
    Other = ExternalRatesAndTenorsCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secured overnight financing rate (1 months, 3 months, other tenors).
    /// Encoded/decoded by serializers as &quot;SOFR&quot;.
    /// </summary>
    [EnumMember(Value = "SOFR")]
    [IsoId("_-KcZIQTyEey95qpfbNuEwg")]
    [Description(@"Secured overnight financing rate (1 months, 3 months, other tenors).")]
    SecuredOvernightFinancingRate = ExternalRatesAndTenorsCode.SecuredOvernightFinancingRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US dollar overnight index swap (1 day, 1 week, other tenors), USDOIS.
    /// Encoded/decoded by serializers as &quot;USOI&quot;.
    /// </summary>
    [EnumMember(Value = "USOI")]
    [IsoId("_-P9LQQTyEey95qpfbNuEwg")]
    [Description(@"US dollar overnight index swap (1 day, 1 week, other tenors), USDOIS.")]
    USDOvernightIndexSwap = ExternalRatesAndTenorsCode.USDOvernightIndexSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US dollar London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate.
    /// Encoded/decoded by serializers as &quot;USPO&quot;.
    /// </summary>
    [EnumMember(Value = "USPO")]
    [IsoId("_-U4HgQTyEey95qpfbNuEwg")]
    [Description(
        @"US dollar London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate."
    )]
    USDLibor = ExternalRatesAndTenorsCode.USDLibor, // same ordinal as derivation source for type conversions
}
