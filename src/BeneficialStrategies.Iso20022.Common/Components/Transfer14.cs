// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
[IsoId("_ucCWPfr2EeCJc7cZxzE2fg")]
[DisplayName("Transfer")]
public record Transfer14
{
    /// <summary>
    /// Date and time at which the transfer was received and processed.
    /// </summary>
    [IsoId("_ucCWW_r2EeCJc7cZxzE2fg")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, ie, securities are delivered.
    /// </summary>
    [IsoId("_ucCWX_r2EeCJc7cZxzE2fg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public DateAndDateTimeChoice_? TradeDate { get; init; }

    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    [IsoId("_LMMPJfu4EeC3VvXpH76gow")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    /// <summary>
    /// Information related to the financial instrument withdrawn.
    /// </summary>
    [IsoId("_ywKd1fr2EeCJc7cZxzE2fg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_ucCWY_r2EeCJc7cZxzE2fg")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; }

    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_ucCWZ_r2EeCJc7cZxzE2fg")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit3? UnitsDetails { get; init; }

    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_ucCWa_r2EeCJc7cZxzE2fg")]
    [DisplayName("Portfolio Transfer Out Rate")]
    [IsoXmlTag("PrtflTrfOutRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PortfolioTransferOutRate { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_ucCWb_r2EeCJc7cZxzE2fg")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_ucCWd_r2EeCJc7cZxzE2fg")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_ucCWc_r2EeCJc7cZxzE2fg")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_ucCWe_r2EeCJc7cZxzE2fg")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }
}
