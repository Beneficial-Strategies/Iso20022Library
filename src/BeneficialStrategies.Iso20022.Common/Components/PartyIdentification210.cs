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
/// Identification of a party.
/// </summary>
[IsoId("_OIOBdPfUEei89sMSHxl1ew")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification210
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the personal ID associated with the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_OIOBdffUEei89sMSHxl1ew")]
    [DisplayName("Personal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnlId")]
    #endif
    [IsoXmlTag("PrsnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PersonalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PersonalIdentification { get; init; } 
    #else
    public System.String? PersonalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the company-provided ID associated with the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_OIOBd_fUEei89sMSHxl1ew")]
    [DisplayName("Employee Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MplyeeId")]
    #endif
    [IsoXmlTag("MplyeeId")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? EmployeeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmployeeIdentification { get; init; } 
    #else
    public System.String? EmployeeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the name of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_OIOBdvfUEei89sMSHxl1ew")]
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
    /// Contains the professional level of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_h0HkUPfUEei89sMSHxl1ew")]
    [DisplayName("Professional Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrfssnlLvl")]
    #endif
    [IsoXmlTag("PrfssnlLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProfessionalLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProfessionalLevel { get; init; } 
    #else
    public System.String? ProfessionalLevel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
