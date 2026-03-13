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
[IsoId("_3yUHoSPvEeWQjryFgN2ITg")]
[DisplayName("Transfer")]
public partial record Transfer33
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_4PLCtyPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_4PLCuSPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_4PLCuyPvEeWQjryFgN2ITg")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference7? ClientReference { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_4PLCvSPvEeWQjryFgN2ITg")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference7? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_4PLCvyPvEeWQjryFgN2ITg")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_4PLCwSPvEeWQjryFgN2ITg")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public DateAndDateTimeChoice_? EffectiveTransferDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_4PLCwyPvEeWQjryFgN2ITg")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_4PLCxSPvEeWQjryFgN2ITg")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; } 
    
    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is, securities are delivered.
    /// </summary>
    [IsoId("_4PLCxyPvEeWQjryFgN2ITg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public DateAndDateTimeChoice_? TradeDate { get; init; } 
    
    /// <summary>
    /// Identifies in which date the investor signed the transfer order form.
    /// </summary>
    [IsoId("_4PLCySPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransferOrderDateForm { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the assets transfer.
    /// </summary>
    [IsoId("_4PLCyyPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1? TransferReason { get; init; } 
    
    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    [IsoId("_4PLCzSPvEeWQjryFgN2ITg")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];
    
    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    [IsoId("_4PLCzyPvEeWQjryFgN2ITg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument49 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_4PLC0SPvEeWQjryFgN2ITg")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_4PLC0yPvEeWQjryFgN2ITg")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit6? UnitsDetails { get; init; } 
    
    /// <summary>
    /// Weighted average price of the units in the account before the transfer was executed.
    /// </summary>
    [IsoId("_4PLC1SPvEeWQjryFgN2ITg")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    
    /// <summary>
    /// Weighted average price of the units in the account after the transfer was executed.
    /// </summary>
    [IsoId("_4PLC1yPvEeWQjryFgN2ITg")]
    [DisplayName("New Average Price")]
    [IsoXmlTag("NewAvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? NewAveragePrice { get; init; } 
    
    /// <summary>
    /// Trade date of the average weighted data of units in the account before the transfer was executed.
    /// </summary>
    [IsoId("_deruUSVFEeWI0orciOKunQ")]
    [DisplayName("Average Date")]
    [IsoXmlTag("AvrgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AverageDate { get; init; } 
    
    /// <summary>
    /// Trade date of the average weighted data of units in the account after the transfer was executed.
    /// </summary>
    [IsoId("_deruUiVFEeWI0orciOKunQ")]
    [DisplayName("New Average Date")]
    [IsoXmlTag("NewAvrgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NewAverageDate { get; init; } 
    
    /// <summary>
    /// Identifies the currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("_4PLC2SPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_4PLC2yPvEeWQjryFgN2ITg")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_4PLC3SPvEeWQjryFgN2ITg")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_4PLC3yPvEeWQjryFgN2ITg")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public PartyIdentificationAndAccount125? ReceivingAgentDetails { get; init; } 
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_4PLC4SPvEeWQjryFgN2ITg")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public PartyIdentificationAndAccount125? DeliveringAgentDetails { get; init; } 
    
    /// <summary>
    /// Specifies how the payment of charges, taxes and commissions as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("_4PLC4yPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; } 
    
    
    #nullable disable
    
}
