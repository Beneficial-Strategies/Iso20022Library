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
[IsoId("_gWBV-9cZEeqRFcf2R4bPBw")]
[DisplayName("Transaction Search Criteria")]
public record TransactionSearchCriteria9
{
    /// <summary>
    /// Defines the criteria which are used to search for the destination of the payment.
    /// </summary>
    [IsoId("_gXk1IdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public ValueList<SystemSearch4> PaymentTo { get; init; } = [];

    /// <summary>
    /// Defines the criteria which are used to search for the origin of the payment.
    /// </summary>
    [IsoId("_gXk1I9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public ValueList<SystemSearch4> PaymentFrom { get; init; } = [];

    /// <summary>
    /// Defines the criteria which are used to search for a payment.
    /// </summary>
    [IsoId("_gXk1JdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Search")]
    [IsoXmlTag("PmtSch")]
    public PaymentSearch8? PaymentSearch { get; init; }

    /// <summary>
    /// Defines the criteria which are used to search for a cash entry.
    /// </summary>
    [IsoId("_gXk1J9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Entry Search")]
    [IsoXmlTag("AcctNtrySch")]
    public CashAccountEntrySearch7? AccountEntrySearch { get; init; }
}
