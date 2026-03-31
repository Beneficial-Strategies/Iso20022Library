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
[IsoId("_kHE90TIBEe2fXedS_ucFOA")]
[DisplayName("Contract Modification")]
public record ContractModification8
{
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_kH-VsTIBEe2fXedS_ucFOA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TransactionOperationType11Code ActionType { get; init; }
}
