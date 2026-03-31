// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Entry15.
/// </summary>
[IsoId("_D39qcT3dEe-thIfLZ94a1w")]
[DisplayName("Report Entry15")]
public record ReportEntry15
{
    /// <summary>
    /// Account Servicer Reference.
    /// </summary>
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Additional Entry Information.
    /// </summary>
    [DisplayName("Additional Entry Information")]
    [IsoXmlTag("AddtlNtryInf")]
    public IsoMax500Text? AdditionalEntryInformation { get; init; }

    /// <summary>
    /// Additional Information Indicator.
    /// </summary>
    [DisplayName("Additional Information Indicator")]
    [IsoXmlTag("AddtlInfInd")]
    public MessageIdentification2? AdditionalInformationIndicator { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Amount Details.
    /// </summary>
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange4? AmountDetails { get; init; }

    /// <summary>
    /// Availability.
    /// </summary>
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public ValueList<CashAvailability1> Availability { get; init; } = [];

    /// <summary>
    /// Bank Transaction Code.
    /// </summary>
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; }

    /// <summary>
    /// Booking Date.
    /// </summary>
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTime2Choice_? BookingDate { get; init; }

    /// <summary>
    /// Card Transaction.
    /// </summary>
    [DisplayName("Card Transaction")]
    [IsoXmlTag("CardTx")]
    public CardEntry5? CardTransaction { get; init; }

    /// <summary>
    /// Charges.
    /// </summary>
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges15? Charges { get; init; }

    /// <summary>
    /// Commission Waiver Indicator.
    /// </summary>
    [DisplayName("Commission Waiver Indicator")]
    [IsoXmlTag("ComssnWvrInd")]
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Entry Details.
    /// </summary>
    [DisplayName("Entry Details")]
    [IsoXmlTag("NtryDtls")]
    public ValueList<EntryDetails14> EntryDetails { get; init; } = [];

    /// <summary>
    /// Entry Reference.
    /// </summary>
    [DisplayName("Entry Reference")]
    [IsoXmlTag("NtryRef")]
    public IsoMax35Text? EntryReference { get; init; }

    /// <summary>
    /// Interest.
    /// </summary>
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest4? Interest { get; init; }

    /// <summary>
    /// Reversal Indicator.
    /// </summary>
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; }

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus1Choice_ Status { get; init; }

    /// <summary>
    /// Technical Input Channel.
    /// </summary>
    [DisplayName("Technical Input Channel")]
    [IsoXmlTag("TechInptChanl")]
    public TechnicalInputChannel1Choice_? TechnicalInputChannel { get; init; }

    /// <summary>
    /// Value Date.
    /// </summary>
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }
}
