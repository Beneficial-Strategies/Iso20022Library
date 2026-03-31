// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_RWwlPfpeEeCPwaG9zjUPNQ")]
[DisplayName("Transfer")]
public record Transfer12
{
    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    [IsoId("_5rbuJfu3EeC3VvXpH76gow")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    /// <summary>
    /// Information related to the financial instrument to be withdrawn.
    /// </summary>
    [IsoId("_oMJXUPr0EeCJc7cZxzE2fg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total quantity of securities to be transferred, expressed in a number of units or a percentage rate.
    /// </summary>
    [IsoId("_HxE6UEZ7EeGxeZmLCxTaOw_1014955380")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity13Choice_ Quantity { get; init; }

    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_RWwla_peEeCPwaG9zjUPNQ")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit3> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_RWwlb_peEeCPwaG9zjUPNQ")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_RWwld_peEeCPwaG9zjUPNQ")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_RWwlc_peEeCPwaG9zjUPNQ")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_RWwle_peEeCPwaG9zjUPNQ")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }
}
