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
/// Previous employment information.
/// </summary>
[IsoId("_YJCEAHzpEeuEHsEB8Johfw")]
[DisplayName("Employment Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EmploymentDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Current tax code.
    /// </summary>
    [IsoId("_vkTboXzpEeuEHsEB8Johfw")]
    [DisplayName("Tax Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCd")]
    #endif
    [IsoXmlTag("TaxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification36? TaxCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification36? TaxCode { get; init; } 
    #else
    public GenericIdentification36? TaxCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not another tax code exists.
    /// </summary>
    [IsoId("_2hDV4HzqEeuEHsEB8Johfw")]
    [DisplayName("Other Tax Code Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTaxCdInd")]
    #endif
    [IsoXmlTag("OthrTaxCdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OtherTaxCodeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherTaxCodeIndicator { get; init; } 
    #else
    public System.String? OtherTaxCodeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether tax is cumulative or non-cumulative. In the UK, this is known as the W1M1 indicator.
    /// </summary>
    [IsoId("_8YYLEHzpEeuEHsEB8Johfw")]
    [DisplayName("Cumulative Tax Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmltvTaxInd")]
    #endif
    [IsoXmlTag("CmltvTaxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CumulativeTaxIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CumulativeTaxIndicator { get; init; } 
    #else
    public System.String? CumulativeTaxIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the previous pay.
    /// </summary>
    [IsoId("_D_1EoHzqEeuEHsEB8Johfw")]
    [DisplayName("Previous Pay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsPay")]
    #endif
    [IsoXmlTag("PrvsPay")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PreviousPay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PreviousPay { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PreviousPay { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the previous tax.
    /// </summary>
    [IsoId("_Hg2UUHzqEeuEHsEB8Johfw")]
    [DisplayName("Previous Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTax")]
    #endif
    [IsoXmlTag("PrvsTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PreviousTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PreviousTax { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PreviousTax { get; set; } 
    #endif
    
    /// <summary>
    /// Start date of the employment period.
    /// </summary>
    [IsoId("_KV09YHzqEeuEHsEB8Johfw")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat42Choice_? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat42Choice_? StartDate { get; init; } 
    #else
    public DateFormat42Choice_? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// End date of the employment period.
    /// </summary>
    [IsoId("_ydy70HzqEeuEHsEB8Johfw")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat42Choice_? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat42Choice_? EndDate { get; init; } 
    #else
    public DateFormat42Choice_? EndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the employment.
    /// </summary>
    [IsoId("_9IAbwHzqEeuEHsEB8Johfw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
