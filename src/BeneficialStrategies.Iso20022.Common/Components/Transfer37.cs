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
[IsoId("_5_9k4ZEBEem7fvtoGpNpow")]
[DisplayName("Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transfer37
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transfer37 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transfer37( System.String reqTransferConfirmationReference,System.String reqTransferReference,DateAndDateTime2Choice_ reqEffectiveTransferDate,FinancialInstrument88 reqFinancialInstrumentDetails,System.UInt64 reqTotalUnitsNumber )
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
    /// Unique and unambiguous identifier for the transfer execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("_6U7vVZEBEem7fvtoGpNpow")]
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
    /// Unique and unambiguous identifier for the transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_6U7vV5EBEem7fvtoGpNpow")]
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
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_6U7vWZEBEem7fvtoGpNpow")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? ClientReference { get; init; } 
    #else
    public AdditionalReference10? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_6U7vW5EBEem7fvtoGpNpow")]
    [DisplayName("Counterparty Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRef")]
    #endif
    [IsoXmlTag("CtrPtyRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? CounterpartyReference { get; init; } 
    #else
    public AdditionalReference10? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_6U7vXZEBEem7fvtoGpNpow")]
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
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_6U7vX5EBEem7fvtoGpNpow")]
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
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_6U7vYZEBEem7fvtoGpNpow")]
    [DisplayName("Effective Transfer Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvTrfDt")]
    #endif
    [IsoXmlTag("FctvTrfDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ EffectiveTransferDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ EffectiveTransferDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ EffectiveTransferDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ EffectiveTransferDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_6U7vY5EBEem7fvtoGpNpow")]
    [DisplayName("Effective Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvSttlmDt")]
    #endif
    [IsoXmlTag("FctvSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the transaction is completed and cleared, that is, securities are delivered.
    /// </summary>
    [IsoId("_6U7vZZEBEem7fvtoGpNpow")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? TradeDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the investor signed the transfer order form.
    /// </summary>
    [IsoId("_6U7vZ5EBEem7fvtoGpNpow")]
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
    /// Reason for the transfer.
    /// </summary>
    [IsoId("_6U7vaZEBEem7fvtoGpNpow")]
    [DisplayName("Transfer Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRsn")]
    #endif
    [IsoXmlTag("TrfRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferReason1Choice_? TransferReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferReason1Choice_? TransferReason { get; init; } 
    #else
    public TransferReason1Choice_? TransferReason { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies information about investment plans included in the holding.
    /// </summary>
    [IsoId("_6U7va5EBEem7fvtoGpNpow")]
    [DisplayName("Holdings Plan Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgsPlanTp")]
    #endif
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = new SimpleValueList<HoldingsPlanType1Code>(){};
    
    /// <summary>
    /// Information related to the financial instrument transferred.
    /// </summary>
    [IsoId("_6U7vbZEBEem7fvtoGpNpow")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument88 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument88 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument88 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument88 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units transferred.
    /// </summary>
    [IsoId("_6U7vb5EBEem7fvtoGpNpow")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber TotalUnitsNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalUnitsNumber { get; init; } 
    #else
    public System.UInt64 TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities transferred as a percentage of the holding.
    /// </summary>
    [IsoId("_6U7vcZEBEem7fvtoGpNpow")]
    [DisplayName("Transfer Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRate")]
    #endif
    [IsoXmlTag("TrfRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TransferRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TransferRate { get; init; } 
    #else
    public System.Decimal? TransferRate { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of units transferred.
    /// </summary>
    [IsoId("_6U7vc5EBEem7fvtoGpNpow")]
    [DisplayName("Units Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsDtls")]
    #endif
    [IsoXmlTag("UnitsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Unit12? UnitsDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Unit12? UnitsDetails { get; init; } 
    #else
    public Unit12? UnitsDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_6U7vdZEBEem7fvtoGpNpow")]
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
    /// Original amount paid for the asset at the point of purchase. May also be known as the book cost.
    /// </summary>
    [IsoId("_1mblMZM4EemKz5EOjv82iQ")]
    [DisplayName("Original Cost")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCost")]
    #endif
    [IsoXmlTag("OrgnlCost")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; set; } 
    #endif
    
    /// <summary>
    /// Weighted average price of the units in the account before the transfer was executed.
    /// </summary>
    [IsoId("_6U7vd5EBEem7fvtoGpNpow")]
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
    [IsoId("_6U7veZEBEem7fvtoGpNpow")]
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
    [IsoId("_6U7ve5EBEem7fvtoGpNpow")]
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
    [IsoId("_6U7vfZEBEem7fvtoGpNpow")]
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
    /// Currency used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_6U7vf5EBEem7fvtoGpNpow")]
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
    [IsoId("_6U7vgZEBEem7fvtoGpNpow")]
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
    [IsoId("_6U7vg5EBEem7fvtoGpNpow")]
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
    /// Specifies how the payment of fees and taxes as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("_6U7viZEBEem7fvtoGpNpow")]
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
