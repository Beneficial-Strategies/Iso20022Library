// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// First name of a person.
/// </summary>
[IsoId("_SHAG4Q2fEeSNWNtJlXOAhg")]
[DisplayName("Individual Person Name Long")]
public partial record IndividualPersonNameLong1
{
    #nullable enable
    
    /// <summary>
    /// Prefix, as a title before a person&apos;s name.
    /// </summary>
    [IsoId("_NQTy0A2hEeSNWNtJlXOAhg")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Choice_? NamePrefix { get; init; } 
    
    /// <summary>
    /// Surname is a name added to a given name and is part of a personal name. In many cases, a surname is a family name.
    /// </summary>
    [IsoId("_6VThYA2gEeSNWNtJlXOAhg")]
    [DisplayName("Surname")]
    [IsoXmlTag("Srnm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Surname { get; init; } 
    
    /// <summary>
    /// Name given at birth.
    /// </summary>
    [IsoId("_Xvn8QA2fEeSNWNtJlXOAhg")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; } 
    
    /// <summary>
    /// Second name of a person.
    /// </summary>
    [IsoId("_3FBcYA2gEeSNWNtJlXOAhg")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; } 
    
    /// <summary>
    /// Initial prefix for name.
    /// </summary>
    [IsoId("_BIK8UA2hEeSNWNtJlXOAhg")]
    [DisplayName("Initials")]
    [IsoXmlTag("Initls")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public IsoMax6Text? Initials { get; init; } 
    
    /// <summary>
    /// Suffix for name.
    /// </summary>
    [IsoId("_ELgKcA2hEeSNWNtJlXOAhg")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NameSuffix { get; init; } 
    
    /// <summary>
    /// Full legal name.
    /// </summary>
    [IsoId("_9YWboA2gEeSNWNtJlXOAhg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Date that the name was assigned.
    /// </summary>
    [IsoId("_HHZ64A2hEeSNWNtJlXOAhg")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// Date that name changed.
    /// </summary>
    [IsoId("_J-PlIA2hEeSNWNtJlXOAhg")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    
    #nullable disable
    
}
