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
/// Details of the foreign exchange trade including Spot\Forward\NDF that is captured.
/// </summary>
[IsoId("_IWV_wA2MEeSw7Op2IIeBeQ")]
[DisplayName("Trade")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Trade3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Trade3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Trade3( ActiveCurrencyAnd13DecimalAmount reqExecutionPrice,CurrencyAndAmount reqLastQuantity,SettlementDateCode reqSettlementType,System.DateOnly reqSettlementDate,AgreedRate3 reqValuationRate,CurrencyAndAmount reqCalculatedCounterpartyCurrencyLastQuantity,System.DateOnly reqValueDate,ActiveCurrencyAndAmount reqRiskAmount,SecurityIdentification18 reqSecurityIdentification )
    {
        ExecutionPrice = reqExecutionPrice;
        LastQuantity = reqLastQuantity;
        SettlementType = reqSettlementType;
        SettlementDate = reqSettlementDate;
        ValuationRate = reqValuationRate;
        CalculatedCounterpartyCurrencyLastQuantity = reqCalculatedCounterpartyCurrencyLastQuantity;
        ValueDate = reqValueDate;
        RiskAmount = reqRiskAmount;
        SecurityIdentification = reqSecurityIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Price of the execution of the trade.
    /// </summary>
    [IsoId("_aPM3sQ2MEeSw7Op2IIeBeQ")]
    [DisplayName("Execution Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnPric")]
    #endif
    [IsoXmlTag("ExctnPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd13DecimalAmount ExecutionPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd13DecimalAmount ExecutionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount ExecutionPrice { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount ExecutionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of trade in trading currency.
    /// </summary>
    [IsoId("_ZP3hoQ2MEeSw7Op2IIeBeQ")]
    [DisplayName("Last Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastQty")]
    #endif
    [IsoXmlTag("LastQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount LastQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount LastQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount LastQuantity { get; init; } 
    #else
    public CurrencyAndAmount LastQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the settlment period of the foreign exchange trade.
    /// </summary>
    [IsoId("_5e0S4IaBEeSspsEopx56mg")]
    [DisplayName("Settlement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTp")]
    #endif
    [IsoXmlTag("SttlmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDateCode SettlementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDateCode SettlementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDateCode SettlementType { get; init; } 
    #else
    public SettlementDateCode SettlementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date on which the trade will be settled.
    /// </summary>
    [IsoId("_zqtBsQ2MEeSw7Op2IIeBeQ")]
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
    /// Specifies the valuation rate used for the trade.
    /// </summary>
    [IsoId("_doQmQYaCEeSspsEopx56mg")]
    [DisplayName("Valuation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnRate")]
    #endif
    [IsoXmlTag("ValtnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate3 ValuationRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate3 ValuationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate3 ValuationRate { get; init; } 
    #else
    public AgreedRate3 ValuationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the forward points of the trade if needed.
    /// </summary>
    [IsoId("_N8HR8YaMEeSzIqahkBT6cQ")]
    [DisplayName("Forward Points")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FwdPts")]
    #endif
    [IsoXmlTag("FwdPts")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ForwardPoints { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ForwardPoints { get; init; } 
    #else
    public System.UInt64? ForwardPoints { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of trade in corresponding currency.
    /// </summary>
    [IsoId("_WyqfYQ2MEeSw7Op2IIeBeQ")]
    [DisplayName("Calculated Counterparty Currency Last Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctdCtrPtyCcyLastQty")]
    #endif
    [IsoXmlTag("ClctdCtrPtyCcyLastQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount CalculatedCounterpartyCurrencyLastQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount CalculatedCounterpartyCurrencyLastQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount CalculatedCounterpartyCurrencyLastQuantity { get; init; } 
    #else
    public CurrencyAndAmount CalculatedCounterpartyCurrencyLastQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value date of spot transaction.
    /// </summary>
    [IsoId("_zV_V9A2MEeSw7Op2IIeBeQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValueDate { get; init; } 
    #else
    public System.DateOnly ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Measurement of the amount of the trade values converted in the US dollars.
    /// </summary>
    [IsoId("_sqMCcIaEEeSzIqahkBT6cQ")]
    [DisplayName("Risk Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskAmt")]
    #endif
    [IsoXmlTag("RskAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount RiskAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount RiskAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount RiskAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount RiskAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Security identification of the trade.
    /// </summary>
    [IsoId("_U5Fn8IaIEeSzIqahkBT6cQ")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification18 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification18 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification18 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification18 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the ISO code of the fixing currency.
    /// </summary>
    [IsoId("_4irkELMeEeSOJaFmPosvyg")]
    [DisplayName("Fixing Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxgCcy")]
    #endif
    [IsoXmlTag("FxgCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? FixingCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? FixingCurrency { get; init; } 
    #else
    public string? FixingCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the rate determination is made in the NDF trade.
    /// </summary>
    [IsoId("_YuYQwESYEeS6cOLECtYLrA")]
    [DisplayName("Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxgDt")]
    #endif
    [IsoXmlTag("FxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FixingDate { get; init; } 
    #else
    public System.DateOnly? FixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the spot trade is produced by the option.
    /// </summary>
    [IsoId("_r_EfUESNEeS6cOLECtYLrA")]
    [DisplayName("Option Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnInd")]
    #endif
    [IsoXmlTag("OptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OptionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionIndicator { get; init; } 
    #else
    public System.String? OptionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate the trade whether it&apos;s exchange delta.
    /// </summary>
    [IsoId("_o6Tt0ESNEeS6cOLECtYLrA")]
    [DisplayName("Delta Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DltaInd")]
    #endif
    [IsoXmlTag("DltaInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DeltaIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeltaIndicator { get; init; } 
    #else
    public System.String? DeltaIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Some associated trade reference needs to be specified.
    /// </summary>
    [IsoId("_CP330YaNEeSzIqahkBT6cQ")]
    [DisplayName("Associated Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdTradRef")]
    #endif
    [IsoXmlTag("AssoctdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AssociatedTradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedTradeReference { get; init; } 
    #else
    public System.String? AssociatedTradeReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
