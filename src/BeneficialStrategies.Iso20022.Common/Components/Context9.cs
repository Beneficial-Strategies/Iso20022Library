// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
[IsoId("_7_YWUs5eEeiEmaZryQQ14Q")]
[DisplayName("Context")]
public record Context9
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_7_YWU85eEeiEmaZryQQ14Q")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public TransactionContext3? TransactionContext { get; init; }
}
