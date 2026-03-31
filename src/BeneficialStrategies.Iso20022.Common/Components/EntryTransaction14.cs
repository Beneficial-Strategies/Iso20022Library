// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entry Transaction14.
/// </summary>
[IsoId("_9Nl8hTEsEe6GxLzpkVnWYg")]
[DisplayName("Entry Transaction14")]
public record EntryTransaction14
{
    /// <summary>
    /// Additional Transaction Information.
    /// </summary>
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    public IsoMax500Text? AdditionalTransactionInformation { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

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
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; }

    /// <summary>
    /// Card Transaction.
    /// </summary>
    [DisplayName("Card Transaction")]
    [IsoXmlTag("CardTx")]
    public CardTransaction18? CardTransaction { get; init; }

    /// <summary>
    /// Cash Deposit.
    /// </summary>
    [DisplayName("Cash Deposit")]
    [IsoXmlTag("CshDpst")]
    public ValueList<CashDeposit1> CashDeposit { get; init; } = [];

    /// <summary>
    /// Charges.
    /// </summary>
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges15? Charges { get; init; }

    /// <summary>
    /// Corporate Action.
    /// </summary>
    [DisplayName("Corporate Action")]
    [IsoXmlTag("CorpActn")]
    public CorporateAction9? CorporateAction { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Interest.
    /// </summary>
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest4? Interest { get; init; }

    /// <summary>
    /// Local Instrument.
    /// </summary>
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Purpose.
    /// </summary>
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// References.
    /// </summary>
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public TransactionReferences6? References { get; init; }

    /// <summary>
    /// Related Agents.
    /// </summary>
    [DisplayName("Related Agents")]
    [IsoXmlTag("RltdAgts")]
    public TransactionAgents6? RelatedAgents { get; init; }

    /// <summary>
    /// Related Dates.
    /// </summary>
    [DisplayName("Related Dates")]
    [IsoXmlTag("RltdDts")]
    public TransactionDates3? RelatedDates { get; init; }

    /// <summary>
    /// Related Parties.
    /// </summary>
    [DisplayName("Related Parties")]
    [IsoXmlTag("RltdPties")]
    public TransactionParties12? RelatedParties { get; init; }

    /// <summary>
    /// Related Price.
    /// </summary>
    [DisplayName("Related Price")]
    [IsoXmlTag("RltdPric")]
    public TransactionPrice4Choice_? RelatedPrice { get; init; }

    /// <summary>
    /// Related Quantities.
    /// </summary>
    [DisplayName("Related Quantities")]
    [IsoXmlTag("RltdQties")]
    public ValueList<TransactionQuantities3Choice_> RelatedQuantities { get; init; } = [];

    /// <summary>
    /// Related Remittance Information.
    /// </summary>
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public RemittanceLocation8? RelatedRemittanceInformation { get; init; }

    /// <summary>
    /// Remittance Information.
    /// </summary>
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation22? RemittanceInformation { get; init; }

    /// <summary>
    /// Return Information.
    /// </summary>
    [DisplayName("Return Information")]
    [IsoXmlTag("RtrInf")]
    public PaymentReturnReason8? ReturnInformation { get; init; }

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxData1? Tax { get; init; }
}
