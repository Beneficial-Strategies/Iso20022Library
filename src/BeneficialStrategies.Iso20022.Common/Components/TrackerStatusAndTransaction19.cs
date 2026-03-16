// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tracker Status And Transaction19.
/// </summary>
[IsoId("_P73lO0N8Ee-QZYT2pcGFZw")]
[DisplayName("Tracker Status And Transaction19")]
public record TrackerStatusAndTransaction19
{
    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<TrackerPaymentTransaction14> Transaction { get; init; } = [];

    /// <summary>
    /// Transaction Status.
    /// </summary>
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TrackerStatus1 TransactionStatus { get; init; }
}
