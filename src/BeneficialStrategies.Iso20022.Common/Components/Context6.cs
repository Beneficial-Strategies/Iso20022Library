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
[IsoId("_O6b2QeE6EeeV6-yubHrZaQ")]
[DisplayName("Context")]
public record Context6
{
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_PGLzQeE6EeeV6-yubHrZaQ")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public TransactionContext6? TransactionContext { get; init; }
}
