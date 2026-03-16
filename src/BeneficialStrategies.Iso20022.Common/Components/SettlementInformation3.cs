// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information required for the settlement the transaction.
/// </summary>
[IsoId("_QH7yANp-Ed-ak6NoX_4Aeg_-1468499267")]
[DisplayName("Settlement Information")]
public record SettlementInformation3
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_QH7yAdp-Ed-ak6NoX_4Aeg_-1468498972")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_QH7yAtp-Ed-ak6NoX_4Aeg_-1468498397")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount7? SettlementAccount { get; init; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_QH7yA9p-Ed-ak6NoX_4Aeg_-1468498353")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification1Choice_? ClearingSystem { get; init; }

    /// <summary>
    /// Specifies the agent through which the instructing agent will reimburse the instructed agent.||Usage: If the instructing and instructed agents have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_QH7yBNp-Ed-ak6NoX_4Aeg_-1468498006")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QH7yBdp-Ed-ak6NoX_4Aeg_-1467577932")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount7? InstructingReimbursementAgentAccount { get; init; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.||Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the instructed agent will claim reimbursement from that branch/will be paid by that branch.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_QH7yBtp-Ed-ak6NoX_4Aeg_-1468498301")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QH7yB9p-Ed-ak6NoX_4Aeg_-1467577880")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount7? InstructedReimbursementAgentAccount { get; init; }

    /// <summary>
    /// Specifies the branch of the instructed agent where the amount of money will be made available when different from the instructed reimbursement agent.
    /// </summary>
    [IsoId("_QH7yCNp-Ed-ak6NoX_4Aeg_-1468497964")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? ThirdReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QH7yCdp-Ed-ak6NoX_4Aeg_-1467577837")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount7? ThirdReimbursementAgentAccount { get; init; }
}
