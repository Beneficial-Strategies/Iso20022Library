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
[IsoId("_m-lZofNBEeCuA5Tr22BnwA_448139482")]
[DisplayName("Price Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceInformation10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceInformation10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceInformation10( ActiveOrHistoricCurrencyAnd13DecimalAmount reqCurrentPrice,TypeOfPrice27Choice_ reqType )
    {
        CurrentPrice = reqCurrentPrice;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Current value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_m-lZovNBEeCuA5Tr22BnwA_947656184")]
    [DisplayName("Current Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurPric")]
    #endif
    [IsoXmlTag("CurPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount CurrentPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount CurrentPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount CurrentPrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount CurrentPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_m-lZo_NBEeCuA5Tr22BnwA_334300416")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice27Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice27Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice27Choice_ Type { get; init; } 
    #else
    public TypeOfPrice27Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Previous value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_m-lZpPNBEeCuA5Tr22BnwA_-389486155")]
    [DisplayName("Previous Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsPric")]
    #endif
    [IsoXmlTag("PrvsPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? PreviousPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? PreviousPrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? PreviousPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Difference or change between the previous price value and the current price value.
    /// </summary>
    [IsoId("_m-lZpfNBEeCuA5Tr22BnwA_-662771937")]
    [DisplayName("Amount Of Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtOfChng")]
    #endif
    [IsoXmlTag("AmtOfChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValueAndRate4? AmountOfChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueAndRate4? AmountOfChange { get; init; } 
    #else
    public PriceValueAndRate4? AmountOfChange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
