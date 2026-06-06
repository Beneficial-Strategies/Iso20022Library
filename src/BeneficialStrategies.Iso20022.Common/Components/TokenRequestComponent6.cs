// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a token request or response.
/// </summary>
[IsoId("_EkyT0bZ2EfCUZfsQO4rYeA")]
[DisplayName("Token Request Component6")]
public record TokenRequestComponent6
{
    /// <summary>
    /// Identification of an element in a sequence.
    /// </summary>
    [IsoId("_El2q1bZ2EfCUZfsQO4rYeA")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_El2q27Z2EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }
}
