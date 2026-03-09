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
/// Additionnal details related to the leg.
/// </summary>
[IsoId("_Na1yQQ8qEeSFHsNYty4C9Q")]
[DisplayName("Instrument Leg")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstrumentLeg6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstrumentLeg6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstrumentLeg6( Side1Code reqLegSide,SettlementDateCode reqLegSettlementType,System.DateTime reqLegSettlementDate,ActiveCurrencyAnd13DecimalAmount reqLegLastPrice,string reqLegSettlementCurrency,CurrencyAndAmount reqLegOrderQuantity,System.UInt64 reqLegForwardPoints,CurrencyAndAmount reqLegCalculatedCounterpartyCurrencyLastQuantity,ActiveCurrencyAndAmount reqLegRiskAmount,AgreedRate3 reqLegValuationRate,System.DateOnly reqLegValueDate,string reqLegCurrency,System.String reqLegSymbol,SecurityIdentification18 reqLegSecurityIdentification )
    {
        LegSide = reqLegSide;
        LegSettlementType = reqLegSettlementType;
        LegSettlementDate = reqLegSettlementDate;
        LegLastPrice = reqLegLastPrice;
        LegSettlementCurrency = reqLegSettlementCurrency;
        LegOrderQuantity = reqLegOrderQuantity;
        LegForwardPoints = reqLegForwardPoints;
        LegCalculatedCounterpartyCurrencyLastQuantity = reqLegCalculatedCounterpartyCurrencyLastQuantity;
        LegRiskAmount = reqLegRiskAmount;
        LegValuationRate = reqLegValuationRate;
        LegValueDate = reqLegValueDate;
        LegCurrency = reqLegCurrency;
        LegSymbol = reqLegSymbol;
        LegSecurityIdentification = reqLegSecurityIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Coded list to specify the side of the trade leg.
    /// </summary>
    [IsoId("_fSM1YA8qEeSFHsNYty4C9Q")]
    [DisplayName("Leg Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegSd")]
    #endif
    [IsoXmlTag("LegSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Side1Code LegSide { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Side1Code LegSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Side1Code LegSide { get; init; } 
    #else
    public Side1Code LegSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date of settlement, in coded form.
    /// </summary>
    [IsoId("__p-20IaQEeSzIqahkBT6cQ")]
    [DisplayName("Leg Settlement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegSttlmTp")]
    #endif
    [IsoXmlTag("LegSttlmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDateCode LegSettlementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDateCode LegSettlementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDateCode LegSettlementType { get; init; } 
    #else
    public SettlementDateCode LegSettlementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time on which the trade will be settled.
    /// </summary>
    [IsoId("_vY7BUA8qEeSFHsNYty4C9Q")]
    [DisplayName("Leg Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegSttlmDt")]
    #endif
    [IsoXmlTag("LegSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime LegSettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime LegSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime LegSettlementDate { get; init; } 
    #else
    public System.DateTime LegSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Execution price of trade leg.
    /// </summary>
    [IsoId("_2PdbUA8qEeSFHsNYty4C9Q")]
    [DisplayName("Leg Last Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegLastPric")]
    #endif
    [IsoXmlTag("LegLastPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd13DecimalAmount LegLastPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd13DecimalAmount LegLastPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount LegLastPrice { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount LegLastPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement currency of trade leg, agreed by both sides of the trade.
    /// </summary>
    [IsoId("__f7hIA8qEeSFHsNYty4C9Q")]
    [DisplayName("Leg Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegSttlmCcy")]
    #endif
    [IsoXmlTag("LegSttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode LegSettlementCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string LegSettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string LegSettlementCurrency { get; init; } 
    #else
    public string LegSettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of trade leg in trading currency.
    /// </summary>
    [IsoId("_CxIzMA8rEeSFHsNYty4C9Q")]
    [DisplayName("Leg Order Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegOrdrQty")]
    #endif
    [IsoXmlTag("LegOrdrQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount LegOrderQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount LegOrderQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount LegOrderQuantity { get; init; } 
    #else
    public CurrencyAndAmount LegOrderQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Forward points added to last spot rate. May be a negative value. Expressed in decimal form.
    /// </summary>
    [IsoId("_cQ3uABF9EeSahYR-dAI4lQ")]
    [DisplayName("Leg Forward Points")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegFwdPts")]
    #endif
    [IsoXmlTag("LegFwdPts")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber LegForwardPoints { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 LegForwardPoints { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 LegForwardPoints { get; init; } 
    #else
    public System.UInt64 LegForwardPoints { get; set; } 
    #endif
    
    /// <summary>
    /// Used for the calculated quantity of the other side of the currency trade. Can be derived from leg order quantity and leg last price.
    /// </summary>
    [IsoId("_k8h2kBF9EeSahYR-dAI4lQ")]
    [DisplayName("Leg Calculated Counterparty Currency Last Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegClctdCtrPtyCcyLastQty")]
    #endif
    [IsoXmlTag("LegClctdCtrPtyCcyLastQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount LegCalculatedCounterpartyCurrencyLastQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount LegCalculatedCounterpartyCurrencyLastQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount LegCalculatedCounterpartyCurrencyLastQuantity { get; init; } 
    #else
    public CurrencyAndAmount LegCalculatedCounterpartyCurrencyLastQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Measurement of the leg trade values in terms of a currency (for example, the amount of trade in US dollars).
    /// </summary>
    [IsoId("_s_18ACKwEeSdYc3boV3myw")]
    [DisplayName("Leg Risk Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegRskAmt")]
    #endif
    [IsoXmlTag("LegRskAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount LegRiskAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount LegRiskAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount LegRiskAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount LegRiskAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the valuation rate used for the trade leg.
    /// </summary>
    [IsoId("_IF3X0BF-EeSahYR-dAI4lQ")]
    [DisplayName("Leg Valuation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegValtnRate")]
    #endif
    [IsoXmlTag("LegValtnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate3 LegValuationRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate3 LegValuationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate3 LegValuationRate { get; init; } 
    #else
    public AgreedRate3 LegValuationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value date of leg spot transaction.
    /// </summary>
    [IsoId("_ZO4uQBF-EeSahYR-dAI4lQ")]
    [DisplayName("Leg Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegValDt")]
    #endif
    [IsoXmlTag("LegValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate LegValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly LegValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly LegValueDate { get; init; } 
    #else
    public System.DateOnly LegValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency trade is conducted.
    /// </summary>
    [IsoId("_bhg4MBF-EeSahYR-dAI4lQ")]
    [DisplayName("Leg Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegCcy")]
    #endif
    [IsoXmlTag("LegCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode LegCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string LegCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string LegCurrency { get; init; } 
    #else
    public string LegCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Symbol of the leg trade.
    /// </summary>
    [IsoId("_0OwKYEeqEeSMv54C-KRx9A")]
    [DisplayName("Leg Symbol")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegSymb")]
    #endif
    [IsoXmlTag("LegSymb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text LegSymbol { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LegSymbol { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LegSymbol { get; init; } 
    #else
    public System.String LegSymbol { get; set; } 
    #endif
    
    /// <summary>
    /// Security identification of the leg trade.
    /// </summary>
    [IsoId("_Hj3xAID7EeSQoe-8fZQlpA")]
    [DisplayName("Leg Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegSctyId")]
    #endif
    [IsoXmlTag("LegSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification18 LegSecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification18 LegSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification18 LegSecurityIdentification { get; init; } 
    #else
    public SecurityIdentification18 LegSecurityIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
