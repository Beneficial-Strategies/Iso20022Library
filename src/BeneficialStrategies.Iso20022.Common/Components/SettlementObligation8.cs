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
[IsoId("_71U0BS9dEeS94oXWDaBauA")]
[DisplayName("Settlement Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementObligation8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementObligation8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementObligation8( System.String reqSettlementObligationIdentification,SecurityIdentification14 reqFinancialInstrumentIdentification,DateFormat11Choice_ reqIntendedSettlementDate,FinancialInstrumentQuantity1Choice_ reqQuantity,AmountAndDirection27 reqSettlementAmount,MarketIdentification84 reqPlaceOfTrade,DeliveryReceiptType2Code reqPayment )
    {
        SettlementObligationIdentification = reqSettlementObligationIdentification;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        IntendedSettlementDate = reqIntendedSettlementDate;
        Quantity = reqQuantity;
        SettlementAmount = reqSettlementAmount;
        PlaceOfTrade = reqPlaceOfTrade;
        Payment = reqPayment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the settlement obligation.
    /// </summary>
    [IsoId("_8GvUIS9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Obligation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmOblgtnId")]
    #endif
    [IsoXmlTag("SttlmOblgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SettlementObligationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SettlementObligationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SettlementObligationIdentification { get; init; } 
    #else
    public System.String SettlementObligationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_8GvUIy9dEeS94oXWDaBauA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Intended settlement date of the position.
    /// </summary>
    [IsoId("_8GvUJS9dEeS94oXWDaBauA")]
    [DisplayName("Intended Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntnddSttlmDt")]
    #endif
    [IsoXmlTag("IntnddSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat11Choice_ IntendedSettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat11Choice_ IntendedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat11Choice_ IntendedSettlementDate { get; init; } 
    #else
    public DateFormat11Choice_ IntendedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the quantity related to the settlement obligation.
    /// </summary>
    [IsoId("_8GvUJy9dEeS94oXWDaBauA")]
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
    /// Provides the total amount to be settled.
    /// </summary>
    [IsoId("_8GvUKS9dEeS94oXWDaBauA")]
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
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_8GvUKy9dEeS94oXWDaBauA")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketIdentification84 PlaceOfTrade { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketIdentification84 PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification84 PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification84 PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the trade date.
    /// </summary>
    [IsoId("_8G4eES9dEeS94oXWDaBauA")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate3Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate3Choice_? TradeDate { get; init; } 
    #else
    public TradeDate3Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trading capacity of seller.
    /// </summary>
    [IsoId("_8G4eEy9dEeS94oXWDaBauA")]
    [DisplayName("Trading Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgCpcty")]
    #endif
    [IsoXmlTag("TradgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingCapacity5Code? TradingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingCapacity5Code? TradingCapacity { get; init; } 
    #else
    public TradingCapacity5Code? TradingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the clearing account type.
    /// </summary>
    [IsoId("_8G4eFS9dEeS94oXWDaBauA")]
    [DisplayName("Clearing Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcctTp")]
    #endif
    [IsoXmlTag("ClrAcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingAccountType1Code? ClearingAccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingAccountType1Code? ClearingAccountType { get; init; } 
    #else
    public ClearingAccountType1Code? ClearingAccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_HYJ-AC9eEeS94oXWDaBauA")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing member account at the central securities depository.
    /// </summary>
    [IsoId("_gQ1HwC9eEeS94oXWDaBauA")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the obligation will result in a receive or a delivery of securities.
    /// </summary>
    [IsoId("_8G4eFy9dEeS94oXWDaBauA")]
    [DisplayName("Securities Movement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntTp")]
    #endif
    [IsoXmlTag("SctiesMvmntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceiveDelivery1Code? SecuritiesMovementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiveDelivery1Code? SecuritiesMovementType { get; init; } 
    #else
    public ReceiveDelivery1Code? SecuritiesMovementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount to be paid under a specific obligation.
    /// </summary>
    [IsoId("_8G4eGS9dEeS94oXWDaBauA")]
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
    /// Provides details on the parties that are part of the settlement chain.
    /// </summary>
    [IsoId("_8G4eGy9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPties")]
    #endif
    [IsoXmlTag("SttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties4Choice_? SettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties4Choice_? SettlementParties { get; init; } 
    #else
    public SettlementParties4Choice_? SettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the settlement obligation details.
    /// </summary>
    [IsoId("_8G4eHS9dEeS94oXWDaBauA")]
    [DisplayName("Additional Settlement Obligation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSttlmOblgtnDtls")]
    #endif
    [IsoXmlTag("AddtlSttlmOblgtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementObligation5? AdditionalSettlementObligationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementObligation5? AdditionalSettlementObligationDetails { get; init; } 
    #else
    public SettlementObligation5? AdditionalSettlementObligationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
