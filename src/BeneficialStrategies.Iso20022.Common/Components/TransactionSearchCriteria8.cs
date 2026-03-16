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
[IsoId("_O2c0zW49EeiU9cctagi5ow")]
[DisplayName("Transaction Search Criteria")]
public record TransactionSearchCriteria8
{
    /// <summary>
    /// Defines the criteria which are used to search for the destination of the payment.
    /// </summary>
    [IsoId("_PEwWgW49EeiU9cctagi5ow")]
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public ValueList<SystemSearch4> PaymentTo { get; init; } = [];

    /// <summary>
    /// Defines the criteria which are used to search for the origin of the payment.
    /// </summary>
    [IsoId("_PEwWg249EeiU9cctagi5ow")]
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public ValueList<SystemSearch4> PaymentFrom { get; init; } = [];

    /// <summary>
    /// Defines the criteria which are used to search for a payment.
    /// </summary>
    [IsoId("_PEwWhW49EeiU9cctagi5ow")]
    [DisplayName("Payment Search")]
    [IsoXmlTag("PmtSch")]
    public PaymentSearch8? PaymentSearch { get; init; }

    /// <summary>
    /// Defines the criteria which are used to search for a cash entry.
    /// </summary>
    [IsoId("_PEwWh249EeiU9cctagi5ow")]
    [DisplayName("Account Entry Search")]
    [IsoXmlTag("AcctNtrySch")]
    public CashAccountEntrySearch6? AccountEntrySearch { get; init; }
}
