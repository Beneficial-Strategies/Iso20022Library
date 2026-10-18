// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInformation1"/>
[IsoId("_PlNfeNp-Ed-ak6NoX_4Aeg_-724783751")]
[DisplayName("Original Payment Information")]
public partial record OriginalPaymentInformation1
{
    /// <inheritdoc cref="IOriginalPaymentInformation1.OriginalPaymentInformationIdentification"/>
    [IsoId("_PlNfedp-Ed-ak6NoX_4Aeg_-724783659")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation1.OriginalNumberOfTransactions"/>
    [IsoId("_PlNfetp-Ed-ak6NoX_4Aeg_-129112626")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation1.OriginalControlSum"/>
    [IsoId("_PlXQcNp-Ed-ak6NoX_4Aeg_-129112378")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation1.PaymentInformationStatus"/>
    [IsoId("_PlXQcdp-Ed-ak6NoX_4Aeg_-724783265")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation1.StatusReasonInformation"/>
    [IsoId("_PlXQctp-Ed-ak6NoX_4Aeg_-724782771")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation8> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInformation1.NumberOfTransactionsPerStatus"/>
    [IsoId("_PlXQc9p-Ed-ak6NoX_4Aeg_214439013")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInformation1.TransactionInformationAndStatus"/>
    [IsoId("_PlXQdNp-Ed-ak6NoX_4Aeg_1494108741")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransactionInformation25> TransactionInformationAndStatus { get; init; } =
        [];
}
