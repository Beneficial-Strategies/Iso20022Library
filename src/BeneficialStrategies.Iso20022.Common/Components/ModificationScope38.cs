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
[IsoId("_2eQ2UYmAEea2EL0wKRDnMQ")]
[DisplayName("Modification Scope")]
public partial record ModificationScope38
{
    #nullable enable
    
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    [IsoId("_3DAiIYmAEea2EL0wKRDnMQ")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_3DAiI4mAEea2EL0wKRDnMQ")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public required Intermediary36 Intermediary { get; init; } 
    
    
    #nullable disable
    
}
