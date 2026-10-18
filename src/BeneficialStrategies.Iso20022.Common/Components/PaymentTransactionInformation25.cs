// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation25"/>
[IsoId("_P5BzcNp-Ed-ak6NoX_4Aeg_1053589613")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation25
{
    /// <inheritdoc cref="IPaymentTransactionInformation25.StatusIdentification"/>
    [IsoId("_P5LkUNp-Ed-ak6NoX_4Aeg_1053589644")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation25.OriginalInstructionIdentification"/>
    [IsoId("_P5LkUdp-Ed-ak6NoX_4Aeg_1053589766")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation25.OriginalEndToEndIdentification"/>
    [IsoId("_P5LkUtp-Ed-ak6NoX_4Aeg_1053589796")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation25.TransactionStatus"/>
    [IsoId("_P5LkU9p-Ed-ak6NoX_4Aeg_1053590136")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation25.StatusReasonInformation"/>
    [IsoId("_P5LkVNp-Ed-ak6NoX_4Aeg_1053590599")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation8> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation25.ChargesInformation"/>
    [IsoId("_P5LkVdp-Ed-ak6NoX_4Aeg_1166569149")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation5> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation25.AcceptanceDateTime"/>
    [IsoId("_P5LkVtp-Ed-ak6NoX_4Aeg_1053590166")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation25.AccountServicerReference"/>
    [IsoId("_P5LkV9p-Ed-ak6NoX_4Aeg_1297156607")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation25.ClearingSystemReference"/>
    [IsoId("_P5LkWNp-Ed-ak6NoX_4Aeg_1298082214")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation25.OriginalTransactionReference"/>
    [IsoId("_P5VVUNp-Ed-ak6NoX_4Aeg_1053590569")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
