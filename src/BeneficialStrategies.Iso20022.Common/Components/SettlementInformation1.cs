// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInformation1"/>
[IsoId("_QIOs8Np-Ed-ak6NoX_4Aeg_252070899")]
[DisplayName("Settlement Information")]
public partial record SettlementInformation1
{
    /// <inheritdoc cref="ISettlementInformation1.SettlementMethod"/>
    [IsoId("_QIOs8dp-Ed-ak6NoX_4Aeg_365664027")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInformation1.SettlementAccount"/>
    [IsoId("_QIOs8tp-Ed-ak6NoX_4Aeg_1798967708")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount7? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation1.ClearingSystem"/>
    [IsoId("_QIOs89p-Ed-ak6NoX_4Aeg_2088028158")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification1Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInformation1.InstructingReimbursementAgent"/>
    [IsoId("_QIOs9Np-Ed-ak6NoX_4Aeg_-1849535834")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation1.InstructingReimbursementAgentAccount"/>
    [IsoId("_QIOs9dp-Ed-ak6NoX_4Aeg_-2069254144")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount7? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation1.InstructedReimbursementAgent"/>
    [IsoId("_QIOs9tp-Ed-ak6NoX_4Aeg_-1862466137")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation1.InstructedReimbursementAgentAccount"/>
    [IsoId("_QIOs99p-Ed-ak6NoX_4Aeg_-2005533042")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount7? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation1.ThirdReimbursementAgent"/>
    [IsoId("_QIYd8Np-Ed-ak6NoX_4Aeg_-521074442")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation1.ThirdReimbursementAgentAccount"/>
    [IsoId("_QIYd8dp-Ed-ak6NoX_4Aeg_1945291302")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount7? ThirdReimbursementAgentAccount { get; init; }
}
