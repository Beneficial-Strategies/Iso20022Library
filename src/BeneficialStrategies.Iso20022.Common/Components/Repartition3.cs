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
[IsoId("_xu_QMQjcEeS5F6qHcKOrew")]
[DisplayName("Repartition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Repartition3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Repartition3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Repartition3( UnitsOrAmountOrPercentage1Choice_ reqQuantity,FinancialInstrument29 reqFinancialInstrument )
    {
        Quantity = reqQuantity;
        FinancialInstrument = reqFinancialInstrument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount, units or percentage of financial instrument invested or withdrawn.
    /// </summary>
    [IsoId("_yKXkoQjcEeS5F6qHcKOrew")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitsOrAmountOrPercentage1Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitsOrAmountOrPercentage1Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitsOrAmountOrPercentage1Choice_ Quantity { get; init; } 
    #else
    public UnitsOrAmountOrPercentage1Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    [IsoId("_yKXkowjcEeS5F6qHcKOrew")]
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
    [IsoId("_yKXkpQjcEeS5F6qHcKOrew")]
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
