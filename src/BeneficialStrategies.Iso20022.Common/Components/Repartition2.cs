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
/// Indicates how the amount of the investment plan is split amongst the funds.
/// </summary>
[IsoId("_j9wpsRQXEeKebsB9eKJSkA")]
[DisplayName("Repartition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Repartition2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Repartition2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Repartition2( System.Decimal reqPercentage,FinancialInstrument29 reqFinancialInstrument )
    {
        Percentage = reqPercentage;
        FinancialInstrument = reqFinancialInstrument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Percentage of amount invested in a funds.
    /// </summary>
    [IsoId("_kSnfYRQXEeKebsB9eKJSkA")]
    [DisplayName("Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pctg")]
    #endif
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Percentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Percentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Percentage { get; init; } 
    #else
    public System.Decimal Percentage { get; set; } 
    #endif
    
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    [IsoId("_kSnfZRQXEeKebsB9eKJSkA")]
    [DisplayName("Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrm")]
    #endif
    [IsoXmlTag("FinInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument29 FinancialInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument29 FinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument29 FinancialInstrument { get; init; } 
    #else
    public FinancialInstrument29 FinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// When a fund has multiple currencies within same ISIN, this indicates the currency of the savings or withdrawal plan.
    /// </summary>
    [IsoId("_vElNIBQXEeKebsB9eKJSkA")]
    [DisplayName("Currency Of Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyOfPlan")]
    #endif
    [IsoXmlTag("CcyOfPlan")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? CurrencyOfPlan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyOfPlan { get; init; } 
    #else
    public string? CurrencyOfPlan { get; set; } 
    #endif
    
    
    #nullable disable
    
}
