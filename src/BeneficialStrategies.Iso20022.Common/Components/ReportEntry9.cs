// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on an entry in the report.
/// </summary>
[IsoId("_tyH40a6QEeexrtTFgmVD3Q")]
[DisplayName("Report Entry")]
public record ReportEntry9
{
    /// <summary>
    /// Unique reference for the entry.
    /// </summary>
    [IsoId("_t6wQRa6QEeexrtTFgmVD3Q")]
    [DisplayName("Entry Reference")]
    [IsoXmlTag("NtryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EntryReference { get; init; }

    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_t6wQR66QEeexrtTFgmVD3Q")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the entry is a credit or a debit entry.
    /// </summary>
    [IsoId("_t6wQSa6QEeexrtTFgmVD3Q")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not the entry is the result of a reversal.|Usage: This element should only be present if the entry is the result of a reversal.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    [IsoId("_t6wQS66QEeexrtTFgmVD3Q")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; }

    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_t6wQTa6QEeexrtTFgmVD3Q")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus1Choice_ Status { get; init; }

    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.||Usage: Booking date is the expected booking date, unless the status is booked, in which case it is the actual booking date.
    /// </summary>
    [IsoId("_t6wQT66QEeexrtTFgmVD3Q")]
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTime2Choice_? BookingDate { get; init; }

    /// <summary>
    /// Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner in case of a debit entry.|Usage: If entry status is pending and value date is present, then the value date refers to an expected/requested value date.|For entries subject to availability/float and for which availability information is provided, the value date must not be used. In this case the availability component identifies the number of availability days.
    /// </summary>
    [IsoId("_t6wQUa6QEeexrtTFgmVD3Q")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    /// <summary>
    /// Unique reference as assigned by the account servicing institution to unambiguously identify the entry.
    /// </summary>
    [IsoId("_t6wQU66QEeexrtTFgmVD3Q")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_t6wQVa6QEeexrtTFgmVD3Q")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public ValueList<CashAvailability1> Availability { get; init; } = [];

    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_t6wQV66QEeexrtTFgmVD3Q")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    [IsoId("_t6wQWa6QEeexrtTFgmVD3Q")]
    [DisplayName("Commission Waiver Indicator")]
    [IsoXmlTag("ComssnWvrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; }

    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message, as in the case of aggregate bookings.
    /// </summary>
    [IsoId("_t6wQW66QEeexrtTFgmVD3Q")]
    [DisplayName("Additional Information Indicator")]
    [IsoXmlTag("AddtlInfInd")]
    public MessageIdentification2? AdditionalInformationIndicator { get; init; }

    /// <summary>
    /// Provides information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. If required, the individual original amounts can be included in the same component on transaction details level.
    /// </summary>
    [IsoId("_t6wQXa6QEeexrtTFgmVD3Q")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange3? AmountDetails { get; init; }

    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// Usage: This component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_t6wQX66QEeexrtTFgmVD3Q")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges4? Charges { get; init; }

    /// <summary>
    /// Channel used to technically input the instruction related to the entry.
    /// </summary>
    [IsoId("_t6wQYa6QEeexrtTFgmVD3Q")]
    [DisplayName("Technical Input Channel")]
    [IsoXmlTag("TechInptChanl")]
    public TechnicalInputChannel1Choice_? TechnicalInputChannel { get; init; }

    /// <summary>
    /// Provides details of the interest amount included in the entry amount.||Usage: This component is used on entry level in the case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_t6wQY66QEeexrtTFgmVD3Q")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest4? Interest { get; init; }

    /// <summary>
    /// Provides details of the card transaction included in the entry amount, when globalised by the account servicer.
    /// </summary>
    [IsoId("_t6wQZa6QEeexrtTFgmVD3Q")]
    [DisplayName("Card Transaction")]
    [IsoXmlTag("CardTx")]
    public CardEntry3? CardTransaction { get; init; }

    /// <summary>
    /// Provides details on the entry.
    /// </summary>
    [IsoId("_t6wQZ66QEeexrtTFgmVD3Q")]
    [DisplayName("Entry Details")]
    [IsoXmlTag("NtryDtls")]
    public ValueList<EntryDetails8> EntryDetails { get; init; } = [];

    /// <summary>
    /// Further details of the entry.
    /// </summary>
    [IsoId("_t6wQaa6QEeexrtTFgmVD3Q")]
    [DisplayName("Additional Entry Information")]
    [IsoXmlTag("AddtlNtryInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalEntryInformation { get; init; }
}
