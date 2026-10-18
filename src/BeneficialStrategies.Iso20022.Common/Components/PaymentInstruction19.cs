// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction19"/>
[IsoId("_1k_eATq4EeWZFYSPlduMhw")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction19
{
    /// <inheritdoc cref="IPaymentInstruction19.PaymentInformationIdentification"/>
    [IsoId("_1tSeVzq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.PaymentMethod"/>
    [IsoId("_1tSeWTq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.PaymentTypeInformation"/>
    [IsoId("_1tSeWzq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.RequestedExecutionDate"/>
    [IsoId("_1tSeXTq4EeWZFYSPlduMhw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.Debtor"/>
    [IsoId("_1tSeXzq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.DebtorAccount"/>
    [IsoId("_1tSeYTq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.DebtorAgent"/>
    [IsoId("_1tSeYzq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.UltimateDebtor"/>
    [IsoId("_1tSeZTq4EeWZFYSPlduMhw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.ChargeBearer"/>
    [IsoId("_1tSeZzq4EeWZFYSPlduMhw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction19.CreditTransferTransaction"/>
    [IsoId("_1tSeaTq4EeWZFYSPlduMhw")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransaction22> CreditTransferTransaction { get; init; } = [];
    // ID for the above is _1tSeaTq4EeWZFYSPlduMhw
}
