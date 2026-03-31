// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to financial authorisation.
/// </summary>
[IsoId("_oCk1QHubEeSBS-QFUaKA-g")]
[DisplayName("Acquirer Financial Initiation")]
public record AcquirerFinancialInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_0e5zEHubEeSBS-QFUaKA-g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment1 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_4QgccHubEeSBS-QFUaKA-g")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardTransactionContext1 Context { get; init; }

    /// <summary>
    /// Card transaction for which the financial authorisation has been requested.
    /// </summary>
    [IsoId("_93sucHubEeSBS-QFUaKA-g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction5 Transaction { get; init; }
}
