// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_FCIRoaDpEeahP9OZs6K4wg")]
[DisplayName("Modification Scope")]
public partial record ModificationScope39
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_Fo9oIaDpEeahP9OZs6K4wg")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Nationality and legal status (minor or major).
    /// </summary>
    [IsoId("_Fo9oI6DpEeahP9OZs6K4wg")]
    [DisplayName("Citizenship")]
    [IsoXmlTag("Ctznsh")]
    public required CitizenshipInformation2 Citizenship { get; init; } 
    
    
    #nullable disable
    
}
