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
[IsoId("__y4bwTAiEeOUGqA1wUwNLA")]
[DisplayName("Price Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceInformation11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceInformation11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceInformation11( Price4 reqValue )
    {
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the price, for instance, as a currency and value.
    /// </summary>
    [IsoId("_AJ8Q4zAjEeOUGqA1wUwNLA")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Price4 Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Price4 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4 Value { get; init; } 
    #else
    public Price4 Value { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_AJ8Q5TAjEeOUGqA1wUwNLA")]
    [DisplayName("Quotation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtnDt")]
    #endif
    [IsoXmlTag("QtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime1Choice_? QuotationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime1Choice_? QuotationDate { get; init; } 
    #else
    public DateAndDateTime1Choice_? QuotationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the price of a security is determined (For outturn securities).
    /// </summary>
    [IsoId("_AJ8Q7TAjEeOUGqA1wUwNLA")]
    [DisplayName("Price Calculation Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricClctnPrd")]
    #endif
    [IsoXmlTag("PricClctnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriodChoice_? PriceCalculationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriodChoice_? PriceCalculationPeriod { get; init; } 
    #else
    public DateTimePeriodChoice_? PriceCalculationPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_AJ8Q7zAjEeOUGqA1wUwNLA")]
    [DisplayName("Source Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcOfPric")]
    #endif
    [IsoXmlTag("SrcOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification79? SourceOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification79? SourceOfPrice { get; init; } 
    #else
    public MarketIdentification79? SourceOfPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
