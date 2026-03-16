// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_TMoSHNp-Ed-ak6NoX_4Aeg_151667435")]
[DisplayName("Credit Transfer Transaction Information")]
public record CreditTransferTransactionInformation3
{
    /// <summary>
    /// Set of elements to reference a payment instruction.
    /// </summary>
    [IsoId("_TMxcANp-Ed-ak6NoX_4Aeg_381623298")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification2 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_TMxcAdp-Ed-ak6NoX_4Aeg_1075306136")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation5? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_TMxcAtp-Ed-ak6NoX_4Aeg_152589564")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required CurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_TMxcA9p-Ed-ak6NoX_4Aeg_152589992")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_TMxcBNp-Ed-ak6NoX_4Aeg_153515566")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <summary>
    /// Provides information on the requested settlement time of the payment instruction.
    /// </summary>
    [IsoId("_TMxcBdp-Ed-ak6NoX_4Aeg_378851801")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest1? SettlementTimeRequest { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_TMxcBtp-Ed-ak6NoX_4Aeg_435910460")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? PreviousInstructingAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TMxcB9p-Ed-ak6NoX_4Aeg_-1502229696")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount7? PreviousInstructingAgentAccount { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_TM7NANp-Ed-ak6NoX_4Aeg_405437121")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_TM7NAdp-Ed-ak6NoX_4Aeg_463618457")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the debtor agent and the intermediary agent 2.
    /// </summary>
    [IsoId("_TM7NAtp-Ed-ak6NoX_4Aeg_417440600")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TM7NA9p-Ed-ak6NoX_4Aeg_-1472679035")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount7? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    [IsoId("_TM7NBNp-Ed-ak6NoX_4Aeg_388811954")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TM7NBdp-Ed-ak6NoX_4Aeg_-1558563612")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount7? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent3 identifies the agent between the intermediary agent 2 and the creditor agent.
    /// </summary>
    [IsoId("_TM7NBtp-Ed-ak6NoX_4Aeg_446070117")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TM7NB9p-Ed-ak6NoX_4Aeg_-1484682731")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount7? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Ultimate financial institution that owes an amount of money to the (ultimate) institutional creditor.
    /// </summary>
    [IsoId("_TM7NCNp-Ed-ak6NoX_4Aeg_382545700")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification3? UltimateDebtor { get; init; }

    /// <summary>
    /// Financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    [IsoId("_TM7NCdp-Ed-ak6NoX_4Aeg_382547201")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification3 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_TNE-ANp-Ed-ak6NoX_4Aeg_160901529")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount7? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_TNE-Adp-Ed-ak6NoX_4Aeg_429447810")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_TNE-Atp-Ed-ak6NoX_4Aeg_-1189156695")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount7? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_TNE-A9p-Ed-ak6NoX_4Aeg_458998047")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_TNE-BNp-Ed-ak6NoX_4Aeg_-1489302307")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    [IsoId("_TNE-Bdp-Ed-ak6NoX_4Aeg_389935370")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification3 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_TNE-Btp-Ed-ak6NoX_4Aeg_378853542")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount7? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate financial institution to which an amount of money is due.
    /// </summary>
    [IsoId("_TNE-B9p-Ed-ak6NoX_4Aeg_390857452")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification3? UltimateCreditor { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the creditor agent. ||Usage: The instruction can relate to a level of service, can be an instruction to be executed by the creditor&apos;s agent, or can be information required by the creditor&apos;s agent to process the instruction.
    /// </summary>
    [IsoId("_TNE-CNp-Ed-ak6NoX_4Aeg_1967997773")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public InstructionForCreditorAgent2? InstructionForCreditorAgent { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_TNE-Cdp-Ed-ak6NoX_4Aeg_380700533")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public InstructionForNextAgent1? InstructionForNextAgent { get; init; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("_TNOH8Np-Ed-ak6NoX_4Aeg_-884442094")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }
}
