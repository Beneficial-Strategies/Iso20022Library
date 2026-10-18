// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction113"/>
[IsoId("_KvnIyXL_EeidQ_AAdEzxQA")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction113
{
    /// <inheritdoc cref="IPaymentTransaction113.StatusRequestIdentification"/>
    [IsoId("_K6MoI3L_EeidQ_AAdEzxQA")]
    [DisplayName("Status Request Identification")]
    [IsoXmlTag("StsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusRequestIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.OriginalGroupInformation"/>
    [IsoId("_K6MoJXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.OriginalInstructionIdentification"/>
    [IsoId("_K6MoJ3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.OriginalEndToEndIdentification"/>
    [IsoId("_K6MoKXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.OriginalTransactionIdentification"/>
    [IsoId("_K6MoK3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.OriginalUETR"/>
    [IsoId("_3vw4gXreEeidVZmeoasaWQ")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.AcceptanceDateTime"/>
    [IsoId("_K6MoLXL_EeidQ_AAdEzxQA")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.ClearingSystemReference"/>
    [IsoId("_K6MoL3L_EeidQ_AAdEzxQA")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.InstructingAgent"/>
    [IsoId("_K6MoMXL_EeidQ_AAdEzxQA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.InstructedAgent"/>
    [IsoId("_K6MoM3L_EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.OriginalTransactionReference"/>
    [IsoId("_K6MoNXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference28? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction113.SupplementaryData"/>
    [IsoId("_K6MoN3L_EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
