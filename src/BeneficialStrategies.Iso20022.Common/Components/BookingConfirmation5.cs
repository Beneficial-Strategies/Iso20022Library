// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Booking Confirmation5.
/// </summary>
[IsoId("_okBbfzrQEe-thIfLZ94a1w")]
[DisplayName("Booking Confirmation5")]
public partial record BookingConfirmation5
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public BaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Booking Date.
    /// </summary>
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTime2Choice_? BookingDate { get; init; }

    /// <summary>
    /// Value Date.
    /// </summary>
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public required DateAndDateTime2Choice_ ValueDate { get; init; }

    /// <summary>
    /// References.
    /// </summary>
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required TransactionReferences6 References { get; init; }

    /// <summary>
    /// Charges.
    /// </summary>
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges6? Charges { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public Max140Text? Reason { get; init; }
}
