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
/// Contains amount details for a specific type of charge.
/// </summary>
[IsoId("_trtR1vfeEei89sMSHxl1ew")]
[DisplayName("Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amount12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of hours worked. 
    /// </summary>
    [IsoId("_trtR2_feEei89sMSHxl1ew")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TemporaryServicesCharge1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TemporaryServicesCharge1Code? Type { get; init; } 
    #else
    public TemporaryServicesCharge1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of hours worked. 
    /// </summary>
    [IsoId("_trtR2PfeEei89sMSHxl1ew")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the rate per hour. 
    /// </summary>
    [IsoId("_trtR2vfeEei89sMSHxl1ew")]
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
    /// Contains the number of hours worked. 
    /// </summary>
    [IsoId("_trtR2ffeEei89sMSHxl1ew")]
    [DisplayName("Hours")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrs")]
    #endif
    [IsoXmlTag("Hrs")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumericText? Hours { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Hours { get; init; } 
    #else
    public System.String? Hours { get; set; } 
    #endif
    
    
    #nullable disable
    
}
