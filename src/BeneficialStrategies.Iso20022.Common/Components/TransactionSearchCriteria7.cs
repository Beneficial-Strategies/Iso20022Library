// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for a payment transaction.
/// </summary>
[IsoId("_VCTJ7ZlQEee-Zps0fZQaFQ")]
[DisplayName("Transaction Search Criteria")]
public record TransactionSearchCriteria7
{
    /// <summary>
    /// Defines the criteria which are used to search for the destination of the payment.
    /// </summary>
    [IsoId("_VKVrkZlQEee-Zps0fZQaFQ")]
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public SystemSearch3? PaymentTo { get; init; }

    /// <summary>
    /// Defines the criteria which are used to search for the origin of the payment.
    /// </summary>
    [IsoId("_VKVrk5lQEee-Zps0fZQaFQ")]
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public SystemSearch3? PaymentFrom { get; init; }

    /// <summary>
    /// Defines the criteria which are used to search for a payment.
    /// </summary>
    [IsoId("_VKVrlZlQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Search")]
    [IsoXmlTag("PmtSch")]
    public PaymentSearch7? PaymentSearch { get; init; }

    /// <summary>
    /// Defines the criteria which are used to search for a cash entry.
    /// </summary>
    [IsoId("_VKVrl5lQEee-Zps0fZQaFQ")]
    [DisplayName("Account Entry Search")]
    [IsoXmlTag("AcctNtrySch")]
    public CashAccountEntrySearch5? AccountEntrySearch { get; init; }
}
