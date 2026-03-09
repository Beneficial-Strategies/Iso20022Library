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
[IsoId("_TMoSHNp-Ed-ak6NoX_4Aeg_151667435")]
[DisplayName("Credit Transfer Transaction Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditTransferTransactionInformation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditTransferTransactionInformation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditTransferTransactionInformation3( PaymentIdentification2 reqPaymentIdentification,CurrencyAndAmount reqInterbankSettlementAmount,BranchAndFinancialInstitutionIdentification3 reqDebtor,BranchAndFinancialInstitutionIdentification3 reqCreditor )
    {
        PaymentIdentification = reqPaymentIdentification;
        InterbankSettlementAmount = reqInterbankSettlementAmount;
        Debtor = reqDebtor;
        Creditor = reqCreditor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements to reference a payment instruction.
    /// </summary>
    [IsoId("_TMxcANp-Ed-ak6NoX_4Aeg_381623298")]
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
    [IsoId("_TMxcAdp-Ed-ak6NoX_4Aeg_1075306136")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation5? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation5? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation5? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_TMxcAtp-Ed-ak6NoX_4Aeg_152589564")]
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
    [IsoId("_TMxcA9p-Ed-ak6NoX_4Aeg_152589992")]
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
    [IsoId("_TMxcBNp-Ed-ak6NoX_4Aeg_153515566")]
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
    [IsoId("_TMxcBdp-Ed-ak6NoX_4Aeg_378851801")]
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
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_TMxcBtp-Ed-ak6NoX_4Aeg_435910460")]
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
    [IsoId("_TMxcB9p-Ed-ak6NoX_4Aeg_-1502229696")]
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
    [IsoId("_TM7NANp-Ed-ak6NoX_4Aeg_405437121")]
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
    [IsoId("_TM7NAdp-Ed-ak6NoX_4Aeg_463618457")]
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
    [IsoId("_TM7NAtp-Ed-ak6NoX_4Aeg_417440600")]
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
    [IsoId("_TM7NA9p-Ed-ak6NoX_4Aeg_-1472679035")]
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
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    [IsoId("_TM7NBNp-Ed-ak6NoX_4Aeg_388811954")]
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
    [IsoId("_TM7NBdp-Ed-ak6NoX_4Aeg_-1558563612")]
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
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent3 identifies the agent between the intermediary agent 2 and the creditor agent.
    /// </summary>
    [IsoId("_TM7NBtp-Ed-ak6NoX_4Aeg_446070117")]
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
    [IsoId("_TM7NB9p-Ed-ak6NoX_4Aeg_-1484682731")]
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
    /// Ultimate financial institution that owes an amount of money to the (ultimate) institutional creditor.
    /// </summary>
    [IsoId("_TM7NCNp-Ed-ak6NoX_4Aeg_382545700")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? UltimateDebtor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    [IsoId("_TM7NCdp-Ed-ak6NoX_4Aeg_382547201")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification3 Debtor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification3 Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3 Debtor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3 Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_TNE-ANp-Ed-ak6NoX_4Aeg_160901529")]
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
    [IsoId("_TNE-Adp-Ed-ak6NoX_4Aeg_429447810")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TNE-Atp-Ed-ak6NoX_4Aeg_-1189156695")]
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
    [IsoId("_TNE-A9p-Ed-ak6NoX_4Aeg_458998047")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_TNE-BNp-Ed-ak6NoX_4Aeg_-1489302307")]
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
    /// Financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    [IsoId("_TNE-Bdp-Ed-ak6NoX_4Aeg_389935370")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification3 Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification3 Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3 Creditor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3 Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_TNE-Btp-Ed-ak6NoX_4Aeg_378853542")]
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
    /// Ultimate financial institution to which an amount of money is due.
    /// </summary>
    [IsoId("_TNE-B9p-Ed-ak6NoX_4Aeg_390857452")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? UltimateCreditor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the creditor agent. ||Usage: The instruction can relate to a level of service, can be an instruction to be executed by the creditor&apos;s agent, or can be information required by the creditor&apos;s agent to process the instruction.
    /// </summary>
    [IsoId("_TNE-CNp-Ed-ak6NoX_4Aeg_1967997773")]
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
    [IsoId("_TNE-Cdp-Ed-ak6NoX_4Aeg_380700533")]
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
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("_TNOH8Np-Ed-ak6NoX_4Aeg_-884442094")]
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
    
    
    #nullable disable
    
}
