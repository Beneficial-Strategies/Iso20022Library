// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction104"/>
[IsoId("_FD25W249EeiU9cctagi5ow")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction104
{
    /// <inheritdoc cref="IPaymentTransaction104.StatusIdentification"/>
    [IsoId("_FPLYg249EeiU9cctagi5ow")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.OriginalInstructionIdentification"/>
    [IsoId("_FPLYhW49EeiU9cctagi5ow")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.OriginalEndToEndIdentification"/>
    [IsoId("_FPLYh249EeiU9cctagi5ow")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.OriginalUETR"/>
    [IsoId("_Po-wYXrfEeidVZmeoasaWQ")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.TransactionStatus"/>
    [IsoId("_FPLYiW49EeiU9cctagi5ow")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.StatusReasonInformation"/>
    [IsoId("_FPLYi249EeiU9cctagi5ow")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction104.PaymentConditionStatus"/>
    [IsoId("_jN_J4Ij9Eei-69PNFxn_Ew")]
    [DisplayName("Payment Condition Status")]
    [IsoXmlTag("PmtCondSts")]
    public PaymentConditionStatus1? PaymentConditionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.ChargesInformation"/>
    [IsoId("_FPLYjW49EeiU9cctagi5ow")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction104.DebtorDecisionDateTime"/>
    [IsoId("_kf-tAbsgEeitsqbFo3Krzg")]
    [DisplayName("Debtor Decision Date Time")]
    [IsoXmlTag("DbtrDcsnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DebtorDecisionDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.AcceptanceDateTime"/>
    [IsoId("_FPLYj249EeiU9cctagi5ow")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.AccountServicerReference"/>
    [IsoId("_FPLYkW49EeiU9cctagi5ow")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.ClearingSystemReference"/>
    [IsoId("_FPLYk249EeiU9cctagi5ow")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.OriginalTransactionReference"/>
    [IsoId("_FPLYlW49EeiU9cctagi5ow")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference29? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction104.EnclosedFile"/>
    [IsoId("_M7eccYEuEei07cRuIM8cTA")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction104.SupplementaryData"/>
    [IsoId("_FPLYl249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
