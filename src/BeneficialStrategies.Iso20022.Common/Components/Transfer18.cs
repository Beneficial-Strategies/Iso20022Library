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
[IsoId("_paN3sfsaEeCIi9ZETLBv8g")]
[DisplayName("Transfer")]
public record Transfer18
{
    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_EH8ecfr2EeCJc7cZxzE2fg2")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("__UhLw_r1EeCJc7cZxzE2fg2")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("__UhLyvr1EeCJc7cZxzE2fg2")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_796-dQn3EeGN18jOnwLFzg2")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference2? CounterpartyReference { get; init; }

    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_paXoyvsaEeCIi9ZETLBv8g")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, ie, securities are delivered.
    /// </summary>
    [IsoId("_paXo0fsaEeCIi9ZETLBv8g")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public DateAndDateTimeChoice_? TradeDate { get; init; }

    /// <summary>
    /// Identifies in which date the investor signed the transfer order form.
    /// </summary>
    [IsoId("_gCgZ6fu8EeC3VvXpH76gow")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransferOrderDateForm { get; init; }

    /// <summary>
    /// Specifies the reason for the assets transfer.
    /// </summary>
    [IsoId("_p5z92fsaEeCIi9ZETLBv8g")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1? TransferReason { get; init; }

    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    [IsoId("_admjufu4EeC3VvXpH76gow")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    [IsoId("_paXow_saEeCIi9ZETLBv8g")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_paXo2PsaEeCIi9ZETLBv8g")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; }

    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_paXo3_saEeCIi9ZETLBv8g")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit3> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_paXo7fsaEeCIi9ZETLBv8g")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Identifies the currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("_COfXifu8EeC3VvXpH76gow")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public CurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_paXo5vsaEeCIi9ZETLBv8g")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_paXo9PsaEeCIi9ZETLBv8g")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }
}
