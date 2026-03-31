// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_SbwOyNp-Ed-ak6NoX_4Aeg_-1299179113")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument21
{
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_SbwOydp-Ed-ak6NoX_4Aeg_1884876764")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    [IsoId("_SbwOytp-Ed-ak6NoX_4Aeg_311249008")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_Sb5YsNp-Ed-ak6NoX_4Aeg_-2103412648")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("_Sb5Ysdp-Ed-ak6NoX_4Aeg_-1351365069")]
    [DisplayName("Product Group")]
    [IsoXmlTag("PdctGrp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductGroup { get; init; }

    /// <summary>
    /// Name of the umbrella fund in which financial instrument is contained.
    /// </summary>
    [IsoId("_Sb5Ystp-Ed-ak6NoX_4Aeg_887804411")]
    [DisplayName("Umbrella Name")]
    [IsoXmlTag("UmbrllNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? UmbrellaName { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_Sb5Ys9p-Ed-ak6NoX_4Aeg_838976476")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public ActiveCurrencyCode? BaseCurrency { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_Sb5YtNp-Ed-ak6NoX_4Aeg_-1989573582")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_Sb5Ytdp-Ed-ak6NoX_4Aeg_-244352835")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("_Sb5Yttp-Ed-ak6NoX_4Aeg_2138421400")]
    [DisplayName("Dual Fund Indicator")]
    [IsoXmlTag("DualFndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DualFundIndicator { get; init; }

    /// <summary>
    /// Country where the fund has legal domicile as reflected in the ISIN classification.
    /// </summary>
    [IsoId("_Sb5Yt9p-Ed-ak6NoX_4Aeg_-109267942")]
    [DisplayName("Country Of Domicile")]
    [IsoXmlTag("CtryOfDmcl")]
    public CountryCode? CountryOfDomicile { get; init; }

    /// <summary>
    /// Countries where the fund is registered for distribution.
    /// </summary>
    [IsoId("_Sb5YuNp-Ed-ak6NoX_4Aeg_-992501229")]
    [DisplayName("Registered Distribution Country")]
    [IsoXmlTag("RegdDstrbtnCtry")]
    public SimpleValueList<CountryCode> RegisteredDistributionCountry { get; init; } = [];
}
