// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the network management.
/// </summary>
[IsoId("_QugKoHvDEeSKFIcWw3l4Yw")]
[DisplayName("Acquirer Network Management Initiation")]
public record AcquirerNetworkManagementInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_cna5YHvDEeSKFIcWw3l4Yw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment6 Environment { get; init; }

    /// <summary>
    /// Network management transaction.
    /// </summary>
    [IsoId("_4XsiYHvDEeSKFIcWw3l4Yw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction11 Transaction { get; init; }
}
