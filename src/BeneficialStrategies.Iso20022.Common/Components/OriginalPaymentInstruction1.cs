// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction1"/>
[IsoId("_sobvkFkyEeGeoaLUQk__nA_-413898569")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction1
{
    /// <inheritdoc cref="IOriginalPaymentInstruction1.OriginalPaymentInformationIdentification"/>
    [IsoId("_sobvkVkyEeGeoaLUQk__nA_-2107629744")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction1.OriginalNumberOfTransactions"/>
    [IsoId("_sobvklkyEeGeoaLUQk__nA_177380694")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction1.OriginalControlSum"/>
    [IsoId("_sobvk1kyEeGeoaLUQk__nA_704376637")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction1.PaymentInformationStatus"/>
    [IsoId("_sok5gFkyEeGeoaLUQk__nA_1116264519")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction1.StatusReasonInformation"/>
    [IsoId("_sok5gVkyEeGeoaLUQk__nA_1702211545")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction1.NumberOfTransactionsPerStatus"/>
    [IsoId("_sok5glkyEeGeoaLUQk__nA_323528602")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction1.TransactionInformationAndStatus"/>
    [IsoId("_souqgFkyEeGeoaLUQk__nA_1658379449")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction32> TransactionInformationAndStatus { get; init; } = [];
}
