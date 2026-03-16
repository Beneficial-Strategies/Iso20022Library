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
[IsoId("_NJMYgfpeEeCPwaG9zjUPNQ")]
[DisplayName("Transfer")]
public record Transfer11
{
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_gudFcPruEeCJc7cZxzE2fg")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_ylwr8PrzEeCJc7cZxzE2fg")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_hPYp6Qn4EeGN18jOnwLFzg")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference2? CounterpartyReference { get; init; }

    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_zvJzlvsMEeCZF5_uug7xyA")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Identifies in which date the investor signed the transfer order form.
    /// </summary>
    [IsoId("_O7-Wyfu8EeC3VvXpH76gow")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransferOrderDateForm { get; init; }

    /// <summary>
    /// Identifies the transfer reason.
    /// </summary>
    [IsoId("_Zh1Fufr5EeCu2Z1WwxJVWA")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1? TransferReason { get; init; }

    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    [IsoId("_qMLK2fu3EeC3VvXpH76gow")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    /// <summary>
    /// Information related to the financial instrument to be withdrawn.
    /// </summary>
    [IsoId("_qxklpfrtEeCJc7cZxzE2fg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total quantity of securities to be transferred, expressed in a number of units or a percentage rate.
    /// </summary>
    [IsoId("_Hw7wYEZ7EeGxeZmLCxTaOw_-1144008770")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity13Choice_ Quantity { get; init; }

    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_NJMYq_peEeCPwaG9zjUPNQ")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit3? UnitsDetails { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_NJMYr_peEeCPwaG9zjUPNQ")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_NJMYt_peEeCPwaG9zjUPNQ")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Identifies the currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("_tCR4efu7EeC3VvXpH76gow")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public CurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_NJMYs_peEeCPwaG9zjUPNQ")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_NJMYu_peEeCPwaG9zjUPNQ")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }
}
