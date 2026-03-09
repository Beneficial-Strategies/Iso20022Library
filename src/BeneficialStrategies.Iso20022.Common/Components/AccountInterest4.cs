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
/// Provides further details on the interest that applies to the account at a particular moment in time.
/// </summary>
[IsoId("_wDb1Aa6FEeexrtTFgmVD3Q")]
[DisplayName("Account Interest")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountInterest4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_wL7Co66FEeexrtTFgmVD3Q")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestType1Choice_? Type { get; init; } 
    #else
    public InterestType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    [IsoId("_wL7Cpa6FEeexrtTFgmVD3Q")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate4? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate4? Rate { get; init; } 
    #else
    public Rate4? Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    [IsoId("_wL7Cp66FEeexrtTFgmVD3Q")]
    [DisplayName("From To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrToDt")]
    #endif
    [IsoXmlTag("FrToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1? FromToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1? FromToDate { get; init; } 
    #else
    public DateTimePeriod1? FromToDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    [IsoId("_wL7Cqa6FEeexrtTFgmVD3Q")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    [IsoId("_wL7Cq66FEeexrtTFgmVD3Q")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCharges2? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCharges2? Tax { get; init; } 
    #else
    public TaxCharges2? Tax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
