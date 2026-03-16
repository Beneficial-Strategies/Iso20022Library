// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of a reversal.
/// </summary>
[IsoId("_mdPa4Hu2EeS2Z_kGi7H1VQ")]
[DisplayName("Acquirer Reversal Response")]
public record AcquirerReversalResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_9USEEHu2EeS2Z_kGi7H1VQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment4 Environment { get; init; }

    /// <summary>
    /// Reversal card transaction.
    /// </summary>
    [IsoId("_7GmPEHu3EeS2Z_kGi7H1VQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction8 Transaction { get; init; }
}
