// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on transactions.
/// </summary>
[IsoId("_M4MEpZlPEee-Zps0fZQaFQ")]
[DisplayName("Transactions")]
public record Transactions7
{
    /// <summary>
    /// Common detailed payment instruction information.
    /// </summary>
    [IsoId("_NAXwSZlPEee-Zps0fZQaFQ")]
    [DisplayName("Payment Common Information")]
    [IsoXmlTag("PmtCmonInf")]
    public PaymentCommon3? PaymentCommonInformation { get; init; }

    /// <summary>
    /// Indicates the total number and sum of the transactions.
    /// </summary>
    [IsoId("_NAXwS5lPEee-Zps0fZQaFQ")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; }

    /// <summary>
    /// Reports either on the transaction information or on a business error.
    /// </summary>
    [IsoId("_NAXwTZlPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public ValueList<TransactionReport4> TransactionReport { get; init; } = [];
    // ID for the above is _NAXwTZlPEee-Zps0fZQaFQ
}
