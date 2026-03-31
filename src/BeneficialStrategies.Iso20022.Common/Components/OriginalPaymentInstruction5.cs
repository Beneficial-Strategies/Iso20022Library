// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_shbIo1kyEeGeoaLUQk__nA_518630129")]
[DisplayName("Original Payment Instruction")]
public record OriginalPaymentInstruction5
{
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_shk5oFkyEeGeoaLUQk__nA_-1174208106")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_shk5oVkyEeGeoaLUQk__nA_2082050462")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_shuDkFkyEeGeoaLUQk__nA_1625137288")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_shuDkVkyEeGeoaLUQk__nA_-255168352")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_sh30kFkyEeGeoaLUQk__nA_1527966601")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_siBlkFkyEeGeoaLUQk__nA_1910421709")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_siBlkVkyEeGeoaLUQk__nA_-966956284")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction41> TransactionInformationAndStatus { get; init; } = [];
}
