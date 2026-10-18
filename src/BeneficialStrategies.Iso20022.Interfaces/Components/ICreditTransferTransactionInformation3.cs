// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_TMoSHNp-Ed-ak6NoX_4Aeg_151667435")]
public interface ICreditTransferTransactionInformation3 : IIsoComponent
{
    /// <summary>
    /// Set of elements to reference a payment instruction.
    /// </summary>
    [IsoId("_TMxcANp-Ed-ak6NoX_4Aeg_381623298")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification2 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_TMxcAdp-Ed-ak6NoX_4Aeg_1075306136")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation5? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_TMxcAtp-Ed-ak6NoX_4Aeg_152589564")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    CurrencyAndAmount InterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_TMxcA9p-Ed-ak6NoX_4Aeg_152589992")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    IsoISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_TMxcBNp-Ed-ak6NoX_4Aeg_153515566")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Provides information on the requested settlement time of the payment instruction.
    /// </summary>
    [IsoId("_TMxcBdp-Ed-ak6NoX_4Aeg_378851801")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest1? SettlementTimeRequest { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_TMxcBtp-Ed-ak6NoX_4Aeg_435910460")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    IBranchAndFinancialInstitutionIdentification3? PreviousInstructingAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TMxcB9p-Ed-ak6NoX_4Aeg_-1502229696")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    ICashAccount7? PreviousInstructingAgentAccount { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_TM7NANp-Ed-ak6NoX_4Aeg_405437121")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_TM7NAdp-Ed-ak6NoX_4Aeg_463618457")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructedAgent { get; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the debtor agent and the intermediary agent 2.
    /// </summary>
    [IsoId("_TM7NAtp-Ed-ak6NoX_4Aeg_417440600")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TM7NA9p-Ed-ak6NoX_4Aeg_-1472679035")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount7? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    [IsoId("_TM7NBNp-Ed-ak6NoX_4Aeg_388811954")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TM7NBdp-Ed-ak6NoX_4Aeg_-1558563612")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount7? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent3 identifies the agent between the intermediary agent 2 and the creditor agent.
    /// </summary>
    [IsoId("_TM7NBtp-Ed-ak6NoX_4Aeg_446070117")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TM7NB9p-Ed-ak6NoX_4Aeg_-1484682731")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount7? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Ultimate financial institution that owes an amount of money to the (ultimate) institutional creditor.
    /// </summary>
    [IsoId("_TM7NCNp-Ed-ak6NoX_4Aeg_382545700")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IBranchAndFinancialInstitutionIdentification3? UltimateDebtor { get; }

    /// <summary>
    /// Financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    [IsoId("_TM7NCdp-Ed-ak6NoX_4Aeg_382547201")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IBranchAndFinancialInstitutionIdentification3 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_TNE-ANp-Ed-ak6NoX_4Aeg_160901529")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount7? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_TNE-Adp-Ed-ak6NoX_4Aeg_429447810")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification3? DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TNE-Atp-Ed-ak6NoX_4Aeg_-1189156695")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount7? DebtorAgentAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_TNE-A9p-Ed-ak6NoX_4Aeg_458998047")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification3? CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_TNE-BNp-Ed-ak6NoX_4Aeg_-1489302307")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount7? CreditorAgentAccount { get; }

    /// <summary>
    /// Financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    [IsoId("_TNE-Bdp-Ed-ak6NoX_4Aeg_389935370")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IBranchAndFinancialInstitutionIdentification3 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_TNE-Btp-Ed-ak6NoX_4Aeg_378853542")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount7? CreditorAccount { get; }

    /// <summary>
    /// Ultimate financial institution to which an amount of money is due.
    /// </summary>
    [IsoId("_TNE-B9p-Ed-ak6NoX_4Aeg_390857452")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IBranchAndFinancialInstitutionIdentification3? UltimateCreditor { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the creditor agent. ||Usage: The instruction can relate to a level of service, can be an instruction to be executed by the creditor&apos;s agent, or can be information required by the creditor&apos;s agent to process the instruction.
    /// </summary>
    [IsoId("_TNE-CNp-Ed-ak6NoX_4Aeg_1967997773")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent2> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_TNE-Cdp-Ed-ak6NoX_4Aeg_380700533")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    IEnumerable<IInstructionForNextAgent1> InstructionForNextAgent { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("_TNOH8Np-Ed-ak6NoX_4Aeg_-884442094")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation2? RemittanceInformation { get; }
}
