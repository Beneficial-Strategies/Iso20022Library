// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction94"/>
[IsoId("_8uy-0bPfEeeppqgHuc69jg")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction94
{
    /// <inheritdoc cref="IPaymentTransaction94.StatusRequestIdentification"/>
    [IsoId("_83bWY7PfEeeppqgHuc69jg")]
    [DisplayName("Status Request Identification")]
    [IsoXmlTag("StsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusRequestIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.OriginalGroupInformation"/>
    [IsoId("_83bWZbPfEeeppqgHuc69jg")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.OriginalInstructionIdentification"/>
    [IsoId("_83bWZ7PfEeeppqgHuc69jg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.OriginalEndToEndIdentification"/>
    [IsoId("_83bWabPfEeeppqgHuc69jg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.OriginalTransactionIdentification"/>
    [IsoId("_83bWa7PfEeeppqgHuc69jg")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.AcceptanceDateTime"/>
    [IsoId("_83bWbbPfEeeppqgHuc69jg")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.ClearingSystemReference"/>
    [IsoId("_83bWb7PfEeeppqgHuc69jg")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.InstructingAgent"/>
    [IsoId("_83bWcbPfEeeppqgHuc69jg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.InstructedAgent"/>
    [IsoId("_83bWc7PfEeeppqgHuc69jg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.OriginalTransactionReference"/>
    [IsoId("_83bWdbPfEeeppqgHuc69jg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference27? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction94.SupplementaryData"/>
    [IsoId("_83bWd7PfEeeppqgHuc69jg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
