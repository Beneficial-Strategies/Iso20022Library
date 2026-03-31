// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the elements of an entry in the report.
/// </summary>
[IsoId("_T7HvyNp-Ed-ak6NoX_4Aeg_2131702383")]
[DisplayName("Report Entry")]
public record ReportEntry1
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_T7Hvydp-Ed-ak6NoX_4Aeg_-1353467779")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Specifies if an entry is a credit or a debit.
    /// </summary>
    [IsoId("_T7Hvytp-Ed-ak6NoX_4Aeg_-1353467509")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the entry is the result of a reversal operation.||Usage: this element should only be present if the entry is the result of a reversal operation.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    [IsoId("_T7Q5sNp-Ed-ak6NoX_4Aeg_-1189077784")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; }

    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_T7Q5sdp-Ed-ak6NoX_4Aeg_65060463")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus2Code Status { get; init; }

    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.||Usage: Booking date is only present if Status is booked.
    /// </summary>
    [IsoId("_T7Q5stp-Ed-ak6NoX_4Aeg_-445646217")]
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTimeChoice_? BookingDate { get; init; }

    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).| |Usage: When entry status is pending, and value date is present, value date refers to an expected/requested value date.|For entries which are subject to availability/float (and for which availability information is present), value date must not be used, as the availability component identifies the number of availability days.
    /// </summary>
    [IsoId("_T7Q5s9p-Ed-ak6NoX_4Aeg_-293264788")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTimeChoice_? ValueDate { get; init; }

    /// <summary>
    /// Account servicing institution&apos;s reference for the entry.
    /// </summary>
    [IsoId("_T7Q5tNp-Ed-ak6NoX_4Aeg_-597899145")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_T7Q5tdp-Ed-ak6NoX_4Aeg_379981934")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public ValueList<CashBalanceAvailability1> Availability { get; init; } = [];

    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in the entry.
    /// </summary>
    [IsoId("_T7Q5ttp-Ed-ak6NoX_4Aeg_579463920")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    [IsoId("_T7Q5t9p-Ed-ak6NoX_4Aeg_927630003")]
    [DisplayName("Commission Waiver Indicator")]
    [IsoXmlTag("ComssnWvrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; }

    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message, eg in case of aggregate bookings.
    /// </summary>
    [IsoId("_T7Q5uNp-Ed-ak6NoX_4Aeg_-389904607")]
    [DisplayName("Additional Information Indicator")]
    [IsoXmlTag("AddtlInfInd")]
    public MessageIdentification2? AdditionalInformationIndicator { get; init; }

    /// <summary>
    /// Set of elements providing details on batched transactions.||Usage: this element can be repeated in case more than one batch is included in the entry, eg, in lockbox scenarios, to specify the ID and number of transactions included in each of the batches.
    /// </summary>
    [IsoId("_T7aqsNp-Ed-ak6NoX_4Aeg_525195553")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public ValueList<BatchInformation1> Batch { get; init; } = [];

    /// <summary>
    /// Set of elements providing information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. (If required, the individual original amounts can be included in the same component on transaction details level).
    /// </summary>
    [IsoId("_T7aqsdp-Ed-ak6NoX_4Aeg_1744402483")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange2? AmountDetails { get; init; }

    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: this component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_T7aqstp-Ed-ak6NoX_4Aeg_1767172786")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ValueList<ChargesInformation3> Charges { get; init; } = [];

    /// <summary>
    /// Set of elements providing details on the interest amount included in the entry amount.||Usage: This component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_T7aqs9p-Ed-ak6NoX_4Aeg_163285492")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<TransactionInterest1> Interest { get; init; } = [];

    /// <summary>
    /// Set of elements providing information on the underlying transaction (s).
    /// </summary>
    [IsoId("_T7aqtNp-Ed-ak6NoX_4Aeg_-2093094349")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<EntryTransaction1> TransactionDetails { get; init; } = [];

    /// <summary>
    /// Further details on the entry details.
    /// </summary>
    [IsoId("_T7aqtdp-Ed-ak6NoX_4Aeg_-1697014690")]
    [DisplayName("Additional Entry Information")]
    [IsoXmlTag("AddtlNtryInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalEntryInformation { get; init; }
}
