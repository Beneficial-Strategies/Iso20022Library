// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInstruction7"/>
[IsoId("_UG9TYXh1EeidzqjNEfehPg")]
[DisplayName("Settlement Instruction")]
public partial record SettlementInstruction7
{
    /// <inheritdoc cref="ISettlementInstruction7.SettlementMethod"/>
    [IsoId("_UU8FAXh1EeidzqjNEfehPg")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInstruction7.SettlementAccount"/>
    [IsoId("_UU8FA3h1EeidzqjNEfehPg")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount38? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction7.ClearingSystem"/>
    [IsoId("_UU8FBXh1EeidzqjNEfehPg")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInstruction7.InstructingReimbursementAgent"/>
    [IsoId("_UU8FB3h1EeidzqjNEfehPg")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction7.InstructingReimbursementAgentAccount"/>
    [IsoId("_UU8FCXh1EeidzqjNEfehPg")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount38? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction7.InstructedReimbursementAgent"/>
    [IsoId("_UU8FC3h1EeidzqjNEfehPg")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction7.InstructedReimbursementAgentAccount"/>
    [IsoId("_UU8FDXh1EeidzqjNEfehPg")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount38? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction7.ThirdReimbursementAgent"/>
    [IsoId("_UU8FD3h1EeidzqjNEfehPg")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction7.ThirdReimbursementAgentAccount"/>
    [IsoId("_UU8FEXh1EeidzqjNEfehPg")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount38? ThirdReimbursementAgentAccount { get; init; }
}
