// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reasons of rejecting transactions.
/// </summary>
[IsoId("_hV-hKcK4EeuFNp8LZAnorg")]
[DisplayName("Rejection Reason")]
public record RejectionReason53
{
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_hXhZQcK4EeuFNp8LZAnorg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification3Choice_ TransactionIdentification { get; init; }

    /// <summary>
    /// Information on status of submitted transactions.
    /// </summary>
    [IsoId("_hXhZQ8K4EeuFNp8LZAnorg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ReportingMessageStatus1Code Status { get; init; }

    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [IsoId("_hXhZRcK4EeuFNp8LZAnorg")]
    [DisplayName("Detailed Validation Rule")]
    [IsoXmlTag("DtldVldtnRule")]
    public ValueList<GenericValidationRuleIdentification1> DetailedValidationRule { get; init; } =
        [];
}
