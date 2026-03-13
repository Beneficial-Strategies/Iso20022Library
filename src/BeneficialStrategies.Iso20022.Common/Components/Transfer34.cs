// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_8xSSIYftEeevKP8c-ilVhA")]
[DisplayName("Transfer")]
public partial record Transfer34
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_9DljF4ftEeevKP8c-ilVhA")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_9DljGYftEeevKP8c-ilVhA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference8? ClientReference { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_9DljG4ftEeevKP8c-ilVhA")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference8? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_9DljHYftEeevKP8c-ilVhA")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    
    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [IsoId("_cERoX4ZLEeemXK0UETsSiA")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_9DljH4ftEeevKP8c-ilVhA")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; } 
    
    /// <summary>
    /// Date on which the investor signed the transfer order form.
    /// </summary>
    [IsoId("_9DljIYftEeevKP8c-ilVhA")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransferOrderDateForm { get; init; } 
    
    /// <summary>
    /// Reason for the transfer.
    /// </summary>
    [IsoId("_9DljI4ftEeevKP8c-ilVhA")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1Choice_? TransferReason { get; init; } 
    
    /// <summary>
    /// Specifies information about investment plans included in the holding.
    /// </summary>
    [IsoId("_9DljJYftEeevKP8c-ilVhA")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];
    
    /// <summary>
    /// Information related to the financial instrument to be transferred.
    /// </summary>
    [IsoId("_9DljJ4ftEeevKP8c-ilVhA")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument63 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Total quantity of securities to be transferred, expressed as a number of units or a percentage rate.
    /// </summary>
    [IsoId("_9DljKYftEeevKP8c-ilVhA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity42Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("_9DljK4ftEeevKP8c-ilVhA")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit8? UnitsDetails { get; init; } 
    
    /// <summary>
    /// Rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_9DljLYftEeevKP8c-ilVhA")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; } 
    
    /// <summary>
    /// Value of the security, as booked in the account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_9DljL4ftEeevKP8c-ilVhA")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    
    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_9DljMYftEeevKP8c-ilVhA")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_9DljM4ftEeevKP8c-ilVhA")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    
    /// <summary>
    /// Additional specific settlement information for the fund.
    /// </summary>
    [IsoId("_9DljNYftEeevKP8c-ilVhA")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_9DljN4ftEeevKP8c-ilVhA")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public PartyIdentificationAndAccount156? ReceivingAgentDetails { get; init; } 
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_9DljOYftEeevKP8c-ilVhA")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public PartyIdentificationAndAccount156? DeliveringAgentDetails { get; init; } 
    
    /// <summary>
    /// Specifies how the payment of fees and taxes as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("_9DljO4ftEeevKP8c-ilVhA")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; } 
    
    
    #nullable disable
    
}
