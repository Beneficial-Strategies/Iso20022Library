// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction59"/>
[IsoId("__-Qw2VkJEeSeLKjZh_lWZw")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction59
{
    /// <inheritdoc cref="IPaymentTransaction59.StatusIdentification"/>
    [IsoId("_AYcLU1kKEeSeLKjZh_lWZw")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction59.OriginalInstructionIdentification"/>
    [IsoId("_AYcLVVkKEeSeLKjZh_lWZw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction59.OriginalEndToEndIdentification"/>
    [IsoId("_AYcLV1kKEeSeLKjZh_lWZw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction59.TransactionStatus"/>
    [IsoId("_AYcLWVkKEeSeLKjZh_lWZw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction59.StatusReasonInformation"/>
    [IsoId("_AYcLW1kKEeSeLKjZh_lWZw")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction59.ChargesInformation"/>
    [IsoId("_AYcLXVkKEeSeLKjZh_lWZw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction59.AcceptanceDateTime"/>
    [IsoId("_AYcLX1kKEeSeLKjZh_lWZw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction59.AccountServicerReference"/>
    [IsoId("_AYcLYVkKEeSeLKjZh_lWZw")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction59.ClearingSystemReference"/>
    [IsoId("_AYcLY1kKEeSeLKjZh_lWZw")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction59.OriginalTransactionReference"/>
    [IsoId("_AYcLZVkKEeSeLKjZh_lWZw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference21? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction59.SupplementaryData"/>
    [IsoId("_AYcLZ1kKEeSeLKjZh_lWZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
