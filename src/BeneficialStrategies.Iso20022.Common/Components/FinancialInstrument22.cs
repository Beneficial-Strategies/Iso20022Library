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
[IsoId("_Weu8C9p-Ed-ak6NoX_4Aeg_-1232539888")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument22
{
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_Weu8DNp-Ed-ak6NoX_4Aeg_1861417460")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    [IsoId("_We4tANp-Ed-ak6NoX_4Aeg_-132727246")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_We4tAdp-Ed-ak6NoX_4Aeg_-2126871952")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("_We4tAtp-Ed-ak6NoX_4Aeg_173950638")]
    [DisplayName("Product Group")]
    [IsoXmlTag("PdctGrp")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? ProductGroup { get; init; }

    /// <summary>
    /// Name of the umbrella fund in which financial instrument is contained.
    /// </summary>
    [IsoId("_We4tA9p-Ed-ak6NoX_4Aeg_-1820194068")]
    [DisplayName("Umbrella Name")]
    [IsoXmlTag("UmbrllNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? UmbrellaName { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_We4tBNp-Ed-ak6NoX_4Aeg_480628522")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public ActiveCurrencyCode? BaseCurrency { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_We4tBdp-Ed-ak6NoX_4Aeg_-1513516184")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_We4tBtp-Ed-ak6NoX_4Aeg_-900160416")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("_We4tB9p-Ed-ak6NoX_4Aeg_1400662174")]
    [DisplayName("Dual Fund Indicator")]
    [IsoXmlTag("DualFndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DualFundIndicator { get; init; }

    /// <summary>
    /// Country where the fund has legal domicile as reflected in the ISIN classification.
    /// </summary>
    [IsoId("_We4tCNp-Ed-ak6NoX_4Aeg_1625110260")]
    [DisplayName("Country Of Domicile")]
    [IsoXmlTag("CtryOfDmcl")]
    public CountryCode? CountryOfDomicile { get; init; }

    /// <summary>
    /// Countries where the fund is registered for distribution.
    /// </summary>
    [IsoId("_We4tCdp-Ed-ak6NoX_4Aeg_-369034446")]
    [DisplayName("Registered Distribution Country")]
    [IsoXmlTag("RegdDstrbtnCtry")]
    public CountryCode? RegisteredDistributionCountry { get; init; }
}
