// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction23"/>
[IsoId("_wf2GsZRuEeazAtAtDSg0Nw")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction23
{
    /// <inheritdoc cref="IPaymentInstruction23.PaymentInformationIdentification"/>
    [IsoId("_wubVV5RuEeazAtAtDSg0Nw")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.PaymentMethod"/>
    [IsoId("_wubVWZRuEeazAtAtDSg0Nw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.PaymentTypeInformation"/>
    [IsoId("_wubVW5RuEeazAtAtDSg0Nw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.RequestedExecutionDate"/>
    [IsoId("_wubVXZRuEeazAtAtDSg0Nw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTimeChoice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.Debtor"/>
    [IsoId("_wubVX5RuEeazAtAtDSg0Nw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.DebtorAccount"/>
    [IsoId("_wubVYZRuEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.DebtorAgent"/>
    [IsoId("_wubVY5RuEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.UltimateDebtor"/>
    [IsoId("_wubVZZRuEeazAtAtDSg0Nw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.ChargeBearer"/>
    [IsoId("_wubVZ5RuEeazAtAtDSg0Nw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction23.CreditTransferTransaction"/>
    [IsoId("_wubVaZRuEeazAtAtDSg0Nw")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransaction22> CreditTransferTransaction { get; init; } = [];
    // ID for the above is _wubVaZRuEeazAtAtDSg0Nw
}
