// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInformation5"/>
[IsoId("_PezVcNp-Ed-ak6NoX_4Aeg_-1733791998")]
[DisplayName("Original Payment Information")]
public partial record OriginalPaymentInformation5
{
    /// <inheritdoc cref="IOriginalPaymentInformation5.OriginalPaymentInformationIdentification"/>
    [IsoId("_PezVcdp-Ed-ak6NoX_4Aeg_270359479")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation5.OriginalNumberOfTransactions"/>
    [IsoId("_PezVctp-Ed-ak6NoX_4Aeg_259260702")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation5.OriginalControlSum"/>
    [IsoId("_PezVc9p-Ed-ak6NoX_4Aeg_1199413522")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation5.PaymentInformationStatus"/>
    [IsoId("_PezVdNp-Ed-ak6NoX_4Aeg_22953502")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation5.StatusReasonInformation"/>
    [IsoId("_PezVddp-Ed-ak6NoX_4Aeg_1477413669")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInformation5.NumberOfTransactionsPerStatus"/>
    [IsoId("_PezVdtp-Ed-ak6NoX_4Aeg_558768294")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInformation5.TransactionInformationAndStatus"/>
    [IsoId("_PezVd9p-Ed-ak6NoX_4Aeg_-476783969")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransactionInformation34> TransactionInformationAndStatus { get; init; } =
        [];
}
