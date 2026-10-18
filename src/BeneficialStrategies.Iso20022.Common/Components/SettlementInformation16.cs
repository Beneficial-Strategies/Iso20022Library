// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInformation16"/>
[IsoId("_QHfGG9p-Ed-ak6NoX_4Aeg_-1606098687")]
[DisplayName("Settlement Information")]
public partial record SettlementInformation16
{
    /// <inheritdoc cref="ISettlementInformation16.SettlementMethod"/>
    [IsoId("_QHfGHNp-Ed-ak6NoX_4Aeg_646940987")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInformation16.SettlementAccount"/>
    [IsoId("_QHfGHdp-Ed-ak6NoX_4Aeg_-1048548137")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount16? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation16.ClearingSystem"/>
    [IsoId("_QHfGHtp-Ed-ak6NoX_4Aeg_1642921334")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInformation16.InstructingReimbursementAgent"/>
    [IsoId("_QHo3ENp-Ed-ak6NoX_4Aeg_1968038841")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation16.InstructingReimbursementAgentAccount"/>
    [IsoId("_QHo3Edp-Ed-ak6NoX_4Aeg_1575763687")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount16? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation16.InstructedReimbursementAgent"/>
    [IsoId("_QHo3Etp-Ed-ak6NoX_4Aeg_821013813")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation16.InstructedReimbursementAgentAccount"/>
    [IsoId("_QHo3E9p-Ed-ak6NoX_4Aeg_1275101082")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount16? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation16.ThirdReimbursementAgent"/>
    [IsoId("_QHo3FNp-Ed-ak6NoX_4Aeg_1264002305")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation16.ThirdReimbursementAgentAccount"/>
    [IsoId("_QHo3Fdp-Ed-ak6NoX_4Aeg_-1603368917")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount16? ThirdReimbursementAgentAccount { get; init; }
}
