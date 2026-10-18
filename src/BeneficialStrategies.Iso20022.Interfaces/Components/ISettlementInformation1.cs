// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information required for the settlement the transaction.
/// </summary>
[IsoId("_QIOs8Np-Ed-ak6NoX_4Aeg_252070899")]
public interface ISettlementInformation1 : IIsoComponent
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_QIOs8dp-Ed-ak6NoX_4Aeg_365664027")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    SettlementMethod1Code SettlementMethod { get; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_QIOs8tp-Ed-ak6NoX_4Aeg_1798967708")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    ICashAccount7? SettlementAccount { get; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_QIOs89p-Ed-ak6NoX_4Aeg_2088028158")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    IClearingSystemIdentification1Choice? ClearingSystem { get; }

    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_QIOs9Np-Ed-ak6NoX_4Aeg_-1849535834")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructingReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QIOs9dp-Ed-ak6NoX_4Aeg_-2069254144")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    ICashAccount7? InstructingReimbursementAgentAccount { get; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.||Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the instructed agent will claim reimbursement from that branch/will be paid by that branch.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_QIOs9tp-Ed-ak6NoX_4Aeg_-1862466137")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructedReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QIOs99p-Ed-ak6NoX_4Aeg_-2005533042")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    ICashAccount7? InstructedReimbursementAgentAccount { get; }

    /// <summary>
    /// Instructed agent&apos;s branch where the amount of money will be made available when different from the instructed reimbursement agent.
    /// </summary>
    [IsoId("_QIYd8Np-Ed-ak6NoX_4Aeg_-521074442")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification3? ThirdReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QIYd8dp-Ed-ak6NoX_4Aeg_1945291302")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    ICashAccount7? ThirdReimbursementAgentAccount { get; }
}
