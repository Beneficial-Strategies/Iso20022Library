// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the elements of an entry in the report.
/// </summary>
[IsoId("_T73WoNp-Ed-ak6NoX_4Aeg_-125433999")]
[DisplayName("Notification Entry")]
public partial record NotificationEntry1
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_T73Wodp-Ed-ak6NoX_4Aeg_-125433967")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Specifies if an entry is a credit or a debit.
    /// </summary>
    [IsoId("_T73Wotp-Ed-ak6NoX_4Aeg_-125433966")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the entry is the result of a reversal operation.||Usage: this element should only be present if the entry is the result of a reversal operation.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    [IsoId("_T73Wo9p-Ed-ak6NoX_4Aeg_-125433907")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; } 
    
    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_T73WpNp-Ed-ak6NoX_4Aeg_-125433906")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus4Code Status { get; init; } 
    
    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.||Usage: Booking date is only present if Status is booked.
    /// </summary>
    [IsoId("_T73Wpdp-Ed-ak6NoX_4Aeg_-125433444")]
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTimeChoice_? BookingDate { get; init; } 
    
    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).||Usage: When entry status is pending, and value date is present, value date refers to an expected/requested value date.|For entries which are subject to availability/float (and for which availability information is present), value date must not be used, as the availability component identifies the number of availability days.
    /// </summary>
    [IsoId("_T73Wptp-Ed-ak6NoX_4Aeg_-125433474")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    
    /// <summary>
    /// Account servicing institution&apos;s reference for the entry.
    /// </summary>
    [IsoId("_T73Wp9p-Ed-ak6NoX_4Aeg_-125433846")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; } 
    
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_T73WqNp-Ed-ak6NoX_4Aeg_-125433413")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability1? Availability { get; init; } 
    
    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in the entry.
    /// </summary>
    [IsoId("_T73Wqdp-Ed-ak6NoX_4Aeg_-125433505")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    [IsoId("_T8BHoNp-Ed-ak6NoX_4Aeg_-125433876")]
    [DisplayName("Commission Waiver Indicator")]
    [IsoXmlTag("ComssnWvrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message, eg in case of aggregate bookings.
    /// </summary>
    [IsoId("_T8BHodp-Ed-ak6NoX_4Aeg_-125433043")]
    [DisplayName("Additional Information Indicator")]
    [IsoXmlTag("AddtlInfInd")]
    public MessageIdentification2? AdditionalInformationIndicator { get; init; } 
    
    /// <summary>
    /// Set of elements providing details on batched transactions.||Usage: this element can be repeated in case more than one batch is included in the entry, eg, in lockbox scenarios, to specify the ID and number of transactions included in each of the batches.
    /// </summary>
    [IsoId("_T8BHotp-Ed-ak6NoX_4Aeg_-125433012")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation1? Batch { get; init; } 
    
    /// <summary>
    /// Set of elements providing information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. (If required, the individual original amounts can be included in the same component on transaction details level).
    /// </summary>
    [IsoId("_T8BHo9p-Ed-ak6NoX_4Aeg_-125433535")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange2? AmountDetails { get; init; } 
    
    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: this component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_T8BHpNp-Ed-ak6NoX_4Aeg_-125433382")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ChargesInformation3? Charges { get; init; } 
    
    /// <summary>
    /// Set of elements providing details on the interest amount included in the entry amount.||Usage: This component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_T8BHpdp-Ed-ak6NoX_4Aeg_-125433321")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest1? Interest { get; init; } 
    
    /// <summary>
    /// Set of elements providing information on the underlying transaction (s).
    /// </summary>
    [IsoId("_T8BHptp-Ed-ak6NoX_4Aeg_-125433290")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public EntryTransaction1? TransactionDetails { get; init; } 
    
    /// <summary>
    /// Further details on the entry details.
    /// </summary>
    [IsoId("_T8BHp9p-Ed-ak6NoX_4Aeg_-125433938")]
    [DisplayName("Additional Entry Information")]
    [IsoXmlTag("AddtlNtryInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalEntryInformation { get; init; } 
    
    
    #nullable disable
    
}
