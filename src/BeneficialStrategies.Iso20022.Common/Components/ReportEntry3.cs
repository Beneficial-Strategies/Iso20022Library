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
[IsoId("_ttR3wlkyEeGeoaLUQk__nA_-193898463")]
[DisplayName("Report Entry")]
public record ReportEntry3
{
    /// <summary>
    /// Unique reference for the entry.
    /// </summary>
    [IsoId("_ttR3w1kyEeGeoaLUQk__nA_-1240606075")]
    [DisplayName("Entry Reference")]
    [IsoXmlTag("NtryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EntryReference { get; init; }

    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_ttR3xFkyEeGeoaLUQk__nA_-1073586180")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the entry is a credit or a debit entry.
    /// </summary>
    [IsoId("_ttbBsFkyEeGeoaLUQk__nA_-1502732198")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not the entry is the result of a reversal.|Usage: This element should only be present if the entry is the result of a reversal.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    [IsoId("_ttbBsVkyEeGeoaLUQk__nA_328190971")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; }

    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_ttbBslkyEeGeoaLUQk__nA_-100470916")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus2Code Status { get; init; }

    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.||Usage: Booking date is the expected booking date, unless the status is booked, in which case it is the actual booking date.
    /// </summary>
    [IsoId("_ttbBs1kyEeGeoaLUQk__nA_1257340040")]
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTimeChoice_? BookingDate { get; init; }

    /// <summary>
    /// Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner in case of a debit entry.|Usage: If entry status is pending and value date is present, then the value date refers to an expected/requested value date.|For entries subject to availability/float and for which availability information is provided, the value date must not be used. In this case the availability component identifies the number of availability days.
    /// </summary>
    [IsoId("_ttbBtFkyEeGeoaLUQk__nA_-586528949")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTimeChoice_? ValueDate { get; init; }

    /// <summary>
    /// Unique reference as assigned by the account servicing institution to unambiguously identify the entry.
    /// </summary>
    [IsoId("_ttkysFkyEeGeoaLUQk__nA_-1015674967")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_ttkysVkyEeGeoaLUQk__nA_-1318731482")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public ValueList<CashBalanceAvailability2> Availability { get; init; } = [];

    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_ttkyslkyEeGeoaLUQk__nA_-1703441965")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    [IsoId("_ttkys1kyEeGeoaLUQk__nA_-917379365")]
    [DisplayName("Commission Waiver Indicator")]
    [IsoXmlTag("ComssnWvrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; }

    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message, as in the case of aggregate bookings.
    /// </summary>
    [IsoId("_ttkytFkyEeGeoaLUQk__nA_1675400963")]
    [DisplayName("Additional Information Indicator")]
    [IsoXmlTag("AddtlInfInd")]
    public MessageIdentification2? AdditionalInformationIndicator { get; init; }

    /// <summary>
    /// Provides information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. If required, the individual original amounts can be included in the same component on transaction details level.
    /// </summary>
    [IsoId("_ttt8oFkyEeGeoaLUQk__nA_568702888")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange3? AmountDetails { get; init; }

    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: This component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_ttt8oVkyEeGeoaLUQk__nA_-1531996610")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ValueList<Charges3> Charges { get; init; } = [];

    /// <summary>
    /// Channel used to technically input the instruction related to the entry.
    /// </summary>
    [IsoId("_ttt8olkyEeGeoaLUQk__nA_-771231457")]
    [DisplayName("Technical Input Channel")]
    [IsoXmlTag("TechInptChanl")]
    public TechnicalInputChannel1Choice_? TechnicalInputChannel { get; init; }

    /// <summary>
    /// Provides details of the interest amount included in the entry amount.||Usage: This component is used on entry level in the case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_ttt8o1kyEeGeoaLUQk__nA_646357846")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<TransactionInterest3> Interest { get; init; } = [];

    /// <summary>
    /// Provides details of the card transaction included in the entry amount, when globalised by the account servicer.
    /// </summary>
    [IsoId("_ttt8pFkyEeGeoaLUQk__nA_-1690571950")]
    [DisplayName("Card Transaction")]
    [IsoXmlTag("CardTx")]
    public CardEntry1? CardTransaction { get; init; }

    /// <summary>
    /// Provides details on the entry.
    /// </summary>
    [IsoId("_tt3toFkyEeGeoaLUQk__nA_2030768153")]
    [DisplayName("Entry Details")]
    [IsoXmlTag("NtryDtls")]
    public ValueList<EntryDetails2> EntryDetails { get; init; } = [];

    /// <summary>
    /// Further details of the entry.
    /// </summary>
    [IsoId("_tt3toVkyEeGeoaLUQk__nA_1324561532")]
    [DisplayName("Additional Entry Information")]
    [IsoXmlTag("AddtlNtryInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalEntryInformation { get; init; }
}
