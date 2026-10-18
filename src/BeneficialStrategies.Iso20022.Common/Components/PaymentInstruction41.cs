// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction41"/>
[IsoId("_faapUdcZEeqRFcf2R4bPBw")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction41
{
    /// <inheritdoc cref="IPaymentInstruction41.PaymentInformationIdentification"/>
    [IsoId("_fb4B9dcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.PaymentMethod"/>
    [IsoId("_fb4B99cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.RequestedAdviceType"/>
    [IsoId("_fb4B-dcZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.PaymentTypeInformation"/>
    [IsoId("_fb4B-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.RequestedExecutionDate"/>
    [IsoId("_fb4B_dcZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.ExpiryDate"/>
    [IsoId("_fb4B_9cZEeqRFcf2R4bPBw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.PaymentCondition"/>
    [IsoId("_fb4CAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.Debtor"/>
    [IsoId("_fb4CA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.DebtorAccount"/>
    [IsoId("_fb4CBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.DebtorAgent"/>
    [IsoId("_fb4CB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.UltimateDebtor"/>
    [IsoId("_fb4CCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.ChargeBearer"/>
    [IsoId("_fb4CC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction41.CreditTransferTransaction"/>
    [IsoId("_fb4CDdcZEeqRFcf2R4bPBw")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransaction55> CreditTransferTransaction { get; init; } = [];
    // ID for the above is _fb4CDdcZEeqRFcf2R4bPBw
}
