// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_-kKO4SPvEeWQjryFgN2ITg")]
[DisplayName("Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transfer31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transfer31 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transfer31( System.String reqTransferConfirmationReference,System.String reqTransferReference,DateAndDateTimeChoice_ reqEffectiveTransferDate,FinancialInstrument49 reqFinancialInstrumentDetails,FinancialInstrumentQuantity1 reqTotalUnitsNumber )
    {
        TransferConfirmationReference = reqTransferConfirmationReference;
        TransferReference = reqTransferReference;
        EffectiveTransferDate = reqEffectiveTransferDate;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        TotalUnitsNumber = reqTotalUnitsNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("__BBJ-SPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Confirmation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfConfRef")]
    #endif
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferConfirmationReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferConfirmationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferConfirmationReference { get; init; } 
    #else
    public System.String TransferConfirmationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("__BBJ-yPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRef")]
    #endif
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferReference { get; init; } 
    #else
    public System.String TransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("__BBJ_SPvEeWQjryFgN2ITg")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference7? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference7? ClientReference { get; init; } 
    #else
    public AdditionalReference7? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("__BBJ_yPvEeWQjryFgN2ITg")]
    [DisplayName("Counterparty Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRef")]
    #endif
    [IsoXmlTag("CtrPtyRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference7? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference7? CounterpartyReference { get; init; } 
    #else
    public AdditionalReference7? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("__BBKASPvEeWQjryFgN2ITg")]
    [DisplayName("Business Flow Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizFlowTp")]
    #endif
    [IsoXmlTag("BizFlowTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    #else
    public BusinessFlowType1Code? BusinessFlowType { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("__BBKAyPvEeWQjryFgN2ITg")]
    [DisplayName("Effective Transfer Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvTrfDt")]
    #endif
    [IsoXmlTag("FctvTrfDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ EffectiveTransferDate { get; init; } 
    #else
    public DateAndDateTimeChoice_ EffectiveTransferDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("__BBKBSPvEeWQjryFgN2ITg")]
    [DisplayName("Requested Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmDt")]
    #endif
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedSettlementDate { get; init; } 
    #else
    public System.DateOnly? RequestedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("__BBKByPvEeWQjryFgN2ITg")]
    [DisplayName("Effective Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvSttlmDt")]
    #endif
    [IsoXmlTag("FctvSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is, securities are delivered.
    /// </summary>
    [IsoId("__BBKCSPvEeWQjryFgN2ITg")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? TradeDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies in which date the investor signed the transfer order form.
    /// </summary>
    [IsoId("__BBKCyPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Order Date Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfOrdrDtForm")]
    #endif
    [IsoXmlTag("TrfOrdrDtForm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TransferOrderDateForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TransferOrderDateForm { get; init; } 
    #else
    public System.DateOnly? TransferOrderDateForm { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the transfer reason.
    /// </summary>
    [IsoId("__BBKDSPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRsn")]
    #endif
    [IsoXmlTag("TrfRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferReason1? TransferReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferReason1? TransferReason { get; init; } 
    #else
    public TransferReason1? TransferReason { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    [IsoId("__BBKDyPvEeWQjryFgN2ITg")]
    [DisplayName("Holdings Plan Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgsPlanTp")]
    #endif
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = new SimpleValueList<HoldingsPlanType1Code>(){};
    
    /// <summary>
    /// Information related to the financial instrument withdrawn.
    /// </summary>
    [IsoId("__BBKESPvEeWQjryFgN2ITg")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument49 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument49 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument49 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument49 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("__BBKEyPvEeWQjryFgN2ITg")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1 TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("__BBKFSPvEeWQjryFgN2ITg")]
    [DisplayName("Units Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsDtls")]
    #endif
    [IsoXmlTag("UnitsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Unit6? UnitsDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Unit6? UnitsDetails { get; init; } 
    #else
    public Unit6? UnitsDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("__BBKFyPvEeWQjryFgN2ITg")]
    [DisplayName("Portfolio Transfer Out Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtflTrfOutRate")]
    #endif
    [IsoXmlTag("PrtflTrfOutRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PortfolioTransferOutRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PortfolioTransferOutRate { get; init; } 
    #else
    public System.Decimal? PortfolioTransferOutRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("__BBKGSPvEeWQjryFgN2ITg")]
    [DisplayName("Rounding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rndg")]
    #endif
    [IsoXmlTag("Rndg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingDirection2Code? Rounding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingDirection2Code? Rounding { get; init; } 
    #else
    public RoundingDirection2Code? Rounding { get; set; } 
    #endif
    
    /// <summary>
    /// Weighted average price of the units in the account before the transfer was executed.
    /// </summary>
    [IsoId("__BBKGyPvEeWQjryFgN2ITg")]
    [DisplayName("Average Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgPric")]
    #endif
    [IsoXmlTag("AvrgPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Weighted average price of the units in the account after the transfer was executed.
    /// </summary>
    [IsoId("__BBKHSPvEeWQjryFgN2ITg")]
    [DisplayName("New Average Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAvrgPric")]
    #endif
    [IsoXmlTag("NewAvrgPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? NewAveragePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? NewAveragePrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? NewAveragePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Trade date of the average weighted data of units in the account before the transfer was executed.
    /// </summary>
    [IsoId("_0ea18CVEEeWI0orciOKunQ")]
    [DisplayName("Average Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgDt")]
    #endif
    [IsoXmlTag("AvrgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? AverageDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? AverageDate { get; init; } 
    #else
    public System.DateOnly? AverageDate { get; set; } 
    #endif
    
    /// <summary>
    /// Trade date of the average weighted data of units in the account after the transfer was executed.
    /// </summary>
    [IsoId("_4uOeQCVEEeWI0orciOKunQ")]
    [DisplayName("New Average Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAvrgDt")]
    #endif
    [IsoXmlTag("NewAvrgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NewAverageDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NewAverageDate { get; init; } 
    #else
    public System.DateOnly? NewAverageDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("__BBKHyPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfCcy")]
    #endif
    [IsoXmlTag("TrfCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TransferCurrency { get; init; } 
    #else
    public string? TransferCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("__BBKISPvEeWQjryFgN2ITg")]
    [DisplayName("Own Account Transfer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnAcctTrfInd")]
    #endif
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OwnAccountTransferIndicator { get; init; } 
    #else
    public System.String? OwnAccountTransferIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("__BBKIyPvEeWQjryFgN2ITg")]
    [DisplayName("Non Standard Settlement Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonStdSttlmInf")]
    #endif
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonStandardSettlementInformation { get; init; } 
    #else
    public System.String? NonStandardSettlementInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("__BBKJSPvEeWQjryFgN2ITg")]
    [DisplayName("Receiving Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgAgtDtls")]
    #endif
    [IsoXmlTag("RcvgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount125? ReceivingAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount125? ReceivingAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount125? ReceivingAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("__BBKJyPvEeWQjryFgN2ITg")]
    [DisplayName("Delivering Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgtDtls")]
    #endif
    [IsoXmlTag("DlvrgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount125? DeliveringAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount125? DeliveringAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount125? DeliveringAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the payment of charges, taxes and commissions as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("__BBKKSPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Expenses Payment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfExpnssPmtTp")]
    #endif
    [IsoXmlTag("TrfExpnssPmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; } 
    #else
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
