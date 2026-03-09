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
/// Provide further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_t03tglkyEeGeoaLUQk__nA_-1126231527")]
[DisplayName("Credit Transfer Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditTransferTransaction4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditTransferTransaction4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditTransferTransaction4( PaymentIdentification3 reqPaymentIdentification,ActiveCurrencyAndAmount reqInterbankSettlementAmount,BranchAndFinancialInstitutionIdentification5 reqDebtor,BranchAndFinancialInstitutionIdentification5 reqCreditor )
    {
        PaymentIdentification = reqPaymentIdentification;
        InterbankSettlementAmount = reqInterbankSettlementAmount;
        Debtor = reqDebtor;
        Creditor = reqCreditor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_t1BegFkyEeGeoaLUQk__nA_-188937521")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification3 PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification3 PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification3 PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification3 PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_t1BegVkyEeGeoaLUQk__nA_416384236")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation21? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_t1BeglkyEeGeoaLUQk__nA_-996072760")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_t1Beg1kyEeGeoaLUQk__nA_834850409")]
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
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_t1LPgFkyEeGeoaLUQk__nA_-2045880265")]
    [DisplayName("Settlement Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPrty")]
    #endif
    [IsoXmlTag("SttlmPrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Priority3Code? SettlementPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority3Code? SettlementPriority { get; init; } 
    #else
    public Priority3Code? SettlementPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_t1LPgVkyEeGeoaLUQk__nA_616982832")]
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
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_t1LPglkyEeGeoaLUQk__nA_999437940")]
    [DisplayName("Settlement Time Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTmReq")]
    #endif
    [IsoXmlTag("SttlmTmReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    #else
    public SettlementTimeRequest2? SettlementTimeRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_t1LPg1kyEeGeoaLUQk__nA_2077458278")]
    [DisplayName("Previous Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstgAgt")]
    #endif
    [IsoXmlTag("PrvsInstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_t1LPhFkyEeGeoaLUQk__nA_-1456743865")]
    [DisplayName("Previous Instructing Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstgAgtAcct")]
    #endif
    [IsoXmlTag("PrvsInstgAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? PreviousInstructingAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? PreviousInstructingAgentAccount { get; init; } 
    #else
    public CashAccount24? PreviousInstructingAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_t1UZcFkyEeGeoaLUQk__nA_427176735")]
    [DisplayName("Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgt")]
    #endif
    [IsoXmlTag("InstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_t1UZcVkyEeGeoaLUQk__nA_1187941888")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_t1UZclkyEeGeoaLUQk__nA_-891800088")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1")]
    #endif
    [IsoXmlTag("IntrmyAgt1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_t1UZc1kyEeGeoaLUQk__nA_1559298219")]
    [DisplayName("Intermediary Agent 1 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt1Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? IntermediaryAgent1Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? IntermediaryAgent1Account { get; init; } 
    #else
    public CashAccount24? IntermediaryAgent1Account { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_t1UZdFkyEeGeoaLUQk__nA_2013385488")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2")]
    #endif
    [IsoXmlTag("IntrmyAgt2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_t1eKcFkyEeGeoaLUQk__nA_1163311970")]
    [DisplayName("Intermediary Agent 2 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt2Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? IntermediaryAgent2Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? IntermediaryAgent2Account { get; init; } 
    #else
    public CashAccount24? IntermediaryAgent2Account { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_t1eKcVkyEeGeoaLUQk__nA_-1437436306")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3")]
    #endif
    [IsoXmlTag("IntrmyAgt3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_t1n7cFkyEeGeoaLUQk__nA_-359415968")]
    [DisplayName("Intermediary Agent 3 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt3Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? IntermediaryAgent3Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? IntermediaryAgent3Account { get; init; } 
    #else
    public CashAccount24? IntermediaryAgent3Account { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate financial institution that owes an amount of money to the (ultimate) institutional creditor.
    /// </summary>
    [IsoId("_t1n7cVkyEeGeoaLUQk__nA_998394988")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    [IsoId("_t1n7clkyEeGeoaLUQk__nA_1967624386")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 Debtor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 Debtor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_t1n7c1kyEeGeoaLUQk__nA_-709163393")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? DebtorAccount { get; init; } 
    #else
    public CashAccount24? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_t1n7dFkyEeGeoaLUQk__nA_1893623706")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_t1xFYFkyEeGeoaLUQk__nA_311973648")]
    [DisplayName("Debtor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgtAcct")]
    #endif
    [IsoXmlTag("DbtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? DebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? DebtorAgentAccount { get; init; } 
    #else
    public CashAccount24? DebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_t1xFYVkyEeGeoaLUQk__nA_-1361309295")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_t162YFkyEeGeoaLUQk__nA_250814271")]
    [DisplayName("Creditor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgtAcct")]
    #endif
    [IsoXmlTag("CdtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? CreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? CreditorAgentAccount { get; init; } 
    #else
    public CashAccount24? CreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    [IsoId("_t162YVkyEeGeoaLUQk__nA_1868993788")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 Creditor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_t162YlkyEeGeoaLUQk__nA_494068776")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? CreditorAccount { get; init; } 
    #else
    public CashAccount24? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate financial institution to which an amount of money is due.
    /// </summary>
    [IsoId("_t162Y1kyEeGeoaLUQk__nA_948156045")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_t162ZFkyEeGeoaLUQk__nA_2116749552")]
    [DisplayName("Instruction For Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForCdtrAgt")]
    #endif
    [IsoXmlTag("InstrForCdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForCreditorAgent2? InstructionForCreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForCreditorAgent2? InstructionForCreditorAgent { get; init; } 
    #else
    public InstructionForCreditorAgent2? InstructionForCreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_t2EAUFkyEeGeoaLUQk__nA_1831788173")]
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
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_t2EAUVkyEeGeoaLUQk__nA_-1702413970")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation2? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation2? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation2? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the underlying customer credit transfer for which cover is provided.
    /// </summary>
    [IsoId("_t2EAUlkyEeGeoaLUQk__nA_582596468")]
    [DisplayName("Underlying Customer Credit Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygCstmrCdtTrf")]
    #endif
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditTransferTransaction3? UnderlyingCustomerCreditTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditTransferTransaction3? UnderlyingCustomerCreditTransfer { get; init; } 
    #else
    public CreditTransferTransaction3? UnderlyingCustomerCreditTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
