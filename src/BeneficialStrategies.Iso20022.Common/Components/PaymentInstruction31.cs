// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction31"/>
[IsoId("_VTxdgW49EeiU9cctagi5ow")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction31
{
    /// <inheritdoc cref="IPaymentInstruction31.PaymentInformationIdentification"/>
    [IsoId("_Vf_Up249EeiU9cctagi5ow")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.PaymentMethod"/>
    [IsoId("_Vf_UqW49EeiU9cctagi5ow")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.PaymentTypeInformation"/>
    [IsoId("_Vf_Uq249EeiU9cctagi5ow")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.RequestedExecutionDate"/>
    [IsoId("_Vf_UrW49EeiU9cctagi5ow")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.ExpiryDate"/>
    [IsoId("_1UTbQLsfEeitsqbFo3Krzg")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.PaymentCondition"/>
    [IsoId("_qXN0MHVmEeiEU7thYTAN1w")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.Debtor"/>
    [IsoId("_Vf_Ur249EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.DebtorAccount"/>
    [IsoId("_Vf_UsW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.DebtorAgent"/>
    [IsoId("_Vf_Us249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.UltimateDebtor"/>
    [IsoId("_Vf_UtW49EeiU9cctagi5ow")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.ChargeBearer"/>
    [IsoId("_Vf_Ut249EeiU9cctagi5ow")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction31.CreditTransferTransaction"/>
    [IsoId("_Vf_UuW49EeiU9cctagi5ow")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransaction35> CreditTransferTransaction { get; init; } = [];
    // ID for the above is _Vf_UuW49EeiU9cctagi5ow
}
