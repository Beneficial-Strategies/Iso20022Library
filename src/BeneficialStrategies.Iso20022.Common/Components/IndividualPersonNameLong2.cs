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
[IsoId("_xEB5Ic4IEeiRUq1z_PF1Sw")]
[DisplayName("Individual Person Name Long")]
public partial record IndividualPersonNameLong2
{
    #nullable enable
    
    /// <summary>
    /// Prefix, as a title before a person&apos;s name.
    /// </summary>
    [IsoId("_xTGP4c4IEeiRUq1z_PF1Sw")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Code? NamePrefix { get; init; } 
    
    /// <summary>
    /// Surname is a name added to a given name and is part of a personal name. In many cases, a surname is a family name.
    /// </summary>
    [IsoId("_xTGP484IEeiRUq1z_PF1Sw")]
    [DisplayName("Surname")]
    [IsoXmlTag("Srnm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Surname { get; init; } 
    
    /// <summary>
    /// Name given at birth.
    /// </summary>
    [IsoId("_xTGP5c4IEeiRUq1z_PF1Sw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; } 
    
    /// <summary>
    /// Second name of a person.
    /// </summary>
    [IsoId("_xTGP584IEeiRUq1z_PF1Sw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; } 
    
    /// <summary>
    /// Initial prefix for name.
    /// </summary>
    [IsoId("_xTGP6c4IEeiRUq1z_PF1Sw")]
    [DisplayName("Initials")]
    [IsoXmlTag("Initls")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public IsoMax6Text? Initials { get; init; } 
    
    /// <summary>
    /// Suffix for name.
    /// </summary>
    [IsoId("_xTGP684IEeiRUq1z_PF1Sw")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NameSuffix { get; init; } 
    
    /// <summary>
    /// Full legal name.
    /// </summary>
    [IsoId("_xTGP7c4IEeiRUq1z_PF1Sw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Date that the name was assigned.
    /// </summary>
    [IsoId("_xTGP784IEeiRUq1z_PF1Sw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// Date that name changed.
    /// </summary>
    [IsoId("_xTGP8c4IEeiRUq1z_PF1Sw")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    
    #nullable disable
    
}
