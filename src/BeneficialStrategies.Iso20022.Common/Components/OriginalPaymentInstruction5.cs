// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction5"/>
[IsoId("_shbIo1kyEeGeoaLUQk__nA_518630129")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction5
{
    /// <inheritdoc cref="IOriginalPaymentInstruction5.OriginalPaymentInformationIdentification"/>
    [IsoId("_shk5oFkyEeGeoaLUQk__nA_-1174208106")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction5.OriginalNumberOfTransactions"/>
    [IsoId("_shk5oVkyEeGeoaLUQk__nA_2082050462")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction5.OriginalControlSum"/>
    [IsoId("_shuDkFkyEeGeoaLUQk__nA_1625137288")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction5.PaymentInformationStatus"/>
    [IsoId("_shuDkVkyEeGeoaLUQk__nA_-255168352")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction5.StatusReasonInformation"/>
    [IsoId("_sh30kFkyEeGeoaLUQk__nA_1527966601")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction5.NumberOfTransactionsPerStatus"/>
    [IsoId("_siBlkFkyEeGeoaLUQk__nA_1910421709")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction5.TransactionInformationAndStatus"/>
    [IsoId("_siBlkVkyEeGeoaLUQk__nA_-966956284")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction41> TransactionInformationAndStatus { get; init; } = [];
}
