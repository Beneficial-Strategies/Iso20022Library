// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInformation3"/>
[IsoId("_QH7yANp-Ed-ak6NoX_4Aeg_-1468499267")]
[DisplayName("Settlement Information")]
public partial record SettlementInformation3
{
    /// <inheritdoc cref="ISettlementInformation3.SettlementMethod"/>
    [IsoId("_QH7yAdp-Ed-ak6NoX_4Aeg_-1468498972")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInformation3.SettlementAccount"/>
    [IsoId("_QH7yAtp-Ed-ak6NoX_4Aeg_-1468498397")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount7? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation3.ClearingSystem"/>
    [IsoId("_QH7yA9p-Ed-ak6NoX_4Aeg_-1468498353")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification1Choice_? ClearingSystem { get; init; }

    /// <inheritdoc cref="ISettlementInformation3.InstructingReimbursementAgent"/>
    [IsoId("_QH7yBNp-Ed-ak6NoX_4Aeg_-1468498006")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation3.InstructingReimbursementAgentAccount"/>
    [IsoId("_QH7yBdp-Ed-ak6NoX_4Aeg_-1467577932")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount7? InstructingReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation3.InstructedReimbursementAgent"/>
    [IsoId("_QH7yBtp-Ed-ak6NoX_4Aeg_-1468498301")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation3.InstructedReimbursementAgentAccount"/>
    [IsoId("_QH7yB9p-Ed-ak6NoX_4Aeg_-1467577880")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount7? InstructedReimbursementAgentAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation3.ThirdReimbursementAgent"/>
    [IsoId("_QH7yCNp-Ed-ak6NoX_4Aeg_-1468497964")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification3? ThirdReimbursementAgent { get; init; }

    /// <inheritdoc cref="ISettlementInformation3.ThirdReimbursementAgentAccount"/>
    [IsoId("_QH7yCdp-Ed-ak6NoX_4Aeg_-1467577837")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount7? ThirdReimbursementAgentAccount { get; init; }
}
