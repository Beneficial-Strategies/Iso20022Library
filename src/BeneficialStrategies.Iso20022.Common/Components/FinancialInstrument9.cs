// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_ScpmqNp-Ed-ak6NoX_4Aeg_-1986780037")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument9
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_ScywkNp-Ed-ak6NoX_4Aeg_-1986780000")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_Scywkdp-Ed-ak6NoX_4Aeg_-1986779976")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_Scywktp-Ed-ak6NoX_4Aeg_-1986779959")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_Scywk9p-Ed-ak6NoX_4Aeg_-1986779906")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_ScywlNp-Ed-ak6NoX_4Aeg_-1986779664")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_Scywldp-Ed-ak6NoX_4Aeg_-1986779647")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_Scywltp-Ed-ak6NoX_4Aeg_-1986779604")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("_Scywl9p-Ed-ak6NoX_4Aeg_-1986779534")]
    [DisplayName("Dual Fund Indicator")]
    [IsoXmlTag("DualFndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator DualFundIndicator { get; init; }
}
