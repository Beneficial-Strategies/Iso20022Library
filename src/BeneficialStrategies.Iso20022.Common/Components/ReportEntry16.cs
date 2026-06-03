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
[IsoId("d5052831-8e4d-435d-8212-4dd0e684ee02")]
[DisplayName("Report Entry16")]
public record ReportEntry16
{
    /// <summary>
    /// Unique reference for the entry.
    /// </summary>
    [IsoId("86315bce-cdfe-48d7-b8ab-5373a3ecd36b")]
    [DisplayName("Entry Reference")]
    [IsoXmlTag("NtryRef")]
    public IsoMax35Text? EntryReference { get; init; }

    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("d81c8fd0-1e29-4ca7-9cd5-3ed938e43727")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the entry is a credit or a debit entry.
    /// </summary>
    [IsoId("f8d713c2-552a-4460-a1e8-cff8bf5ea4a6")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not the entry is the result of a reversal.
    /// </summary>
    [IsoId("cf72152b-2a95-400a-beda-0a189ba94e8a")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; }

    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("b08c126e-962e-489f-b0ec-a3910081c3ab")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus1Choice Status { get; init; }

    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer's books.
    /// </summary>
    [IsoId("adc7c210-b4f3-4267-a47d-00d2ae4b4aea")]
    [DisplayName("Booking Date")]
    [IsoXmlTag("BookgDt")]
    public DateAndDateTime2Choice? BookingDate { get; init; }

    /// <summary>
    /// Date and time at which assets become available to the account owner.
    /// </summary>
    [IsoId("d6a80124-2ffe-498d-a24c-829fbbbf6627")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice? ValueDate { get; init; }

    /// <summary>
    /// Unique reference as assigned by the account servicing institution to unambiguously identify the entry.
    /// </summary>
    [IsoId("19f0fbf3-b4d3-4f9a-b0b1-a6c9ad123297")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Indicates when the booked amount of money will become available.
    /// </summary>
    [IsoId("ab17ee17-b774-4d8f-9728-509622781699")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public ValueList<CashAvailability1> Availability { get; init; } = [];

    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("39e03e1d-4428-4f8a-b63a-e0e4dceb750d")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    [IsoId("cdb94099-5ce4-42c4-90f8-e41d6ef5c659")]
    [DisplayName("Commission Waiver Indicator")]
    [IsoXmlTag("ComssnWvrInd")]
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; }

    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message.
    /// </summary>
    [IsoId("b38188e3-367f-4d29-bd32-6def32711a68")]
    [DisplayName("Additional Information Indicator")]
    [IsoXmlTag("AddtlInfInd")]
    public MessageIdentification2? AdditionalInformationIndicator { get; init; }

    /// <summary>
    /// Provides information on the original amount.
    /// </summary>
    [IsoId("b3c278c2-2a33-453b-87c2-e7b52e187295")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange4? AmountDetails { get; init; }

    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// </summary>
    [IsoId("f404d990-754a-482c-b059-77cc8858974b")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges15? Charges { get; init; }

    /// <summary>
    /// Channel used to technically input the instruction related to the entry.
    /// </summary>
    [IsoId("7a15c93a-cf43-41ae-a422-ee90f4bdabb8")]
    [DisplayName("Technical Input Channel")]
    [IsoXmlTag("TechInptChanl")]
    public TechnicalInputChannel1Choice? TechnicalInputChannel { get; init; }

    /// <summary>
    /// Provides details of the interest amount included in the entry amount.
    /// </summary>
    [IsoId("ad030efb-a145-470d-bffe-858f88951da7")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest4? Interest { get; init; }

    /// <summary>
    /// Provides details of the card transaction included in the entry amount.
    /// </summary>
    [IsoId("9716d488-15fd-48aa-8c9a-1c311c1d4f19")]
    [DisplayName("Card Transaction")]
    [IsoXmlTag("CardTx")]
    public CardEntry5? CardTransaction { get; init; }

    /// <summary>
    /// Provides details on the entry.
    /// </summary>
    [IsoId("6553e510-60c9-40ff-9815-9b4514fad9db")]
    [DisplayName("Entry Details")]
    [IsoXmlTag("NtryDtls")]
    public ValueList<EntryDetails16> EntryDetails { get; init; } = [];

    /// <summary>
    /// Further details of the entry.
    /// </summary>
    [IsoId("2b7c8800-9304-4f13-86b7-f467034edd60")]
    [DisplayName("Additional Entry Information")]
    [IsoXmlTag("AddtlNtryInf")]
    public IsoMax500Text? AdditionalEntryInformation { get; init; }
}
