// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction5"/>
[IsoId("_PfG3eNp-Ed-ak6NoX_4Aeg_403375874")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction5
{
    /// <inheritdoc cref="IPaymentInstruction5.PaymentInformationIdentification"/>
    [IsoId("_PfG3edp-Ed-ak6NoX_4Aeg_843707405")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.PaymentMethod"/>
    [IsoId("_Pf2eUNp-Ed-ak6NoX_4Aeg_-372599164")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.PaymentTypeInformation"/>
    [IsoId("_Pf2eUdp-Ed-ak6NoX_4Aeg_1557665807")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.RequestedExecutionDate"/>
    [IsoId("_Pf_oQNp-Ed-ak6NoX_4Aeg_2005716198")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.Debtor"/>
    [IsoId("_Pf_oQdp-Ed-ak6NoX_4Aeg_264641518")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.DebtorAccount"/>
    [IsoId("_Pf_oQtp-Ed-ak6NoX_4Aeg_-721694171")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount7? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.DebtorAgent"/>
    [IsoId("_Pf_oQ9p-Ed-ak6NoX_4Aeg_278407996")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.UltimateDebtor"/>
    [IsoId("_Pf_oRNp-Ed-ak6NoX_4Aeg_767613621")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.ChargeBearer"/>
    [IsoId("_Pf_oRdp-Ed-ak6NoX_4Aeg_1224258963")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction5.CreditTransferTransaction"/>
    [IsoId("_Pf_oRtp-Ed-ak6NoX_4Aeg_-1609470423")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransactionInformation14> CreditTransferTransaction { get; init; } =
        [];
    // ID for the above is _Pf_oRtp-Ed-ak6NoX_4Aeg_-1609470423
}
