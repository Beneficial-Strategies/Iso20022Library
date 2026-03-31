// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to define the balance details.
/// </summary>
[IsoId("_oQJZgYZ5Eee8r9VKRbnJSg")]
[DisplayName("Cash Balance")]
public record CashBalance8
{
    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_oZe7k4Z5Eee8r9VKRbnJSg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BalanceType13 Type { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the credit line.
    /// </summary>
    [IsoId("_oZe7lYZ5Eee8r9VKRbnJSg")]
    [DisplayName("Credit Line")]
    [IsoXmlTag("CdtLine")]
    public ValueList<CreditLine3> CreditLine { get; init; } = [];

    /// <summary>
    /// Amount of money of the cash balance.
    /// </summary>
    [IsoId("_oZe7l4Z5Eee8r9VKRbnJSg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. |Usage: A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_oZe7mYZ5Eee8r9VKRbnJSg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates the date (and time) of the balance.
    /// </summary>
    [IsoId("_oZe7m4Z5Eee8r9VKRbnJSg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required DateAndDateTime2Choice_ Date { get; init; }

    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_oZe7nYZ5Eee8r9VKRbnJSg")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public ValueList<CashAvailability1> Availability { get; init; } = [];
}
