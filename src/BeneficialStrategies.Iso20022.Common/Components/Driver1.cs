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
/// Fleet vehicle driver.
/// </summary>
[IsoId("_1QhmuPilEeiJaN6-Lf-c_w")]
[DisplayName("Driver")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Driver1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of fleet driver.
    /// </summary>
    [IsoId("_Pe4noP2hEeiS2rs-hXBB5Q")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Fleet driver identification.
    /// </summary>
    [IsoId("_YI80wf2hEeiS2rs-hXBB5Q")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Driving license details.
    /// </summary>
    [IsoId("_1QhmvvilEeiJaN6-Lf-c_w")]
    [DisplayName("Driving License")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvgLic")]
    #endif
    [IsoXmlTag("DrvgLic")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DrivingLicense1? DrivingLicense { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DrivingLicense1? DrivingLicense { get; init; } 
    #else
    public DrivingLicense1? DrivingLicense { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the employer information. 
    /// </summary>
    [IsoId("_9VMyU_imEeiJaN6-Lf-c_w")]
    [DisplayName("Employer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mplyr")]
    #endif
    [IsoXmlTag("Mplyr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Employer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Employer { get; init; } 
    #else
    public System.String? Employer { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the employee identification number as assigned by the fleet operator. 
    /// </summary>
    [IsoId("_9VMyVPimEeiJaN6-Lf-c_w")]
    [DisplayName("Employee Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MplyeeId")]
    #endif
    [IsoXmlTag("MplyeeId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? EmployeeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmployeeIdentification { get; init; } 
    #else
    public System.String? EmployeeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the fleet driver&apos;s department number as assigned by the fleet operator.
    /// </summary>
    [IsoId("_9VMyVfimEeiJaN6-Lf-c_w")]
    [DisplayName("Department Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeptNb")]
    #endif
    [IsoXmlTag("DeptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DepartmentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DepartmentNumber { get; init; } 
    #else
    public System.String? DepartmentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Additional identification used for the driver.
    /// </summary>
    [IsoId("_1QhmufilEeiJaN6-Lf-c_w")]
    [DisplayName("Additional Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlId")]
    #endif
    [IsoXmlTag("AddtlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TravelDocument1? AdditionalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TravelDocument1? AdditionalIdentification { get; init; } 
    #else
    public TravelDocument1? AdditionalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date of birth of vehicle rental driver. 
    /// </summary>
    [IsoId("_1QhmvPilEeiJaN6-Lf-c_w")]
    [DisplayName("Date Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfBirth")]
    #endif
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfBirth { get; init; } 
    #else
    public System.DateOnly? DateOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Additional fleet summary-level information. 
    /// </summary>
    [IsoId("_aXigIPinEeiJaN6-Lf-c_w")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
