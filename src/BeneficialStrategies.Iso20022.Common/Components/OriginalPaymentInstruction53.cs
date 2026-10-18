// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction53"/>
[IsoId("223270f6-eaaf-4b72-8b14-f17478370b64")]
[DisplayName("Original Payment Instruction53")]
public partial record OriginalPaymentInstruction53
{
    /// <inheritdoc cref="IOriginalPaymentInstruction53.ReversalPaymentInformationIdentification"/>
    [IsoId("f484484e-53ec-468f-b808-306f85c7393f")]
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    public IsoMax35Text? ReversalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction53.OriginalPaymentInformationIdentification"/>
    [IsoId("7f16fa26-9dd4-4a7a-921b-46457b526500")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction53.OriginalNumberOfTransactions"/>
    [IsoId("9aad0f9f-3d0c-4e8c-b154-0e74f36e5e6d")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction53.OriginalControlSum"/>
    [IsoId("6698d0c9-cf73-4004-ae55-7e503dcd27e2")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction53.BatchBooking"/>
    [IsoId("e9a675f9-ac1c-4139-8971-48de70bf6bb5")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction53.PaymentInformationReversal"/>
    [IsoId("623d1499-f176-491f-ab85-a34407efe22e")]
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    public IsoTrueFalseIndicator? PaymentInformationReversal { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction53.ReversalReasonInformation"/>
    [IsoId("5c551b2c-0dde-478e-9822-6845eff732de")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason10> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction53.TransactionInformation"/>
    [IsoId("a0b2f52d-42ab-44ee-8f65-01e66caff5b3")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction174> TransactionInformation { get; init; } = [];
}
