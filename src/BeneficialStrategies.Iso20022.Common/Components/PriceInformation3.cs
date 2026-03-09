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
[IsoId("_Qf60NNp-Ed-ak6NoX_4Aeg_-1826849881")]
[DisplayName("Price Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceInformation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceInformation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceInformation3( PriceRateOrAmountOrUnknownChoice_ reqValue,UnitPriceType1Choice_ reqPriceType )
    {
        Value = reqValue;
        PriceType = reqPriceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_Qf60Ndp-Ed-ak6NoX_4Aeg_-41080249")]
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
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_Qf60Ntp-Ed-ak6NoX_4Aeg_-311662157")]
    [DisplayName("Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricTp")]
    #endif
    [IsoXmlTag("PricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitPriceType1Choice_ PriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitPriceType1Choice_ PriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPriceType1Choice_ PriceType { get; init; } 
    #else
    public UnitPriceType1Choice_ PriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_Qf60N9p-Ed-ak6NoX_4Aeg_-41080187")]
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
    [IsoId("_Qf60ONp-Ed-ak6NoX_4Aeg_-41080157")]
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
    [IsoId("_Qf60Odp-Ed-ak6NoX_4Aeg_-41080156")]
    [DisplayName("Yielded Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="YlddInd")]
    #endif
    [IsoXmlTag("YlddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? YieldedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? YieldedIndicator { get; init; } 
    #else
    public System.String? YieldedIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
