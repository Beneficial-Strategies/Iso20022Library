// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction.
/// </summary>
[IsoId("_7qUnYYarEeeUws0ZryHQ2w")]
[DisplayName("Entry Transaction")]
public record EntryTransaction9
{
    /// <summary>
    /// Provides the identification of the underlying transaction.
    /// </summary>
    [IsoId("_7yNYE4arEeeUws0ZryHQ2w")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public TransactionReferences3? References { get; init; }

    /// <summary>
    /// Amount of money in the cash transaction.
    /// </summary>
    [IsoId("_7yNYFYarEeeUws0ZryHQ2w")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Indicates whether the transaction is a credit or a debit transaction.
    /// </summary>
    [IsoId("_7yNYF4arEeeUws0ZryHQ2w")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Provides detailed information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    [IsoId("_7yNYGYarEeeUws0ZryHQ2w")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange3? AmountDetails { get; init; }

    /// <summary>
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_7yNYG4arEeeUws0ZryHQ2w")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public ValueList<CashAvailability1> Availability { get; init; } = [];

    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_7yNYHYarEeeUws0ZryHQ2w")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; }

    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_7yNYH4arEeeUws0ZryHQ2w")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges4? Charges { get; init; }

    /// <summary>
    /// Provides details of the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used if the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used if individual interest amounts are applied to individual transactions in the case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_7yNYIYarEeeUws0ZryHQ2w")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest4? Interest { get; init; }

    /// <summary>
    /// Set of elements used to identify the parties related to the underlying transaction.
    /// </summary>
    [IsoId("_7yNYI4arEeeUws0ZryHQ2w")]
    [DisplayName("Related Parties")]
    [IsoXmlTag("RltdPties")]
    public TransactionParties4? RelatedParties { get; init; }

    /// <summary>
    /// Set of elements used to identify the agents related to the underlying transaction.
    /// </summary>
    [IsoId("_7yNYJYarEeeUws0ZryHQ2w")]
    [DisplayName("Related Agents")]
    [IsoXmlTag("RltdAgts")]
    public TransactionAgents4? RelatedAgents { get; init; }

    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_I_4FUYtkEee-OJ-wXSj3YQ")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_7yNYJ4arEeeUws0ZryHQ2w")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_7yNYKYarEeeUws0ZryHQ2w")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_7yNYK4arEeeUws0ZryHQ2w")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation15? RemittanceInformation { get; init; }

    /// <summary>
    /// Set of elements used to identify the dates related to the underlying transactions.
    /// </summary>
    [IsoId("_7yNYLYarEeeUws0ZryHQ2w")]
    [DisplayName("Related Dates")]
    [IsoXmlTag("RltdDts")]
    public TransactionDates3? RelatedDates { get; init; }

    /// <summary>
    /// Set of elements used to identify the price information related to the underlying transaction.
    /// </summary>
    [IsoId("_7yNYL4arEeeUws0ZryHQ2w")]
    [DisplayName("Related Price")]
    [IsoXmlTag("RltdPric")]
    public TransactionPrice4Choice_? RelatedPrice { get; init; }

    /// <summary>
    /// Set of elements used to identify the related quantities, such as securities, in the underlying transaction.
    /// </summary>
    [IsoId("_7yNYMYarEeeUws0ZryHQ2w")]
    [DisplayName("Related Quantities")]
    [IsoXmlTag("RltdQties")]
    public ValueList<TransactionQuantities2Choice_> RelatedQuantities { get; init; } = [];

    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_7yNYM4arEeeUws0ZryHQ2w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_7yNYNYarEeeUws0ZryHQ2w")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation6? Tax { get; init; }

    /// <summary>
    /// Provides the return information.
    /// </summary>
    [IsoId("_7yNYN4arEeeUws0ZryHQ2w")]
    [DisplayName("Return Information")]
    [IsoXmlTag("RtrInf")]
    public PaymentReturnReason3? ReturnInformation { get; init; }

    /// <summary>
    /// Set of elements used to identify the underlying corporate action.
    /// </summary>
    [IsoId("_7yNYOYarEeeUws0ZryHQ2w")]
    [DisplayName("Corporate Action")]
    [IsoXmlTag("CorpActn")]
    public CorporateAction9? CorporateAction { get; init; }

    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_7yNYO4arEeeUws0ZryHQ2w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Provides the details of a cash deposit for an amount of money in cash notes and/or coins.
    /// </summary>
    [IsoId("_7yNYPYarEeeUws0ZryHQ2w")]
    [DisplayName("Cash Deposit")]
    [IsoXmlTag("CshDpst")]
    public ValueList<CashDeposit1> CashDeposit { get; init; } = [];

    /// <summary>
    /// Provides the data related to the card (number, scheme), terminal (number, identification) and transactional data used to uniquely identify a card transaction.
    /// </summary>
    [IsoId("_7yNYP4arEeeUws0ZryHQ2w")]
    [DisplayName("Card Transaction")]
    [IsoXmlTag("CardTx")]
    public CardTransaction16? CardTransaction { get; init; }

    /// <summary>
    /// Further details of the transaction.
    /// </summary>
    [IsoId("_7yNYQYarEeeUws0ZryHQ2w")]
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalTransactionInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7yNYQ4arEeeUws0ZryHQ2w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
