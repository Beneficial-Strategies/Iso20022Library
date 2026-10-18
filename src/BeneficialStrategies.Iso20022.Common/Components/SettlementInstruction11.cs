// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInstruction11"/>
[IsoId("_a1fsodcZEeqRFcf2R4bPBw")]
[DisplayName("Settlement Instruction")]
public partial record SettlementInstruction11
{
    /// <inheritdoc cref="ISettlementInstruction11.SettlementMethod"/>
    [IsoId("_a24MwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInstruction11.SettlementAccount"/>
    [IsoId("_a24Mw9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount40? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction11.ClearingSystem"/>
    [IsoId("_a24MxdcZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInstruction11.InstructingReimbursementAgent"/>
    [IsoId("_a24Mx9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction11.InstructingReimbursementAgentAccount"/>
    [IsoId("_a24MydcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount40? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction11.InstructedReimbursementAgent"/>
    [IsoId("_a24My9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction11.InstructedReimbursementAgentAccount"/>
    [IsoId("_a24MzdcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount40? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction11.ThirdReimbursementAgent"/>
    [IsoId("_a24Mz9cZEeqRFcf2R4bPBw")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction11.ThirdReimbursementAgentAccount"/>
    [IsoId("_a24M0dcZEeqRFcf2R4bPBw")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount40? ThirdReimbursementAgentAccount { get; init; }
}
