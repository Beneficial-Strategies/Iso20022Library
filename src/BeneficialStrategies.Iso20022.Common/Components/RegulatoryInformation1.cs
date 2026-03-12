// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Regulatory information.
/// </summary>
[IsoId("_uvgygxQLEeKCyZtSz_i3FA")]
[DisplayName("Regulatory Information")]
public partial record RegulatoryInformation1
{
    #nullable enable
    
    /// <summary>
    /// Sector of economic activity, for example, SAE in the Italian market.
    /// </summary>
    [IsoId("_CdjqcBQMEeKCyZtSz_i3FA")]
    [DisplayName("Sector")]
    [IsoXmlTag("Sctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Sector { get; init; } 
    
    /// <summary>
    /// Branch of economic activity, for example, RAE in the Italian market.
    /// </summary>
    [IsoId("_FLAvNRQMEeKCyZtSz_i3FA")]
    [DisplayName("Branch")]
    [IsoXmlTag("Brnch")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Branch { get; init; } 
    
    /// <summary>
    /// Group of economic activity, for example, a code issued by a regulator.
    /// </summary>
    [IsoId("_GK8iNxQMEeKCyZtSz_i3FA")]
    [DisplayName("Group")]
    [IsoXmlTag("Grp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Group { get; init; } 
    
    /// <summary>
    /// Other regulatory information.
    /// </summary>
    [IsoId("_HCE-iRQMEeKCyZtSz_i3FA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Other { get; init; } 
    
    
    #nullable disable
    
}
