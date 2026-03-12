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
[IsoId("_0cGHCwgpEeSUG-8hqXsVMQ")]
[DisplayName("Modification Scope")]
public partial record ModificationScope21
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_011csQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Information about the investment account ownership with respect to new issue allocation for a hedge fund.
    /// </summary>
    [IsoId("_011cswgpEeSUG-8hqXsVMQ")]
    [DisplayName("Issue Allocation")]
    [IsoXmlTag("IsseAllcn")]
    public required NewIssueAllocation2 IssueAllocation { get; init; } 
    
    
    #nullable disable
    
}
