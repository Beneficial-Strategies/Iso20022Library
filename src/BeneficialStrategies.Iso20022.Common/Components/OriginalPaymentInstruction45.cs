// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction45"/>
[IsoId("_N1HoYxlWEe2Do_UtrNmb2g")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction45
{
    /// <inheritdoc cref="IOriginalPaymentInstruction45.OriginalPaymentInformationIdentification"/>
    [IsoId("_OAJziRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction45.OriginalNumberOfTransactions"/>
    [IsoId("_OAJzixlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction45.OriginalControlSum"/>
    [IsoId("_OAJzjRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction45.PaymentInformationStatus"/>
    [IsoId("_OAJzjxlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction45.StatusReasonInformation"/>
    [IsoId("_OAJzkRlWEe2Do_UtrNmb2g")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction45.NumberOfTransactionsPerStatus"/>
    [IsoId("_OAJzkxlWEe2Do_UtrNmb2g")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction45.TransactionInformationAndStatus"/>
    [IsoId("_OAJzlRlWEe2Do_UtrNmb2g")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction144> TransactionInformationAndStatus { get; init; } = [];
}
