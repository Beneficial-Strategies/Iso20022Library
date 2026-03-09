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
/// Sensitive data associated with a payment card.
/// </summary>
[IsoId("_VZbFQSFPEey8XKHwKquEQw")]
[DisplayName("Plain Card Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PlainCardData21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the driver or vehicle.
    /// </summary>
    [IsoId("_VfOyUSFPEey8XKHwKquEQw")]
    [DisplayName("Driver Or Vehicle Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrOrVhclId")]
    #endif
    [IsoXmlTag("DrvrOrVhclId")]
    [IsoSimpleType(IsoSimpleType.Max20Text)]
    [StringLength(maximumLength: 20 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20Text? DriverOrVehicleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DriverOrVehicleIdentification { get; init; } 
    #else
    public System.String? DriverOrVehicleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional card specific data.
    /// </summary>
    [IsoId("_VfOyUyFPEey8XKHwKquEQw")]
    [DisplayName("Additional Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCardData")]
    #endif
    [IsoXmlTag("AddtlCardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalCardData { get; init; } 
    #else
    public AdditionalData1? AdditionalCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
