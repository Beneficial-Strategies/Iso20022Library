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
[IsoId("_hg1eYJkYEeu3i5QmrY5b7Q")]
[Description(
    @"Specifies the external rates and tenors code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalRatesAndTenors1Code))]
public enum ExternalRatesAndTenorsCode
{
    /// <summary>
    /// Euro short-term rate.
    /// Encoded/decoded by serializers as &quot;ESTR&quot;.
    /// </summary>
    [EnumMember(Value = "ESTR")]
    [IsoId("_Sbs9wATxEey95qpfbNuEwg")]
    [Description(@"Euro short-term rate.")]
    EuroShortTermRate,

    /// <summary>
    /// Euro Overnight Index Swap (ESTROIS) 1 day, 1 week, other tenors.
    /// Encoded/decoded by serializers as &quot;ESOI&quot;.
    /// </summary>
    [EnumMember(Value = "ESOI")]
    [IsoId("_s_wEMATxEey95qpfbNuEwg")]
    [Description(@"Euro Overnight Index Swap (ESTROIS) 1 day, 1 week, other tenors.")]
    EuroOvernightIndexSwap,

    /// <summary>
    /// Euro interbank offered rate (3 months, 6 months and other tenors).
    /// Encoded/decoded by serializers as &quot;EURI&quot;.
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_6EmakATxEey95qpfbNuEwg")]
    [Description(@"Euro interbank offered rate (3 months, 6 months and other tenors).")]
    Euribor,

    /// <summary>
    /// Pound sterling London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate.
    /// Encoded/decoded by serializers as &quot;GBPO&quot;.
    /// </summary>
    [EnumMember(Value = "GBPO")]
    [IsoId("_MN2e8ATyEey95qpfbNuEwg")]
    [Description(
        @"Pound sterling London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate."
    )]
    GBPLibor,

    /// <summary>
    /// Other floating rates and tenors.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_S7c_YATyEey95qpfbNuEwg")]
    [Description(@"Other floating rates and tenors.")]
    Other,

    /// <summary>
    /// Secured overnight financing rate (1 months, 3 months, other tenors).
    /// Encoded/decoded by serializers as &quot;SOFR&quot;.
    /// </summary>
    [EnumMember(Value = "SOFR")]
    [IsoId("_YfSbYATyEey95qpfbNuEwg")]
    [Description(@"Secured overnight financing rate (1 months, 3 months, other tenors).")]
    SecuredOvernightFinancingRate,

    /// <summary>
    /// US dollar London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate.
    /// Encoded/decoded by serializers as &quot;USPO&quot;.
    /// </summary>
    [EnumMember(Value = "USPO")]
    [IsoId("_iDR6IATyEey95qpfbNuEwg")]
    [Description(
        @"US dollar London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate."
    )]
    USDLibor,

    /// <summary>
    /// US dollar overnight index swap (1 day, 1 week, other tenors), USDOIS.
    /// Encoded/decoded by serializers as &quot;USOI&quot;.
    /// </summary>
    [EnumMember(Value = "USOI")]
    [IsoId("_mno2IATyEey95qpfbNuEwg")]
    [Description(@"US dollar overnight index swap (1 day, 1 week, other tenors), USDOIS.")]
    USDOvernightIndexSwap,
}
