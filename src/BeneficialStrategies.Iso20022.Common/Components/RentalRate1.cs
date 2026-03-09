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
/// Vehicle rental rate
/// </summary>
[IsoId("_jy_0d_S2Eeife6veM7daYw")]
[DisplayName("Rental Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RentalRate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unit of measure used to compute the rental rate.
    /// </summary>
    [IsoId("_jy_0e_S2Eeife6veM7daYw")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PeriodUnit3Code? Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PeriodUnit3Code? Period { get; init; } 
    #else
    public PeriodUnit3Code? Period { get; set; } 
    #endif
    
    /// <summary>
    /// Other unit of measure used to compute the rental rate.
    /// </summary>
    [IsoId("_jy_0fPS2Eeife6veM7daYw")]
    [DisplayName("Other Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPrd")]
    #endif
    [IsoXmlTag("OthrPrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherPeriod { get; init; } 
    #else
    public System.String? OtherPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Rate applied to the vehicle rental for the specified period. 
    /// </summary>
    [IsoId("_jy_0evS2Eeife6veM7daYw")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Rate { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of the period for which the rental rate is calculated. 
    /// </summary>
    [IsoId("_jy_0ffS2Eeife6veM7daYw")]
    [DisplayName("Period Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdCnt")]
    #endif
    [IsoXmlTag("PrdCnt")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? PeriodCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PeriodCount { get; init; } 
    #else
    public System.String? PeriodCount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
