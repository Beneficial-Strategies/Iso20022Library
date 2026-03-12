// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the action type.
/// </summary>
[IsoId("_SUMURf_kEemm3skPVSMJQg")]
[DisplayName("Contract Modification")]
public partial record ContractModification3
{
    #nullable enable
    
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_SYEuof_kEemm3skPVSMJQg")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TransactionOperationType6Code ActionType { get; init; } 
    
    /// <summary>
    /// Indication whether the report is done at trade or position level.
    /// </summary>
    [IsoId("_SYEuo__kEemm3skPVSMJQg")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public ModificationLevel1Code? Level { get; init; } 
    
    
    #nullable disable
    
}
