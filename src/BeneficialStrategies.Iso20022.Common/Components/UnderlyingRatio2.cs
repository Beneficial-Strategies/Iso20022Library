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
/// Related financial instrument into which the security can be converted.
/// </summary>
[IsoId("_XOn1CY-eEeaEa8S_GI1QNA")]
[DisplayName("Underlying Ratio")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingRatio2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnderlyingRatio2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnderlyingRatio2( FinancialInstrumentQuantity1Choice_ reqUnderlyingQuantityDenominator,FinancialInstrumentQuantity1Choice_ reqUnderlyingQuantityNumerator )
    {
        UnderlyingQuantityDenominator = reqUnderlyingQuantityDenominator;
        UnderlyingQuantityNumerator = reqUnderlyingQuantityNumerator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of held securities for the exercise.
    /// </summary>
    [IsoId("_XcwXgY-eEeaEa8S_GI1QNA")]
    [DisplayName("Underlying Quantity Denominator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygQtyDnmtr")]
    #endif
    [IsoXmlTag("UndrlygQtyDnmtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ UnderlyingQuantityDenominator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ UnderlyingQuantityDenominator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ UnderlyingQuantityDenominator { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ UnderlyingQuantityDenominator { get; set; } 
    #endif
    
    /// <summary>
    /// Number of related securities for the exercise.
    /// </summary>
    [IsoId("_XcwXg4-eEeaEa8S_GI1QNA")]
    [DisplayName("Underlying Quantity Numerator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygQtyNmrtr")]
    #endif
    [IsoXmlTag("UndrlygQtyNmrtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ UnderlyingQuantityNumerator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ UnderlyingQuantityNumerator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ UnderlyingQuantityNumerator { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ UnderlyingQuantityNumerator { get; set; } 
    #endif
    
    /// <summary>
    /// Related security into which the security can be converted.
    /// </summary>
    [IsoId("_XcwXhY-eEeaEa8S_GI1QNA")]
    [DisplayName("Related Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdFinInstrmId")]
    #endif
    [IsoXmlTag("RltdFinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? RelatedFinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? RelatedFinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19? RelatedFinancialInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
