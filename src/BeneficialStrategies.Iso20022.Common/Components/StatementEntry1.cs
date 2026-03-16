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
[IsoId("_T6000Np-Ed-ak6NoX_4Aeg_-1317508151")]
[DisplayName("Statement Entry")]
public record StatementEntry1
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_T6000dp-Ed-ak6NoX_4Aeg_-1317508132")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Specifies if an entry is a credit or a debit.
    /// </summary>
    [IsoId("_T6000tp-Ed-ak6NoX_4Aeg_-1317508073")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the entry is the result of a reversal operation.||Usage: this element should only be present if the entry is the result of a reversal operation.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    [IsoId("_T60009p-Ed-ak6NoX_4Aeg_-1317507996")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; }

    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_T6001Np-Ed-ak6NoX_4Aeg_-1317507936")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus3Code Status { get; init; }

    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_T6001dp-Ed-ak6NoX_4Aeg_-1317506589")]
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTimeChoice_? BookingDate { get; init; }

    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).||Usage: For entries which are subject to availability/float (and for which availability information is present), value date must not be used, as the availability component identifies the number of availability days.
    /// </summary>
    [IsoId("_T69-wNp-Ed-ak6NoX_4Aeg_-1317506667")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTimeChoice_? ValueDate { get; init; }

    /// <summary>
    /// Account servicing institution&apos;s reference for the underlying transaction.
    /// </summary>
    [IsoId("_T69-wdp-Ed-ak6NoX_4Aeg_-1317507624")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Set of elements used to indicate when the booked funds will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_T69-wtp-Ed-ak6NoX_4Aeg_-1317506961")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability1? Availability { get; init; }

    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_T69-w9p-Ed-ak6NoX_4Aeg_-1317507021")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    [IsoId("_T69-xNp-Ed-ak6NoX_4Aeg_-1317507893")]
    [DisplayName("Commission Waiver Indicator")]
    [IsoXmlTag("ComssnWvrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; }

    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message, eg in case of aggregate bookings.
    /// </summary>
    [IsoId("_T69-xdp-Ed-ak6NoX_4Aeg_-1317507081")]
    [DisplayName("Additional Information Indicator")]
    [IsoXmlTag("AddtlInfInd")]
    public MessageIdentification2? AdditionalInformationIndicator { get; init; }

    /// <summary>
    /// Set of elements providing details on batched transactions.||Usage: this element can be repeated in case more than one batch is included in the entry, eg, in lockbox scenarios, to specify the ID and number of transactions included in each of the batches.
    /// </summary>
    [IsoId("_T69-xtp-Ed-ak6NoX_4Aeg_-1316586540")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation1? Batch { get; init; }

    /// <summary>
    /// Set of elements providing information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. (If required, the original amounts for each individual transaction can be included in the same component on transaction details level.).
    /// </summary>
    [IsoId("_T69-x9p-Ed-ak6NoX_4Aeg_-1317507519")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange2? AmountDetails { get; init; }

    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: this component is used in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_T69-yNp-Ed-ak6NoX_4Aeg_-1317507194")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ChargesInformation3? Charges { get; init; }

    /// <summary>
    /// Set of elements providing details on the interest amount included in the entry amount.||Usage: it is used in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_T69-ydp-Ed-ak6NoX_4Aeg_-1317507141")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest1? Interest { get; init; }

    /// <summary>
    /// Set of elements providing information on the underlying transaction (s).
    /// </summary>
    [IsoId("_T7HvwNp-Ed-ak6NoX_4Aeg_-1317507580")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public EntryTransaction1? TransactionDetails { get; init; }

    /// <summary>
    /// Further details on the entry details.
    /// </summary>
    [IsoId("_T7Hvwdp-Ed-ak6NoX_4Aeg_-1317508031")]
    [DisplayName("Additional Entry Information")]
    [IsoXmlTag("AddtlNtryInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalEntryInformation { get; init; }
}
