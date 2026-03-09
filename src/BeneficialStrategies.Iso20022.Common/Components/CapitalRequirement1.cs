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
/// Report of the breakdown of the components for the capital requirement for central counterparty.
/// </summary>
[IsoId("_ltqioLIfEeaYqc4G3TTwhA")]
[DisplayName("Capital Requirement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CapitalRequirement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CapitalRequirement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CapitalRequirement1( ActiveCurrencyAndAmount reqWindingDownOrRestructuringRisk,ActiveCurrencyAndAmount reqOperationalAndLegalRisk,ActiveCurrencyAndAmount reqCreditRisk,ActiveCurrencyAndAmount reqCounterPartyRisk,ActiveCurrencyAndAmount reqMarketRisk,ActiveCurrencyAndAmount reqBusinessRisk )
    {
        WindingDownOrRestructuringRisk = reqWindingDownOrRestructuringRisk;
        OperationalAndLegalRisk = reqOperationalAndLegalRisk;
        CreditRisk = reqCreditRisk;
        CounterPartyRisk = reqCounterPartyRisk;
        MarketRisk = reqMarketRisk;
        BusinessRisk = reqBusinessRisk;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the capital necessary to cover the winding down or restructuring of activities.
    /// </summary>
    [IsoId("_xYZEYLIfEeaYqc4G3TTwhA")]
    [DisplayName("Winding Down Or Restructuring Risk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WndgDwnOrRstrgRsk")]
    #endif
    [IsoXmlTag("WndgDwnOrRstrgRsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount WindingDownOrRestructuringRisk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount WindingDownOrRestructuringRisk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount WindingDownOrRestructuringRisk { get; init; } 
    #else
    public ActiveCurrencyAndAmount WindingDownOrRestructuringRisk { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the capital necessary to cover the overall operational and legal risks.
    /// </summary>
    [IsoId("_5dimkLIfEeaYqc4G3TTwhA")]
    [DisplayName("Operational And Legal Risk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprlAndLglRsk")]
    #endif
    [IsoXmlTag("OprlAndLglRsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount OperationalAndLegalRisk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount OperationalAndLegalRisk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount OperationalAndLegalRisk { get; init; } 
    #else
    public ActiveCurrencyAndAmount OperationalAndLegalRisk { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the capital necessary to cover credit risks not already covered by other financial resources, such as risks stemming from clearing activity.
    /// </summary>
    [IsoId("_9K1-wLIfEeaYqc4G3TTwhA")]
    [DisplayName("Credit Risk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtRsk")]
    #endif
    [IsoXmlTag("CdtRsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CreditRisk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CreditRisk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CreditRisk { get; init; } 
    #else
    public ActiveCurrencyAndAmount CreditRisk { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the capital necessary to cover counterparty credit risks not already covered by other financial resources, such as risks stemming from clearing activity.
    /// </summary>
    [IsoId("_Bn5Y4LIgEeaYqc4G3TTwhA")]
    [DisplayName("Counter Party Risk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrPtyRsk")]
    #endif
    [IsoXmlTag("CntrPtyRsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CounterPartyRisk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CounterPartyRisk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CounterPartyRisk { get; init; } 
    #else
    public ActiveCurrencyAndAmount CounterPartyRisk { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the capital necessary to cover counterparty market risks not already covered by other financial resources, such as risks stemming from clearing activity.
    /// </summary>
    [IsoId("_ELG8gLIgEeaYqc4G3TTwhA")]
    [DisplayName("Market Risk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktRsk")]
    #endif
    [IsoXmlTag("MktRsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount MarketRisk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount MarketRisk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount MarketRisk { get; init; } 
    #else
    public ActiveCurrencyAndAmount MarketRisk { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the capital necessary to cover business risk.
    /// </summary>
    [IsoId("_GmI0gLIgEeaYqc4G3TTwhA")]
    [DisplayName("Business Risk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizRsk")]
    #endif
    [IsoXmlTag("BizRsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount BusinessRisk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount BusinessRisk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount BusinessRisk { get; init; } 
    #else
    public ActiveCurrencyAndAmount BusinessRisk { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the percentage above 100 percent of the CCP’s required capital requiring notification to the CCP’s National Competent Authority threshold.
    /// </summary>
    [IsoId("_bslp0LIgEeaYqc4G3TTwhA")]
    [DisplayName("Notification Buffer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnBffr")]
    #endif
    [IsoXmlTag("NtfctnBffr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? NotificationBuffer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NotificationBuffer { get; init; } 
    #else
    public System.Decimal? NotificationBuffer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
