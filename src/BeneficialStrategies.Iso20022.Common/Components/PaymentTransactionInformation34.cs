// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation34"/>
[IsoId("_URBuVdp-Ed-ak6NoX_4Aeg_1719157267")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation34
{
    /// <inheritdoc cref="IPaymentTransactionInformation34.StatusIdentification"/>
    [IsoId("_URBuVtp-Ed-ak6NoX_4Aeg_1416100752")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation34.OriginalInstructionIdentification"/>
    [IsoId("_URBuV9p-Ed-ak6NoX_4Aeg_399594878")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation34.OriginalEndToEndIdentification"/>
    [IsoId("_URBuWNp-Ed-ak6NoX_4Aeg_1854375869")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation34.TransactionStatus"/>
    [IsoId("_URK4QNp-Ed-ak6NoX_4Aeg_-1389458355")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation34.StatusReasonInformation"/>
    [IsoId("_URK4Qdp-Ed-ak6NoX_4Aeg_1239758624")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation34.ChargesInformation"/>
    [IsoId("_URK4Qtp-Ed-ak6NoX_4Aeg_1564876131")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation34.AcceptanceDateTime"/>
    [IsoId("_URK4Q9p-Ed-ak6NoX_4Aeg_799513829")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation34.AccountServicerReference"/>
    [IsoId("_URK4RNp-Ed-ak6NoX_4Aeg_-239194899")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation34.ClearingSystemReference"/>
    [IsoId("_URK4Rdp-Ed-ak6NoX_4Aeg_-874226745")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation34.OriginalTransactionReference"/>
    [IsoId("_URK4Rtp-Ed-ak6NoX_4Aeg_1672973906")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference15? OriginalTransactionReference { get; init; }
}
