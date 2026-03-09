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
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_JjHxcTnWEeWV5sr121Fc8A")]
[DisplayName("Price Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceInformation13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceInformation13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceInformation13( TypeOfPrice30Choice_ reqType,YieldedOrValueType1Choice_ reqValueType,PriceRateOrAmountOrUnknownChoice_ reqValue )
    {
        Type = reqType;
        ValueType = reqValueType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_KCNhIznWEeWV5sr121Fc8A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice30Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice30Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice30Choice_ Type { get; init; } 
    #else
    public TypeOfPrice30Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_KCNhKznWEeWV5sr121Fc8A")]
    [DisplayName("Value Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValTp")]
    #endif
    [IsoXmlTag("ValTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required YieldedOrValueType1Choice_ ValueType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required YieldedOrValueType1Choice_ ValueType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public YieldedOrValueType1Choice_ ValueType { get; init; } 
    #else
    public YieldedOrValueType1Choice_ ValueType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_KCNhMznWEeWV5sr121Fc8A")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmountOrUnknownChoice_ Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateOrAmountOrUnknownChoice_ Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmountOrUnknownChoice_ Value { get; init; } 
    #else
    public PriceRateOrAmountOrUnknownChoice_ Value { get; set; } 
    #endif
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_KCNhOznWEeWV5sr121Fc8A")]
    [DisplayName("Source Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcOfPric")]
    #endif
    [IsoXmlTag("SrcOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification89? SourceOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification89? SourceOfPrice { get; init; } 
    #else
    public MarketIdentification89? SourceOfPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_KCNhQznWEeWV5sr121Fc8A")]
    [DisplayName("Quotation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtnDt")]
    #endif
    [IsoXmlTag("QtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? QuotationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? QuotationDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? QuotationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
