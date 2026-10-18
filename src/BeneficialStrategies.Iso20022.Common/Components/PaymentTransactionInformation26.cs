// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation26"/>
[IsoId("_P5oQSdp-Ed-ak6NoX_4Aeg_-269295301")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation26
{
    /// <inheritdoc cref="IPaymentTransactionInformation26.StatusIdentification"/>
    [IsoId("_P5oQStp-Ed-ak6NoX_4Aeg_-269295270")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.OriginalInstructionIdentification"/>
    [IsoId("_P5oQS9p-Ed-ak6NoX_4Aeg_-261910560")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.OriginalEndToEndIdentification"/>
    [IsoId("_P5oQTNp-Ed-ak6NoX_4Aeg_-261910498")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.OriginalTransactionIdentification"/>
    [IsoId("_P5oQTdp-Ed-ak6NoX_4Aeg_-261910437")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.TransactionStatus"/>
    [IsoId("_P5xaMNp-Ed-ak6NoX_4Aeg_-261910353")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.StatusReasonInformation"/>
    [IsoId("_P5xaMdp-Ed-ak6NoX_4Aeg_-261909581")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation8> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation26.ChargesInformation"/>
    [IsoId("_P5xaMtp-Ed-ak6NoX_4Aeg_-261909982")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation5> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation26.AcceptanceDateTime"/>
    [IsoId("_P5xaM9p-Ed-ak6NoX_4Aeg_-261910323")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.AccountServicerReference"/>
    [IsoId("_P5xaNNp-Ed-ak6NoX_4Aeg_-1019162263")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.ClearingSystemReference"/>
    [IsoId("_P5xaNdp-Ed-ak6NoX_4Aeg_-1019162233")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.InstructingAgent"/>
    [IsoId("_P5xaNtp-Ed-ak6NoX_4Aeg_-261909642")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.InstructedAgent"/>
    [IsoId("_P5xaN9p-Ed-ak6NoX_4Aeg_-261909952")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation26.OriginalTransactionReference"/>
    [IsoId("_P5xaONp-Ed-ak6NoX_4Aeg_-261910030")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
