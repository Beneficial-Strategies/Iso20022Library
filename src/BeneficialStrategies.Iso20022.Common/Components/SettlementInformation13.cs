// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInformation13"/>
[IsoId("_QI1J4dp-Ed-ak6NoX_4Aeg_949253671")]
[DisplayName("Settlement Information")]
public partial record SettlementInformation13
{
    /// <inheritdoc cref="ISettlementInformation13.SettlementMethod"/>
    [IsoId("_QI1J4tp-Ed-ak6NoX_4Aeg_949253681")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInformation13.SettlementAccount"/>
    [IsoId("_QI1J49p-Ed-ak6NoX_4Aeg_950173766")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount16? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation13.ClearingSystem"/>
    [IsoId("_QI1J5Np-Ed-ak6NoX_4Aeg_950173981")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInformation13.InstructingReimbursementAgent"/>
    [IsoId("_QI1J5dp-Ed-ak6NoX_4Aeg_950174011")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation13.InstructingReimbursementAgentAccount"/>
    [IsoId("_QI1J5tp-Ed-ak6NoX_4Aeg_950173828")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount16? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation13.InstructedReimbursementAgent"/>
    [IsoId("_QI1J59p-Ed-ak6NoX_4Aeg_950174290")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation13.InstructedReimbursementAgentAccount"/>
    [IsoId("_QI1J6Np-Ed-ak6NoX_4Aeg_950173889")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount16? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation13.ThirdReimbursementAgent"/>
    [IsoId("_QI-T0Np-Ed-ak6NoX_4Aeg_950174042")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification4? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation13.ThirdReimbursementAgentAccount"/>
    [IsoId("_QI-T0dp-Ed-ak6NoX_4Aeg_1876125574")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount16? ThirdReimbursementAgentAccount { get; init; }
}
