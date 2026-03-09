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
/// Specifies the details for the adjustment of the mandate.
/// </summary>
[IsoId("_PJFAQGVQEeacpJ-gG9kyUQ")]
[DisplayName("Mandate Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateAdjustment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateAdjustment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateAdjustment1( System.String reqDateAdjustmentRuleIndicator )
    {
        DateAdjustmentRuleIndicator = reqDateAdjustmentRuleIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether an adjustment is to be applied on pre-agreed collection date or not.
    /// </summary>
    [IsoId("_RgDh4GVUEeacpJ-gG9kyUQ")]
    [DisplayName("Date Adjustment Rule Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAdjstmntRuleInd")]
    #endif
    [IsoXmlTag("DtAdjstmntRuleInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator DateAdjustmentRuleIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DateAdjustmentRuleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DateAdjustmentRuleIndicator { get; init; } 
    #else
    public System.String DateAdjustmentRuleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the category of adjustment.
    /// </summary>
    [IsoId("_uNQtMGVUEeacpJ-gG9kyUQ")]
    [DisplayName("Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctgy")]
    #endif
    [IsoXmlTag("Ctgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency37Choice_? Category { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency37Choice_? Category { get; init; } 
    #else
    public Frequency37Choice_? Category { get; set; } 
    #endif
    
    /// <summary>
    /// Pre-agreed amount to increase or decrease the mandate amount as justified per information in the category.
    /// </summary>
    [IsoId("_njXk5WVQEeacpJ-gG9kyUQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Pre-agreed increase or decrease rate that will be applied to the collection amount.
    /// </summary>
    [IsoId("_OG1PAGoEEearR-CA7eRZXQ")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Rate { get; init; } 
    #else
    public System.Decimal? Rate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
