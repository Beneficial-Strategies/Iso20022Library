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
[IsoId("_W4SbsA3kEeWc7_0KPiuk6w")]
[DisplayName("Contract Modification")]
public record ContractModification1
{
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_dNZjoA3kEeWc7_0KPiuk6w")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TransactionOperationType3Code ActionType { get; init; }

    /// <summary>
    /// Indication whether the report is done at trade or position level.
    /// </summary>
    [IsoId("_SwRykA3mEeWc7_0KPiuk6w")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public ModificationLevel1Code? Level { get; init; }
}
