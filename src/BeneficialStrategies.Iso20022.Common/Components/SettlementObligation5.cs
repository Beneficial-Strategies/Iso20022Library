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
/// Provides details about the settlement obligation.
/// </summary>
[IsoId("_-ezL8aMOEeCojJW5vEuTEQ_1121588279")]
[DisplayName("Settlement Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementObligation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementObligation5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementObligation5( FinancialInstrumentQuantity1Choice_ reqQuantity,AmountAndDirection27 reqSettlementAmount,System.DateOnly reqSettlementDate,ReceiveDelivery1Code reqSecuritiesMovementType,DeliveryReceiptType2Code reqPayment )
    {
        Quantity = reqQuantity;
        SettlementAmount = reqSettlementAmount;
        SettlementDate = reqSettlementDate;
        SecuritiesMovementType = reqSecuritiesMovementType;
        Payment = reqPayment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of an existing obligation that is linked to the new obligation.
    /// </summary>
    [IsoId("_-ezL8qMOEeCojJW5vEuTEQ_1007749213")]
    [DisplayName("Related Settlement Obligation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdSttlmOblgtnId")]
    #endif
    [IsoXmlTag("RltdSttlmOblgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedSettlementObligationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedSettlementObligationIdentification { get; init; } 
    #else
    public System.String? RelatedSettlementObligationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of the obligation.
    /// </summary>
    [IsoId("_-ezL86MOEeCojJW5vEuTEQ_10676860")]
    [DisplayName("Obligation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgtnTp")]
    #endif
    [IsoXmlTag("OblgtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ObligationType1Choice_? ObligationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ObligationType1Choice_? ObligationType { get; init; } 
    #else
    public ObligationType1Choice_? ObligationType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information related to the linked obligation.
    /// </summary>
    [IsoId("_-ezL9KMOEeCojJW5vEuTEQ_-986395493")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the original trade date.
    /// </summary>
    [IsoId("_-ezL9aMOEeCojJW5vEuTEQ_-1983467846")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TradeDate { get; init; } 
    #else
    public System.DateOnly? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the quantity related to the settlement obligation.
    /// </summary>
    [IsoId("_-ezL9qMOEeCojJW5vEuTEQ_1428266163")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the price applied to that net position.
    /// </summary>
    [IsoId("_-ezL96MOEeCojJW5vEuTEQ_431193810")]
    [DisplayName("Net Position Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPosPric")]
    #endif
    [IsoXmlTag("NetPosPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price4? NetPositionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4? NetPositionPrice { get; init; } 
    #else
    public Price4? NetPositionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_-e888KMOEeCojJW5vEuTEQ_-565878543")]
    [DisplayName("Trading Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgCcy")]
    #endif
    [IsoXmlTag("TradgCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? TradingCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TradingCurrency { get; init; } 
    #else
    public string? TradingCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the total amount to be settled.
    /// </summary>
    [IsoId("_-e888aMOEeCojJW5vEuTEQ_-679717609")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection27 SettlementAmount { get; init; } 
    #else
    public AmountAndDirection27 SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_-e888qMOEeCojJW5vEuTEQ_-1676789962")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly SettlementDate { get; init; } 
    #else
    public System.DateOnly SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the obligation will result in a receive or a delivery of securities.
    /// </summary>
    [IsoId("_-e8886MOEeCojJW5vEuTEQ_1734944047")]
    [DisplayName("Securities Movement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntTp")]
    #endif
    [IsoXmlTag("SctiesMvmntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #else
    public ReceiveDelivery1Code SecuritiesMovementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// </summary>
    [IsoId("_-e889KMOEeCojJW5vEuTEQ_1621104981")]
    [DisplayName("Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pmt")]
    #endif
    [IsoXmlTag("Pmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeliveryReceiptType2Code Payment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DeliveryReceiptType2Code Payment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReceiptType2Code Payment { get; init; } 
    #else
    public DeliveryReceiptType2Code Payment { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the references of the underlying trade leg(s) and/or the reference to the related net position message.
    /// </summary>
    [IsoId("_-e889aMOEeCojJW5vEuTEQ_624032628")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reference19? References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reference19? References { get; init; } 
    #else
    public Reference19? References { get; set; } 
    #endif
    
    
    #nullable disable
    
}
