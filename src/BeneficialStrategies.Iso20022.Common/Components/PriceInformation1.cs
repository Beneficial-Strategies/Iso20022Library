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
[IsoId("_U49RA9p-Ed-ak6NoX_4Aeg_-2122379247")]
[DisplayName("Price Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceInformation1( PriceRateOrAmountOrUnknownChoice_ reqValue,TypeOfPrice5Code reqType )
    {
        Value = reqValue;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U49RBNp-Ed-ak6NoX_4Aeg_-1294906390")]
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
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_U49RBdp-Ed-ak6NoX_4Aeg_-1379868804")]
    [DisplayName("Value Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValTp")]
    #endif
    [IsoXmlTag("ValTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValueType2Code? ValueType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueType2Code? ValueType { get; init; } 
    #else
    public PriceValueType2Code? ValueType { get; set; } 
    #endif
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U49RBtp-Ed-ak6NoX_4Aeg_-851613313")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice5Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice5Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice5Code Type { get; init; } 
    #else
    public TypeOfPrice5Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_U49RB9p-Ed-ak6NoX_4Aeg_-1267199751")]
    [DisplayName("Source Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcOfPric")]
    #endif
    [IsoXmlTag("SrcOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceSourceFormatChoice_? SourceOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceSourceFormatChoice_? SourceOfPrice { get; init; } 
    #else
    public PriceSourceFormatChoice_? SourceOfPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_U49RCNp-Ed-ak6NoX_4Aeg_-1265350672")]
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
    
    /// <summary>
    /// Indicates whether the price is expressed as a yield. The absence of Yielded means it is not applicable.
    /// </summary>
    [IsoId("_U5HCANp-Ed-ak6NoX_4Aeg_-1233950935")]
    [DisplayName("Yielded")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Yldd")]
    #endif
    [IsoXmlTag("Yldd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Yielded { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Yielded { get; init; } 
    #else
    public System.String? Yielded { get; set; } 
    #endif
    
    
    #nullable disable
    
}
