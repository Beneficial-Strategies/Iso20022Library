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
[IsoId("_bJAZ0RUQEeOIaq8KyCdIDQ")]
[DisplayName("Modification Scope")]
public partial record ModificationScope20
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_bviOURUQEeOIaq8KyCdIDQ")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Information related to intermediaries.
    /// </summary>
    [IsoId("_bviOUxUQEeOIaq8KyCdIDQ")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public required Intermediary24 Intermediary { get; init; } 
    
    
    #nullable disable
    
}
