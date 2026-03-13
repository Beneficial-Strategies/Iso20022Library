// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction.
/// </summary>
[IsoId("_tuBeolkyEeGeoaLUQk__nA_-1457648646")]
[DisplayName("Entry Transaction")]
public partial record EntryTransaction3
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the underlying transaction.
    /// </summary>
    [IsoId("_tuBeo1kyEeGeoaLUQk__nA_1411584410")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public TransactionReferences3? References { get; init; } 
    
    /// <summary>
    /// Amount of money in the cash transaction.
    /// </summary>
    [IsoId("_tuBepFkyEeGeoaLUQk__nA_-1094870288")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction is a credit or a debit transaction.
    /// </summary>
    [IsoId("_tuKokFkyEeGeoaLUQk__nA_-2091942641")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    [IsoId("_tuKokVkyEeGeoaLUQk__nA_-1465793583")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange3? AmountDetails { get; init; } 
    
    /// <summary>
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_tuKoklkyEeGeoaLUQk__nA_822340411")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability2? Availability { get; init; } 
    
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_tuKok1kyEeGeoaLUQk__nA_607749716")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; } 
    
    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_tuKolFkyEeGeoaLUQk__nA_932867223")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges3? Charges { get; init; } 
    
    /// <summary>
    /// Provides details of the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used if the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used if individual interest amounts are applied to individual transactions in the case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_tuUZkFkyEeGeoaLUQk__nA_-442057789")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest3? Interest { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the parties related to the underlying transaction.
    /// </summary>
    [IsoId("_tuUZkVkyEeGeoaLUQk__nA_12029480")]
    [DisplayName("Related Parties")]
    [IsoXmlTag("RltdPties")]
    public TransactionParties3? RelatedParties { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the agents related to the underlying transaction.
    /// </summary>
    [IsoId("_tuUZklkyEeGeoaLUQk__nA_1943926130")]
    [DisplayName("Related Agents")]
    [IsoXmlTag("RltdAgts")]
    public TransactionAgents3? RelatedAgents { get; init; } 
    
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_tuUZk1kyEeGeoaLUQk__nA_2071811404")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; } 
    
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_tuUZlFkyEeGeoaLUQk__nA_-791805214")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];
    
    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_tueKkFkyEeGeoaLUQk__nA_1314909563")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the dates related to the underlying transactions.
    /// </summary>
    [IsoId("_tueKkVkyEeGeoaLUQk__nA_1089878129")]
    [DisplayName("Related Dates")]
    [IsoXmlTag("RltdDts")]
    public TransactionDates2? RelatedDates { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the price information related to the underlying transaction.
    /// </summary>
    [IsoId("_tueKklkyEeGeoaLUQk__nA_-695047295")]
    [DisplayName("Related Price")]
    [IsoXmlTag("RltdPric")]
    public TransactionPrice3Choice_? RelatedPrice { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the related quantities, such as securities, in the underlying transaction.
    /// </summary>
    [IsoId("_tueKk1kyEeGeoaLUQk__nA_-915365354")]
    [DisplayName("Related Quantities")]
    [IsoXmlTag("RltdQties")]
    public TransactionQuantities2Choice_? RelatedQuantities { get; init; } 
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_tueKlFkyEeGeoaLUQk__nA_-369929788")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_tunUgFkyEeGeoaLUQk__nA_845947468")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; } 
    
    /// <summary>
    /// Provides the return information.
    /// </summary>
    [IsoId("_tunUgVkyEeGeoaLUQk__nA_-1753085027")]
    [DisplayName("Return Information")]
    [IsoXmlTag("RtrInf")]
    public PaymentReturnReason2? ReturnInformation { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the underlying corporate action.
    /// </summary>
    [IsoId("_tunUglkyEeGeoaLUQk__nA_-1298997758")]
    [DisplayName("Corporate Action")]
    [IsoXmlTag("CorpActn")]
    public CorporateAction9? CorporateAction { get; init; } 
    
    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_tunUg1kyEeGeoaLUQk__nA_35853089")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount13? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Provides the details of a cash deposit for an amount of money in cash notes and/or coins.
    /// </summary>
    [IsoId("_tunUhFkyEeGeoaLUQk__nA_1988203952")]
    [DisplayName("Cash Deposit")]
    [IsoXmlTag("CshDpst")]
    public CashDeposit1? CashDeposit { get; init; } 
    
    /// <summary>
    /// Provides the data related to the card (number, scheme), terminal (number, identification) and transactional data used to uniquely identify a card transaction.
    /// </summary>
    [IsoId("_tuxFgFkyEeGeoaLUQk__nA_232539675")]
    [DisplayName("Card Transaction")]
    [IsoXmlTag("CardTx")]
    public CardTransaction1? CardTransaction { get; init; } 
    
    /// <summary>
    /// Further details of the transaction.
    /// </summary>
    [IsoId("_tuxFgVkyEeGeoaLUQk__nA_-130404251")]
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalTransactionInformation { get; init; } 
    
    
    #nullable disable
    
}
