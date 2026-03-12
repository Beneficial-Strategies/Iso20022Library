// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies an organisation through client identification, a name and a domicile.
/// </summary>
[IsoId("_cM4lUMgnEeuGrNSsxk3B0A")]
[DisplayName("Organisation Identification")]
public partial record OrganisationIdentification38
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the organisation.
    /// </summary>
    [IsoId("_sAgPEMgnEeuGrNSsxk3B0A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification175 Identification { get; init; } 
    
    /// <summary>
    /// Indicates the name of the organisation.
    /// </summary>
    [IsoId("_yyv-8MgnEeuGrNSsxk3B0A")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? Name { get; init; } 
    
    /// <summary>
    /// Indicates the domicile of the organisation.
    /// </summary>
    [IsoId("_8ndaQMgnEeuGrNSsxk3B0A")]
    [DisplayName("Domicile")]
    [IsoXmlTag("Dmcl")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? Domicile { get; init; } 
    
    
    #nullable disable
    
}
