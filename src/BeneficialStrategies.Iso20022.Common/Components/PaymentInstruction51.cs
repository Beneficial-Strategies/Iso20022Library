// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction51"/>
[IsoId("a376f506-35bc-4f88-9925-eceabe35beea")]
[DisplayName("Payment Instruction51")]
public partial record PaymentInstruction51
{
    /// <inheritdoc cref="IPaymentInstruction51.PaymentInformationIdentification"/>
    [IsoId("dfeb6565-c0a1-4f42-98be-7280338a0602")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.PaymentMethod"/>
    [IsoId("25277459-8fd6-4b15-9818-eb4466437d8e")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.RequestedAdviceType"/>
    [IsoId("792e197b-8059-4633-822e-c2e08e2c9eab")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.BatchBooking"/>
    [IsoId("0dcd68c1-4680-4ea8-979f-db22db1ea892")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.NumberOfTransactions"/>
    [IsoId("5bb724bf-3b06-4052-abd4-6bbd3bc3c929")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.ControlSum"/>
    [IsoId("9ea5345e-08d4-42ac-8ba6-19b791caf194")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.PaymentTypeInformation"/>
    [IsoId("5702cc97-50ec-42e4-a6a0-e7990c68e96b")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.RequestedExecutionDate"/>
    [IsoId("fabfdc67-f1b0-4093-9749-ae4a9a37d218")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.PoolingAdjustmentDate"/>
    [IsoId("7f3ee28b-3e13-410c-ae42-32bf1a03e034")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.Debtor"/>
    [IsoId("8cbc1d76-4752-4b60-ad06-cf654d5ed8c4")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.DebtorAccount"/>
    [IsoId("77c33575-9d67-40bf-91c0-444673414068")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount40 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.DebtorAgent"/>
    [IsoId("9519236d-4e5b-43c9-ba39-5350f6c5b21b")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.DebtorAgentAccount"/>
    [IsoId("e1b92d70-b384-4ab7-a835-41fb9e651750")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.InstructionForDebtorAgent"/>
    [IsoId("7741a44b-38b8-4773-8179-da314dc13e6c")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.UltimateDebtor"/>
    [IsoId("df870f37-ef4b-4f2b-9460-eed769150513")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.ChargeBearer"/>
    [IsoId("195dd6c9-842b-4fbc-8e9f-ce671def233c")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.ChargesAccount"/>
    [IsoId("96a6d108-ae5c-49fc-9583-f4a1df602599")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount40? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.ChargesAccountAgent"/>
    [IsoId("3d017737-58db-4aa5-8b3f-001b8c73293b")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification8? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction51.CreditTransferTransactionInformation"/>
    [IsoId("efdc5154-cbfe-46ef-a00b-941804dc87a5")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    [MinLength(1)]
    public ValueList<CreditTransferTransaction76> CreditTransferTransactionInformation { get; init; } = [];
}
