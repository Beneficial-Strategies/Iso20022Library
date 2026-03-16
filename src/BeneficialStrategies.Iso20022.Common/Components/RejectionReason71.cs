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
[IsoId("_yAw2W1yGEe24CqbZJK5XxA")]
[DisplayName("Rejection Reason")]
public record RejectionReason71
{
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_yBsqcVyGEe24CqbZJK5XxA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; }

    /// <summary>
    /// Information on status of submitted transactions.
    /// </summary>
    [IsoId("_yBsqc1yGEe24CqbZJK5XxA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ReportingMessageStatus2Code Status { get; init; }

    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [IsoId("_yBsqdVyGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Validation Rule")]
    [IsoXmlTag("DtldVldtnRule")]
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; init; }
}
