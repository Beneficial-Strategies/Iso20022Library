// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction91"/>
[IsoId("_aeRN84tvEee-OJ-wXSj3YQ")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction91
{
    /// <inheritdoc cref="IPaymentTransaction91.StatusIdentification"/>
    [IsoId("_amA0k4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.OriginalGroupInformation"/>
    [IsoId("_amA0lYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.OriginalInstructionIdentification"/>
    [IsoId("_amA0l4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.OriginalEndToEndIdentification"/>
    [IsoId("_amA0mYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.OriginalTransactionIdentification"/>
    [IsoId("_amA0m4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.TransactionStatus"/>
    [IsoId("_amA0nYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.StatusReasonInformation"/>
    [IsoId("_amA0n4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation11> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction91.ChargesInformation"/>
    [IsoId("_amA0oYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction91.AcceptanceDateTime"/>
    [IsoId("_amA0o4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.AccountServicerReference"/>
    [IsoId("_amA0pYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.ClearingSystemReference"/>
    [IsoId("_amA0p4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.InstructingAgent"/>
    [IsoId("_amA0qYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.InstructedAgent"/>
    [IsoId("_amA0q4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.OriginalTransactionReference"/>
    [IsoId("_amA0rYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference27? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction91.SupplementaryData"/>
    [IsoId("_amA0r4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
