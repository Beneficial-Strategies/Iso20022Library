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
/// Card used to represent a financial account for the purpose of payment settlement.
/// </summary>
[IsoId("_Sp--1gEcEeCQm6a_G2yO_w_-1939966628")]
[DisplayName("Financial Card")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialCard1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Monetary value of the credit limit for this financial card.
    /// </summary>
    [IsoId("_Sp--1wEcEeCQm6a_G2yO_w_-447801115")]
    [DisplayName("Credit Limit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtLmtAmt")]
    #endif
    [IsoXmlTag("CdtLmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? CreditLimitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? CreditLimitAmount { get; init; } 
    #else
    public CurrencyAndAmount? CreditLimitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of the credit available for this financial card.
    /// </summary>
    [IsoId("_Sp--2AEcEeCQm6a_G2yO_w_-496515812")]
    [DisplayName("Credit Available Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtAvlblAmt")]
    #endif
    [IsoXmlTag("CdtAvlblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? CreditAvailableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? CreditAvailableAmount { get; init; } 
    #else
    public CurrencyAndAmount? CreditAvailableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate expressed as a percentage for this financial card.
    /// </summary>
    [IsoId("_Sp--2QEcEeCQm6a_G2yO_w_1183955283")]
    [DisplayName("Interest Rate Percent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRatePct")]
    #endif
    [IsoXmlTag("IntrstRatePct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InterestRatePercent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestRatePercent { get; init; } 
    #else
    public System.Decimal? InterestRatePercent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
