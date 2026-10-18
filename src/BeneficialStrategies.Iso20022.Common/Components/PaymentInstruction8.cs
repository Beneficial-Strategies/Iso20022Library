// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction8"/>
[IsoId("_suFroFkyEeGeoaLUQk__nA_-833817097")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction8
{
    /// <inheritdoc cref="IPaymentInstruction8.PaymentInformationIdentification"/>
    [IsoId("_suFroVkyEeGeoaLUQk__nA_-1947697392")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.PaymentMethod"/>
    [IsoId("_suPcoFkyEeGeoaLUQk__nA_1236358485")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.PaymentTypeInformation"/>
    [IsoId("_suPcoVkyEeGeoaLUQk__nA_-579667549")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.RequestedExecutionDate"/>
    [IsoId("_suPcolkyEeGeoaLUQk__nA_-395745714")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.Debtor"/>
    [IsoId("_suZNoFkyEeGeoaLUQk__nA_-1021502163")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.DebtorAccount"/>
    [IsoId("_suZNoVkyEeGeoaLUQk__nA_-960319368")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.DebtorAgent"/>
    [IsoId("_suZNolkyEeGeoaLUQk__nA_117700970")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.UltimateDebtor"/>
    [IsoId("_suZNo1kyEeGeoaLUQk__nA_1421451207")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.ChargeBearer"/>
    [IsoId("_suZNpFkyEeGeoaLUQk__nA_1697596793")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction8.CreditTransferTransaction"/>
    [IsoId("_suiXkFkyEeGeoaLUQk__nA_-1131490735")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransaction5> CreditTransferTransaction { get; init; } = [];
    // ID for the above is _suiXkFkyEeGeoaLUQk__nA_-1131490735
}
