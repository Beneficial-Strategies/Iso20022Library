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
[IsoId("_HVwgcwxhEeuoAcnnpX2x_w")]
[DisplayName("Contract Modification")]
public record ContractModification4
{
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_HVwgdQxhEeuoAcnnpX2x_w")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public TransactionOperationType7Code? ActionType { get; init; }

    /// <summary>
    /// Indication whether the report is done at trade or position level.
    /// </summary>
    [IsoId("_HVwgdAxhEeuoAcnnpX2x_w")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public ModificationLevel1Code? Level { get; init; }
}
