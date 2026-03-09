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
/// Information about the designation of a currency.
/// </summary>
[IsoId("_k2wBgQdzEeSPHJIdUs1USg")]
[DisplayName("Currency Designation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyDesignation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the currency is settled offshore or onshore.
    /// </summary>
    [IsoId("_vCZ9MAdzEeSPHJIdUs1USg")]
    [DisplayName("Currency Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyDsgnt")]
    #endif
    [IsoXmlTag("CcyDsgnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyDesignation1Code? CurrencyDesignation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyDesignation1Code? CurrencyDesignation { get; init; } 
    #else
    public CurrencyDesignation1Code? CurrencyDesignation { get; set; } 
    #endif
    
    /// <summary>
    /// Offshore location of the currency.
    /// </summary>
    [IsoId("_aIsRcAd1EeSPHJIdUs1USg")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Location { get; init; } 
    #else
    public string? Location { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the off-shore currency.
    /// </summary>
    [IsoId("_dhnVEAd1EeSPHJIdUs1USg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
