// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the authorisation initiation.
/// </summary>
[IsoId("_JQs4AHrhEeSlsoBd7x4P6A")]
[DisplayName("Acquirer Authorisation Initiation")]
public record AcquirerAuthorisationInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Djs0wHroEeSz_of_1TY14A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment1 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_yjTFcHsAEeSZrs_hiwNOWA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardTransactionContext1 Context { get; init; }

    /// <summary>
    /// Card transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_esYU0HtBEeSTS7uHCe8FPQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction15 Transaction { get; init; }
}
