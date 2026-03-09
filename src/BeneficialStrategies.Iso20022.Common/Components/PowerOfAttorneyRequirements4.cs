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
/// Conditions to get power of attorney.
/// </summary>
[IsoId("_loYSf609EemDtrWpq90Ckg")]
[DisplayName("Power Of Attorney Requirements")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PowerOfAttorneyRequirements4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Authority that must validate the power of attorney.
    /// </summary>
    [IsoId("_l-Zlpa09EemDtrWpq90Ckg")]
    [DisplayName("Legal Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRqrmnt")]
    #endif
    [IsoXmlTag("LglRqrmnt")]
    [MinLength(0)]
    [MaxLength(4)]
    public SimpleValueList<PowerOfAttorneyLegalisation1Code> LegalRequirement { get; init; } = new SimpleValueList<PowerOfAttorneyLegalisation1Code>(){};
    
    /// <summary>
    /// Documents needed to obtain a valid power of attorney.
    /// </summary>
    [IsoId("_l-Zlp609EemDtrWpq90Ckg")]
    [DisplayName("Other Documentation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDcmnttn")]
    #endif
    [IsoXmlTag("OthrDcmnttn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? OtherDocumentation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherDocumentation { get; init; } 
    #else
    public System.String? OtherDocumentation { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the requested documents must be provided.
    /// </summary>
    [IsoId("_l-Zlqa09EemDtrWpq90Ckg")]
    [DisplayName("Document Submission Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocSubmissnDdln")]
    #endif
    [IsoXmlTag("DocSubmissnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? DocumentSubmissionDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? DocumentSubmissionDeadline { get; init; } 
    #else
    public DateFormat58Choice_? DocumentSubmissionDeadline { get; set; } 
    #endif
    
    
    #nullable disable
    
}
