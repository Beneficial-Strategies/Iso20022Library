// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction48"/>
[IsoId("41f45edb-b794-450d-b6d0-63ff93e72ea6")]
[DisplayName("Payment Instruction48")]
public partial record PaymentInstruction48
{
    /// <inheritdoc cref="IPaymentInstruction48.PaymentInformationIdentification"/>
    [IsoId("7e046422-12a7-43b1-8d82-2d5aeccb7cc9")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.PaymentMethod"/>
    [IsoId("bcadcafc-cd22-46e9-a8f0-3cf69e4294d3")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.RequestedAdviceType"/>
    [IsoId("0937e93f-5b68-4f72-99e0-ee5f64e12477")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.PaymentTypeInformation"/>
    [IsoId("75e443e1-b75a-42eb-87f1-26d4c94a7683")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.RequestedExecutionDate"/>
    [IsoId("5230153b-c55e-49a2-ae5e-8c13139f4d3f")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.ExpiryDate"/>
    [IsoId("7ff1e358-962d-4718-b59c-03656321f1c4")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.PaymentCondition"/>
    [IsoId("7d58dbab-13fe-4b94-ad8b-5b8d3ce8f597")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition2? PaymentCondition { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.Debtor"/>
    [IsoId("27e9b5e4-91c5-47d7-b63f-150a0473d822")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.DebtorAccount"/>
    [IsoId("d9316fef-3978-4511-a57c-1e38aebcaf2d")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.DebtorAgent"/>
    [IsoId("5e6ea478-eda5-4049-9f3d-a7a97f963476")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.DebtorAgentAccount"/>
    [IsoId("238bb9ed-2f2f-4d9c-995c-adcdf92eba3b")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.UltimateDebtor"/>
    [IsoId("f4767a69-5610-4f5c-99be-b2ba35a81b38")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.ChargeBearer"/>
    [IsoId("418c8d1d-41dd-420e-8d0b-2f908a80681d")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction48.CreditTransferTransaction"/>
    [IsoId("aeb80889-10be-4db8-8e6c-3fdaa46bbb2d")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    [MinLength(1)]
    public ValueList<CreditTransferTransaction74> CreditTransferTransaction { get; init; } = [];
}
