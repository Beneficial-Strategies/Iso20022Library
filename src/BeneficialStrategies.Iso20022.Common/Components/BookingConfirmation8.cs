// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the booking details for the underlying transaction or entry.
/// </summary>
[IsoId("0e985a49-dfb5-4828-875e-f0232855688a")]
[DisplayName("Booking Confirmation8")]
public record BookingConfirmation8
{
    /// <summary>
    /// Amount of money in the transaction or entry that has debited or credited an account.
    /// </summary>
    [IsoId("1d23ac2d-276f-47fd-94a5-aeb634838676")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the booking is a credit or a debit.
    /// </summary>
    [IsoId("400446cd-8cd1-44e0-a2a1-31af63765ce6")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Provides information on the exchange rate used on the transaction or entry.
    /// </summary>
    [IsoId("5507004d-f02e-484d-9ae0-2c5dd708c5bf")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Account that the transaction or entry has debited or credited.
    /// </summary>
    [IsoId("847bb732-86d4-4354-9977-4a01e3fd2721")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer's books.
    /// </summary>
    [IsoId("912536fb-072c-46b9-a5eb-0f78f6b73536")]
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTime2Choice_? BookingDate { get; init; }

    /// <summary>
    /// Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner in case of a debit entry.
    /// </summary>
    [IsoId("b4aa43cc-2ce9-4bce-a8a6-36b5fd1bf26d")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public required DateAndDateTime2Choice_ ValueDate { get; init; }

    /// <summary>
    /// Provides identification of the transaction or entry.
    /// </summary>
    [IsoId("3c599185-0bcf-4aae-a289-aad91b340d0f")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required TransactionReferences10 References { get; init; }

    /// <summary>
    /// Provides information on the charges relating to the transaction or entry.
    /// </summary>
    [IsoId("2d30d99c-6644-40a0-9b96-8be1a9800176")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges6? Charges { get; init; }

    /// <summary>
    /// Specifies the reason for the confirmation response.
    /// </summary>
    [IsoId("d631e63f-de44-464c-9639-341a4fae7b89")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public IsoMax140Text? Reason { get; init; }
}
