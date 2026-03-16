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
[IsoId("_-v6LoXJBEe299ZbWCkdR_w")]
[DisplayName("Token Request Component")]
public record TokenRequestComponent3
{
    /// <summary>
    /// Identification of an element in a sequence.
    /// </summary>
    [IsoId("_-2bqYXJBEe299ZbWCkdR_w")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_-2bqY3JBEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }
}
