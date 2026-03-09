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
/// Set of elements used to provide detailed information about the security.
/// </summary>
[IsoId("_f2gQwTpyEemk2e6qGBk8IQ")]
[DisplayName("Security Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityCharacteristics3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityCharacteristics3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityCharacteristics3( AmountPricePerFinancialInstrumentQuantity9 reqValuationPrice,ActiveCurrencyAndAmount reqCollateralValue )
    {
        ValuationPrice = reqValuationPrice;
        CollateralValue = reqCollateralValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as known by the account owner, to unambiguously identify the security.
    /// </summary>
    [IsoId("_gGvsMTpyEemk2e6qGBk8IQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? Identification { get; init; } 
    #else
    public SecurityIdentification19? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the position for the security.
    /// </summary>
    [IsoId("_gGvsMzpyEemk2e6qGBk8IQ")]
    [DisplayName("Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pos")]
    #endif
    [IsoXmlTag("Pos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesPosition1? Position { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesPosition1? Position { get; init; } 
    #else
    public SecuritiesPosition1? Position { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the price of the security for valuation purposes.
    /// </summary>
    [IsoId("_gGvsNTpyEemk2e6qGBk8IQ")]
    [DisplayName("Valuation Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnPric")]
    #endif
    [IsoXmlTag("ValtnPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountPricePerFinancialInstrumentQuantity9 ValuationPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountPricePerFinancialInstrumentQuantity9 ValuationPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountPricePerFinancialInstrumentQuantity9 ValuationPrice { get; init; } 
    #else
    public AmountPricePerFinancialInstrumentQuantity9 ValuationPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value of the security for collateral purposes.
    /// </summary>
    [IsoId("_gGvsNzpyEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollVal")]
    #endif
    [IsoXmlTag("CollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount CollateralValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
