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
/// Vehicle for hire for passenger transport - excludes vehicles driven by a renter.  Examples include, but are not limited to, taxi, chauffered limousine, boats.
/// </summary>
[IsoId("_nUxnfPQZEeihCvvpsmGI2w")]
[DisplayName("Hired Vehicle")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HiredVehicle1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the type of company or vehicle being hired (for example, private, taxi, chauffeur service, rideshare).
    /// </summary>
    [IsoId("_nUxngfQZEeihCvvpsmGI2w")]
    [DisplayName("Company Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnyTp")]
    #endif
    [IsoXmlTag("CpnyTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CompanyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CompanyType { get; init; } 
    #else
    public System.String? CompanyType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the name of the company that provided the hired vehicle services. 
    /// </summary>
    [IsoId("_nUxnhvQZEeihCvvpsmGI2w")]
    [DisplayName("Company Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnyNm")]
    #endif
    [IsoXmlTag("CpnyNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CompanyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CompanyName { get; init; } 
    #else
    public System.String? CompanyName { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the type of vehicle that was hired (for example, limousine, black, SUV). 
    /// </summary>
    [IsoId("_nUxnhfQZEeihCvvpsmGI2w")]
    [DisplayName("Type Of Vehicle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfVhcl")]
    #endif
    [IsoXmlTag("TpOfVhcl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TypeOfVehicle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TypeOfVehicle { get; init; } 
    #else
    public System.String? TypeOfVehicle { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the identifier assigned to the vehicle.
    /// </summary>
    [IsoId("_nUxnffQZEeihCvvpsmGI2w")]
    [DisplayName("Vehicle Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclId")]
    #endif
    [IsoXmlTag("VhclId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? VehicleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VehicleIdentification { get; init; } 
    #else
    public System.String? VehicleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the identifier assigned to the driver.
    /// </summary>
    [IsoId("_nUxnf_QZEeihCvvpsmGI2w")]
    [DisplayName("Driver Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrId")]
    #endif
    [IsoXmlTag("DrvrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DriverIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DriverIdentification { get; init; } 
    #else
    public System.String? DriverIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the tax identifier assigned to the driver.
    /// </summary>
    [IsoId("_nUxngPQZEeihCvvpsmGI2w")]
    [DisplayName("Driver Tax Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrTaxId")]
    #endif
    [IsoXmlTag("DrvrTaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DriverTaxIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DriverTaxIdentification { get; init; } 
    #else
    public System.String? DriverTaxIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Destination of the hired vehicle. 
    /// </summary>
    [IsoId("_nUxng_QZEeihCvvpsmGI2w")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Destination2? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Destination2? Destination { get; init; } 
    #else
    public Destination2? Destination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
