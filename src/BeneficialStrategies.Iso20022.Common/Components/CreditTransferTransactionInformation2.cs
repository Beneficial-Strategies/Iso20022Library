// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_PwY0tdp-Ed-ak6NoX_4Aeg_-106374737")]
[DisplayName("Credit Transfer Transaction Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditTransferTransactionInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditTransferTransactionInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditTransferTransactionInformation2( PaymentIdentification2 reqPaymentIdentification,CurrencyAndAmount reqInterbankSettlementAmount,ChargeBearerType1Code reqChargeBearer,PartyIdentification8 reqDebtor,BranchAndFinancialInstitutionIdentification3 reqDebtorAgent,BranchAndFinancialInstitutionIdentification3 reqCreditorAgent,PartyIdentification8 reqCreditor )
    {
        PaymentIdentification = reqPaymentIdentification;
        InterbankSettlementAmount = reqInterbankSettlementAmount;
        ChargeBearer = reqChargeBearer;
        Debtor = reqDebtor;
        DebtorAgent = reqDebtorAgent;
        CreditorAgent = reqCreditorAgent;
        Creditor = reqCreditor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements to reference a payment instruction.
    /// </summary>
    [IsoId("_PwY0ttp-Ed-ak6NoX_4Aeg_2098070233")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification2 PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification2 PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification2 PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification2 PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_PwY0t9p-Ed-ak6NoX_4Aeg_682307452")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation3? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation3? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation3? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_PwY0uNp-Ed-ak6NoX_4Aeg_-1322502579")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #else
    public CurrencyAndAmount InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_PwY0udp-Ed-ak6NoX_4Aeg_-767465995")]
    [DisplayName("Interbank Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmDt")]
    #endif
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? InterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_PwY0utp-Ed-ak6NoX_4Aeg_6445050")]
    [DisplayName("Settlement Time Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTmIndctn")]
    #endif
    [IsoXmlTag("SttlmTmIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; } 
    #else
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the requested settlement time of the payment instruction.
    /// </summary>
    [IsoId("_PwY0u9p-Ed-ak6NoX_4Aeg_966462995")]
    [DisplayName("Settlement Time Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTmReq")]
    #endif
    [IsoXmlTag("SttlmTmReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTimeRequest1? SettlementTimeRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTimeRequest1? SettlementTimeRequest { get; init; } 
    #else
    public SettlementTimeRequest1? SettlementTimeRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent (debtor&apos;s agent in case of a credit transfer, creditor&apos;s agent in case of a direct debit). This means - amongst others - that the account servicing agent has received the payment order and has applied checks as eg, authorisation, availability of funds.
    /// </summary>
    [IsoId("_PwY0vNp-Ed-ak6NoX_4Aeg_1053866212")]
    [DisplayName("Acceptance Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptncDtTm")]
    #endif
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AcceptanceDateTime { get; init; } 
    #else
    public System.DateTime? AcceptanceDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    [IsoId("_PwilsNp-Ed-ak6NoX_4Aeg_-781739202")]
    [DisplayName("Pooling Adjustment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolgAdjstmntDt")]
    #endif
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PoolingAdjustmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PoolingAdjustmentDate { get; init; } 
    #else
    public System.DateOnly? PoolingAdjustmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_Pwilsdp-Ed-ak6NoX_4Aeg_-1297565992")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? InstructedAmount { get; init; } 
    #else
    public CurrencyAndAmount? InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// The factor used for conversion of an amount from one currency to another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_Pwilstp-Ed-ak6NoX_4Aeg_-986341048")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_Pwils9p-Ed-ak6NoX_4Aeg_-930005781")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeBearerType1Code ChargeBearer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeBearerType1Code ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType1Code ChargeBearer { get; init; } 
    #else
    public ChargeBearerType1Code ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges related to the payment transaction.
    /// </summary>
    [IsoId("_PwiltNp-Ed-ak6NoX_4Aeg_-332920223")]
    [DisplayName("Charges Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsInf")]
    #endif
    [IsoXmlTag("ChrgsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesInformation1? ChargesInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesInformation1? ChargesInformation { get; init; } 
    #else
    public ChargesInformation1? ChargesInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_Pwiltdp-Ed-ak6NoX_4Aeg_-2071059758")]
    [DisplayName("Previous Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstgAgt")]
    #endif
    [IsoXmlTag("PrvsInstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? PreviousInstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? PreviousInstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? PreviousInstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Pwilttp-Ed-ak6NoX_4Aeg_1032911358")]
    [DisplayName("Previous Instructing Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstgAgtAcct")]
    #endif
    [IsoXmlTag("PrvsInstgAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? PreviousInstructingAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? PreviousInstructingAgentAccount { get; init; } 
    #else
    public CashAccount7? PreviousInstructingAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Pwilt9p-Ed-ak6NoX_4Aeg_-2040581709")]
    [DisplayName("Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgt")]
    #endif
    [IsoXmlTag("InstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PwiluNp-Ed-ak6NoX_4Aeg_-2113539496")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the debtor agent and the intermediary agent 2.
    /// </summary>
    [IsoId("_Pwiludp-Ed-ak6NoX_4Aeg_1809247478")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1")]
    #endif
    [IsoXmlTag("IntrmyAgt1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PwrvoNp-Ed-ak6NoX_4Aeg_-1491069251")]
    [DisplayName("Intermediary Agent 1 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt1Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? IntermediaryAgent1Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? IntermediaryAgent1Account { get; init; } 
    #else
    public CashAccount7? IntermediaryAgent1Account { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    [IsoId("_Pwrvodp-Ed-ak6NoX_4Aeg_-1981475557")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2")]
    #endif
    [IsoXmlTag("IntrmyAgt2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Pwrvotp-Ed-ak6NoX_4Aeg_804803392")]
    [DisplayName("Intermediary Agent 2 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt2Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? IntermediaryAgent2Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? IntermediaryAgent2Account { get; init; } 
    #else
    public CashAccount7? IntermediaryAgent2Account { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the creditor agent.
    /// </summary>
    [IsoId("_Pwrvo9p-Ed-ak6NoX_4Aeg_-2011029531")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3")]
    #endif
    [IsoXmlTag("IntrmyAgt3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PwrvpNp-Ed-ak6NoX_4Aeg_790028235")]
    [DisplayName("Intermediary Agent 3 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt3Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? IntermediaryAgent3Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? IntermediaryAgent3Account { get; init; } 
    #else
    public CashAccount7? IntermediaryAgent3Account { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Pwrvpdp-Ed-ak6NoX_4Aeg_-358708225")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? UltimateDebtor { get; init; } 
    #else
    public PartyIdentification8? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the payment. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or a party that initiates the payment on behalf of the debtor or creditor.
    /// </summary>
    [IsoId("_Pwrvptp-Ed-ak6NoX_4Aeg_-372559691")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? InitiatingParty { get; init; } 
    #else
    public PartyIdentification8? InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Pwrvp9p-Ed-ak6NoX_4Aeg_-362401349")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8 Debtor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8 Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8 Debtor { get; init; } 
    #else
    public PartyIdentification8 Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_PwrvqNp-Ed-ak6NoX_4Aeg_720541782")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? DebtorAccount { get; init; } 
    #else
    public CashAccount7? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Pw1goNp-Ed-ak6NoX_4Aeg_1893286938")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Pw1godp-Ed-ak6NoX_4Aeg_688441268")]
    [DisplayName("Debtor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgtAcct")]
    #endif
    [IsoXmlTag("DbtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? DebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? DebtorAgentAccount { get; init; } 
    #else
    public CashAccount7? DebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_Pw1gotp-Ed-ak6NoX_4Aeg_-2143094093")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_Pw1go9p-Ed-ak6NoX_4Aeg_656115818")]
    [DisplayName("Creditor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgtAcct")]
    #endif
    [IsoXmlTag("CdtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? CreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? CreditorAgentAccount { get; init; } 
    #else
    public CashAccount7? CreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_Pw1gpNp-Ed-ak6NoX_4Aeg_-377179016")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8 Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8 Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8 Creditor { get; init; } 
    #else
    public PartyIdentification8 Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_Pw1gpdp-Ed-ak6NoX_4Aeg_-872202728")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? CreditorAccount { get; init; } 
    #else
    public CashAccount7? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_Pw1gptp-Ed-ak6NoX_4Aeg_-627453312")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? UltimateCreditor { get; init; } 
    #else
    public PartyIdentification8? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the creditor agent. ||Usage: The instruction can relate to a level of service, can be an instruction to be executed by the creditor&apos;s agent, or can be information required by the creditor&apos;s agent to process the instruction.
    /// </summary>
    [IsoId("_Pw1gp9p-Ed-ak6NoX_4Aeg_-1299402383")]
    [DisplayName("Instruction For Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForCdtrAgt")]
    #endif
    [IsoXmlTag("InstrForCdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; init; } 
    #else
    public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_Pw1gqNp-Ed-ak6NoX_4Aeg_545462259")]
    [DisplayName("Instruction For Next Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForNxtAgt")]
    #endif
    [IsoXmlTag("InstrForNxtAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForNextAgent1? InstructionForNextAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForNextAgent1? InstructionForNextAgent { get; init; } 
    #else
    public InstructionForNextAgent1? InstructionForNextAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction.||Usage: Purpose is used by the end-customers, i.e. initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_Pw1gqdp-Ed-ak6NoX_4Aeg_-152558433")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Purpose1Choice_? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Purpose1Choice_? Purpose { get; init; } 
    #else
    public Purpose1Choice_? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_Pw_RoNp-Ed-ak6NoX_4Aeg_-210307224")]
    [DisplayName("Regulatory Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryRptg")]
    #endif
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting2> RegulatoryReporting { get; init; } = new ValueList<RegulatoryReporting2>(){};
    
    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_Pw_Rodp-Ed-ak6NoX_4Aeg_154483444")]
    [DisplayName("Related Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRmtInf")]
    #endif
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation1>(){};
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_Pw_Rotp-Ed-ak6NoX_4Aeg_-2080988572")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation1? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation1? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation1? RemittanceInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
