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
[IsoId("_SYxMM9p-Ed-ak6NoX_4Aeg_142613119")]
[DisplayName("Cash Balance")]
public record CashBalance3
{
    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_SYxMNNp-Ed-ak6NoX_4Aeg_142613265")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BalanceType12 Type { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the credit line.
    /// </summary>
    [IsoId("_SYxMNdp-Ed-ak6NoX_4Aeg_142613574")]
    [DisplayName("Credit Line")]
    [IsoXmlTag("CdtLine")]
    public CreditLine2? CreditLine { get; init; }

    /// <summary>
    /// Amount of money of the cash balance.
    /// </summary>
    [IsoId("_SYxMNtp-Ed-ak6NoX_4Aeg_142613121")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. |Usage: A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_SYxMN9p-Ed-ak6NoX_4Aeg_142613172")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates the date (and time) of the balance.
    /// </summary>
    [IsoId("_SYxMONp-Ed-ak6NoX_4Aeg_142613203")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required DateAndDateTimeChoice_ Date { get; init; }

    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_SY69MNp-Ed-ak6NoX_4Aeg_142613605")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability2? Availability { get; init; }
}
