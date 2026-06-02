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
[IsoId("abf179f1-76c3-41dd-a82f-b59e8abd7141")]
[DisplayName("Entry Transaction16")]
public record EntryTransaction16
{
    /// <summary>
    /// Provides the identification of the underlying transaction.
    /// </summary>
    [IsoId("bf140292-9600-4dff-b898-139f082bc45b")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public TransactionReferences10? References { get; init; }

    /// <summary>
    /// Amount of money in the cash transaction.
    /// </summary>
    [IsoId("802e6798-6eac-4974-89b9-8386e0b4d76a")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Indicates whether the transaction is a credit or a debit transaction.
    /// </summary>
    [IsoId("4ca922dd-31a1-45ed-937c-130ffcc55da8")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Provides detailed information on the original amount.
    /// </summary>
    [IsoId("b96a9ac3-e7bb-4c61-8693-e6c314cfc364")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange4? AmountDetails { get; init; }

    /// <summary>
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest.
    /// </summary>
    [IsoId("fd1cb30c-ea6a-4d73-8b8e-bbcd900cfedf")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public ValueList<CashAvailability1> Availability { get; init; } = [];

    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("8a3fbf28-a89d-4c98-9b9f-53d03e52427c")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; }

    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// </summary>
    [IsoId("3c220e02-f872-4d9d-80f8-48143c937c73")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges15? Charges { get; init; }

    /// <summary>
    /// Provides details of the interest amount included in the entry amount.
    /// </summary>
    [IsoId("e382fb8c-c5ec-4dba-9db6-9eab095199f9")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest4? Interest { get; init; }

    /// <summary>
    /// Set of elements used to identify the parties related to the underlying transaction.
    /// </summary>
    [IsoId("0e9615cc-baaf-41c5-b259-6e9c3401ed64")]
    [DisplayName("Related Parties")]
    [IsoXmlTag("RltdPties")]
    public TransactionParties12? RelatedParties { get; init; }

    /// <summary>
    /// Set of elements used to identify the agents related to the underlying transaction.
    /// </summary>
    [IsoId("77f56115-c54e-42fe-b8d9-44a5c1b4339b")]
    [DisplayName("Related Agents")]
    [IsoXmlTag("RltdAgts")]
    public TransactionAgents6? RelatedAgents { get; init; }

    /// <summary>
    /// User community specific instrument.
    /// </summary>
    [IsoId("83c4d65b-0a36-4a96-8f53-bfd50c5c447d")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice? LocalInstrument { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("c047daaf-92f3-48af-b166-40edc8414893")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("41de215b-fe2b-400c-91be-6a2c6b70e24c")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice? Purpose { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("c535dda3-72d5-40e7-bc42-840f63f8907e")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public ValueList<RemittanceLocation8> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle.
    /// </summary>
    [IsoId("2f4baee6-e1e2-4231-b93d-b8965393b089")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation26? RemittanceInformation { get; init; }

    /// <summary>
    /// Set of elements used to identify the dates related to the underlying transactions.
    /// </summary>
    [IsoId("28e78153-530a-4c62-ac45-75bda2e1b3c3")]
    [DisplayName("Related Dates")]
    [IsoXmlTag("RltdDts")]
    public TransactionDates3? RelatedDates { get; init; }

    /// <summary>
    /// Set of elements used to identify the price information related to the underlying transaction.
    /// </summary>
    [IsoId("da7586b1-51e6-4fcd-9195-4b871566640d")]
    [DisplayName("Related Price")]
    [IsoXmlTag("RltdPric")]
    public TransactionPrice4Choice? RelatedPrice { get; init; }

    /// <summary>
    /// Set of elements used to identify the related quantities, such as securities, in the underlying transaction.
    /// </summary>
    [IsoId("c730fd35-0dcf-4c5d-84c7-ac0e45ba5e1b")]
    [DisplayName("Related Quantities")]
    [IsoXmlTag("RltdQties")]
    public ValueList<TransactionQuantities4Choice> RelatedQuantities { get; init; } = [];

    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("2f7af7a9-415b-4b8f-b4d0-9bd83feb1f84")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("5c70385a-b803-4fc8-89aa-8cde6a8b8998")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxData1? Tax { get; init; }

    /// <summary>
    /// Provides the return information.
    /// </summary>
    [IsoId("4186f9d2-059f-4de8-8e22-66e40736d8a6")]
    [DisplayName("Return Information")]
    [IsoXmlTag("RtrInf")]
    public PaymentReturnReason8? ReturnInformation { get; init; }

    /// <summary>
    /// Set of elements used to identify the underlying corporate action.
    /// </summary>
    [IsoId("3e1fc376-665b-4b27-92de-705a8062998d")]
    [DisplayName("Related Corporate Action")]
    [IsoXmlTag("RltdCorpActn")]
    public CorporateAction82? RelatedCorporateAction { get; init; }

    /// <summary>
    /// Safekeeping or investment account.
    /// </summary>
    [IsoId("ce933867-c0a1-46a3-b2f2-3baa513db268")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Provides information on the underlying allocations that make up the payment.
    /// </summary>
    [IsoId("1ceb61d5-455d-47d5-a461-4db07ab368c0")]
    [DisplayName("Underlying Allocation")]
    [IsoXmlTag("UndrlygAllcn")]
    public ValueList<TransactionAllocation2> UnderlyingAllocation { get; init; } = [];

    /// <summary>
    /// Provides the details of a cash deposit for an amount of money in cash notes and/or coins.
    /// </summary>
    [IsoId("e541023a-4fb5-4332-b0cc-e5059ad5a69e")]
    [DisplayName("Cash Deposit")]
    [IsoXmlTag("CshDpst")]
    public ValueList<CashDeposit1> CashDeposit { get; init; } = [];

    /// <summary>
    /// Provides the data related to the card (number, scheme), terminal (number, identification) and transactional data used to uniquely identify a card transaction.
    /// </summary>
    [IsoId("11f1c090-fb47-43ae-b1ad-b73d79d6409a")]
    [DisplayName("Card Transaction")]
    [IsoXmlTag("CardTx")]
    public CardTransaction18? CardTransaction { get; init; }

    /// <summary>
    /// Copy of the original instruction, in free form text.
    /// </summary>
    [IsoId("f76ab536-550b-4411-8cec-685e31f64917")]
    [DisplayName("Instruction Copy")]
    [IsoXmlTag("InstrCpy")]
    public IsoMax20000Text? InstructionCopy { get; init; }

    /// <summary>
    /// Further details of the transaction.
    /// </summary>
    [IsoId("6699d54e-7274-41d6-8588-a44f605a9512")]
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    public IsoMax500Text? AdditionalTransactionInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("1024e31e-0939-4299-99c6-ddf05e5dd218")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
