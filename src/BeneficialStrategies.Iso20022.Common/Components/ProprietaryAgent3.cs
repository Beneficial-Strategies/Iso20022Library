// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a proprietary party.
/// </summary>
[IsoId("_tqcmM1kyEeGeoaLUQk__nA_-1318903325")]
[DisplayName("Proprietary Agent")]
public partial record ProprietaryAgent3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proprietary agent.
    /// </summary>
    [IsoId("_tqlwIFkyEeGeoaLUQk__nA_1978991618")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Organisation established primarily to provide financial services.
    /// </summary>
    [IsoId("_tqlwIVkyEeGeoaLUQk__nA_499154259")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification5 Agent { get; init; } 
    
    
    #nullable disable
    
}
