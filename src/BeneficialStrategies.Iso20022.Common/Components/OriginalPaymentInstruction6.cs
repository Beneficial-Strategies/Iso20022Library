// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction6"/>
[IsoId("_yHpSMSHQEeKGep4bhmamiA")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction6
{
    /// <inheritdoc cref="IOriginalPaymentInstruction6.OriginalPaymentInformationIdentification"/>
    [IsoId("_yiwg9SHQEeKGep4bhmamiA")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction6.OriginalNumberOfTransactions"/>
    [IsoId("_yiwg-SHQEeKGep4bhmamiA")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction6.OriginalControlSum"/>
    [IsoId("_yiwg_SHQEeKGep4bhmamiA")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction6.PaymentInformationStatus"/>
    [IsoId("_yiwhASHQEeKGep4bhmamiA")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction6.StatusReasonInformation"/>
    [IsoId("_yiwhCSHQEeKGep4bhmamiA")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction6.NumberOfTransactionsPerStatus"/>
    [IsoId("_yiwhDSHQEeKGep4bhmamiA")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction6.TransactionInformationAndStatus"/>
    [IsoId("_yiwhESHQEeKGep4bhmamiA")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction46> TransactionInformationAndStatus { get; init; } = [];
}
