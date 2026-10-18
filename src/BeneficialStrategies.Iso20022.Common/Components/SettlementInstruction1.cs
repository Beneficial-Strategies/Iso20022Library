// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInstruction1"/>
[IsoId("_thgFkFkyEeGeoaLUQk__nA_-1005103671")]
[DisplayName("Settlement Instruction")]
public partial record SettlementInstruction1
{
    /// <inheritdoc cref="ISettlementInstruction1.SettlementMethod"/>
    [IsoId("_thgFkVkyEeGeoaLUQk__nA_-2116015090")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInstruction1.SettlementAccount"/>
    [IsoId("_thp2kFkyEeGeoaLUQk__nA_692955488")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount24? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction1.ClearingSystem"/>
    [IsoId("_thp2kVkyEeGeoaLUQk__nA_-1457591385")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInstruction1.InstructingReimbursementAgent"/>
    [IsoId("_thp2klkyEeGeoaLUQk__nA_-696826232")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction1.InstructingReimbursementAgentAccount"/>
    [IsoId("_thp2k1kyEeGeoaLUQk__nA_-1883116034")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount24? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction1.InstructedReimbursementAgent"/>
    [IsoId("_thp2lFkyEeGeoaLUQk__nA_1577085429")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction1.InstructedReimbursementAgentAccount"/>
    [IsoId("_thzAgFkyEeGeoaLUQk__nA_-1303645245")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount24? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction1.ThirdReimbursementAgent"/>
    [IsoId("_thzAgVkyEeGeoaLUQk__nA_-1341631288")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction1.ThirdReimbursementAgentAccount"/>
    [IsoId("_thzAglkyEeGeoaLUQk__nA_-2096381162")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount24? ThirdReimbursementAgentAccount { get; init; }
}
