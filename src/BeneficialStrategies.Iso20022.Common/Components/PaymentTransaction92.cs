// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction92"/>
[IsoId("_je-gebPfEeeppqgHuc69jg")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction92
{
    /// <inheritdoc cref="IPaymentTransaction92.StatusIdentification"/>
    [IsoId("_jnKMA7PfEeeppqgHuc69jg")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction92.OriginalInstructionIdentification"/>
    [IsoId("_jnKMBbPfEeeppqgHuc69jg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction92.OriginalEndToEndIdentification"/>
    [IsoId("_jnKMB7PfEeeppqgHuc69jg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction92.TransactionStatus"/>
    [IsoId("_jnKMCbPfEeeppqgHuc69jg")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction92.StatusReasonInformation"/>
    [IsoId("_jnKMC7PfEeeppqgHuc69jg")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation11> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction92.ChargesInformation"/>
    [IsoId("_jnKMDbPfEeeppqgHuc69jg")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction92.AcceptanceDateTime"/>
    [IsoId("_jnKMD7PfEeeppqgHuc69jg")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction92.AccountServicerReference"/>
    [IsoId("_jnKMEbPfEeeppqgHuc69jg")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction92.ClearingSystemReference"/>
    [IsoId("_jnKME7PfEeeppqgHuc69jg")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction92.OriginalTransactionReference"/>
    [IsoId("_jnKMFbPfEeeppqgHuc69jg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference27? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction92.SupplementaryData"/>
    [IsoId("_jnKMF7PfEeeppqgHuc69jg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
