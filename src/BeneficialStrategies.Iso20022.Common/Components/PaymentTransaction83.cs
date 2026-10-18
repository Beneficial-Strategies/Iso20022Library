// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction83"/>
[IsoId("_umrwMZRvEeazAtAtDSg0Nw")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction83
{
    /// <inheritdoc cref="IPaymentTransaction83.StatusIdentification"/>
    [IsoId("_uzCKI5RvEeazAtAtDSg0Nw")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction83.OriginalInstructionIdentification"/>
    [IsoId("_uzCKJZRvEeazAtAtDSg0Nw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction83.OriginalEndToEndIdentification"/>
    [IsoId("_uzCKJ5RvEeazAtAtDSg0Nw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction83.TransactionStatus"/>
    [IsoId("_uzCKKZRvEeazAtAtDSg0Nw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction83.StatusReasonInformation"/>
    [IsoId("_uzCKK5RvEeazAtAtDSg0Nw")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction83.ChargesInformation"/>
    [IsoId("_uzCKLZRvEeazAtAtDSg0Nw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction83.AcceptanceDateTime"/>
    [IsoId("_uzCKL5RvEeazAtAtDSg0Nw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction83.AccountServicerReference"/>
    [IsoId("_uzCKMZRvEeazAtAtDSg0Nw")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction83.ClearingSystemReference"/>
    [IsoId("_uzCKM5RvEeazAtAtDSg0Nw")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction83.OriginalTransactionReference"/>
    [IsoId("_uzCKNZRvEeazAtAtDSg0Nw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference26? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction83.SupplementaryData"/>
    [IsoId("_uzCKN5RvEeazAtAtDSg0Nw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
