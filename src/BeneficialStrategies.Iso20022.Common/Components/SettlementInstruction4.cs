// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInstruction4"/>
[IsoId("_tgdjw1kyEeGeoaLUQk__nA_721141769")]
[DisplayName("Settlement Instruction")]
public partial record SettlementInstruction4
{
    /// <inheritdoc cref="ISettlementInstruction4.SettlementMethod"/>
    [IsoId("_tgmtsFkyEeGeoaLUQk__nA_-1414684958")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInstruction4.SettlementAccount"/>
    [IsoId("_tgmtsVkyEeGeoaLUQk__nA_-911448779")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount24? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction4.ClearingSystem"/>
    [IsoId("_tgwesFkyEeGeoaLUQk__nA_1373561659")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInstruction4.InstructingReimbursementAgent"/>
    [IsoId("_tg6PsFkyEeGeoaLUQk__nA_-1843385299")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction4.InstructingReimbursementAgentAccount"/>
    [IsoId("_tg6PsVkyEeGeoaLUQk__nA_1730478241")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount24? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction4.InstructedReimbursementAgent"/>
    [IsoId("_tg6PslkyEeGeoaLUQk__nA_2112933349")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction4.InstructedReimbursementAgentAccount"/>
    [IsoId("_thDZoFkyEeGeoaLUQk__nA_2101834572")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount24? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction4.ThirdReimbursementAgent"/>
    [IsoId("_thDZoVkyEeGeoaLUQk__nA_863741644")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInstruction4.ThirdReimbursementAgentAccount"/>
    [IsoId("_thDZolkyEeGeoaLUQk__nA_852642867")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount24? ThirdReimbursementAgentAccount { get; init; }
}
