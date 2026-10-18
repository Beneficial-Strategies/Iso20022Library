// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information required for the settlement the transaction.
/// </summary>
[IsoId("_QH7yANp-Ed-ak6NoX_4Aeg_-1468499267")]
public interface ISettlementInformation3 : IIsoComponent
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_QH7yAdp-Ed-ak6NoX_4Aeg_-1468498972")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    SettlementMethod1Code SettlementMethod { get; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_QH7yAtp-Ed-ak6NoX_4Aeg_-1468498397")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    ICashAccount7? SettlementAccount { get; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_QH7yA9p-Ed-ak6NoX_4Aeg_-1468498353")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    IClearingSystemIdentification1Choice? ClearingSystem { get; }

    /// <summary>
    /// Specifies the agent through which the instructing agent will reimburse the instructed agent.||Usage: If the instructing and instructed agents have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_QH7yBNp-Ed-ak6NoX_4Aeg_-1468498006")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructingReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QH7yBdp-Ed-ak6NoX_4Aeg_-1467577932")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    ICashAccount7? InstructingReimbursementAgentAccount { get; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.||Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the instructed agent will claim reimbursement from that branch/will be paid by that branch.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_QH7yBtp-Ed-ak6NoX_4Aeg_-1468498301")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructedReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QH7yB9p-Ed-ak6NoX_4Aeg_-1467577880")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    ICashAccount7? InstructedReimbursementAgentAccount { get; }

    /// <summary>
    /// Specifies the branch of the instructed agent where the amount of money will be made available when different from the instructed reimbursement agent.
    /// </summary>
    [IsoId("_QH7yCNp-Ed-ak6NoX_4Aeg_-1468497964")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification3? ThirdReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QH7yCdp-Ed-ak6NoX_4Aeg_-1467577837")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    ICashAccount7? ThirdReimbursementAgentAccount { get; }
}
