// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the action type.
/// </summary>
[IsoId("_q0Gzca4FEemB_csI4yyKLA")]
[DisplayName("Contract Modification")]
public record ContractModification2
{
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_q4u0wa4FEemB_csI4yyKLA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TransactionOperationType5Code ActionType { get; init; }

    /// <summary>
    /// Indication whether the report is done at trade or position level.
    /// </summary>
    [IsoId("_q4u0w64FEemB_csI4yyKLA")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public ModificationLevel1Code? Level { get; init; }
}
