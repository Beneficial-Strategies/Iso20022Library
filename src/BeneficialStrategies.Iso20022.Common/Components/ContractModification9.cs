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
[IsoId("_Xn3hMT3gEe2uHKhHp3bXyA")]
[DisplayName("Contract Modification")]
public record ContractModification9
{
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_Xovq8T3gEe2uHKhHp3bXyA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public TransactionOperationType10Code? ActionType { get; init; }

    /// <summary>
    /// Indication whether the report is done at trade or position level.
    /// </summary>
    [IsoId("_Xovq8z3gEe2uHKhHp3bXyA")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public ModificationLevel1Code? Level { get; init; }
}
