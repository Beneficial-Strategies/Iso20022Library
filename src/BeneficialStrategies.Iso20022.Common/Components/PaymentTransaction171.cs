// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction171"/>
[IsoId("8f5f6e58-5f38-4c81-985e-27a4edf16d5a")]
[DisplayName("Payment Transaction171")]
public partial record PaymentTransaction171
{
    /// <inheritdoc cref="IPaymentTransaction171.StatusRequestIdentification"/>
    [IsoId("92d96915-2e3a-4ab5-9130-92e1d1401109")]
    [DisplayName("Status Request Identification")]
    [IsoXmlTag("StsReqId")]
    public IsoMax35Text? StatusRequestIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.OriginalGroupInformation"/>
    [IsoId("7ebae343-b1e1-4282-9422-69ccf7994ad5")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation33? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.OriginalInstructionIdentification"/>
    [IsoId("5dbbd40c-8bdb-4c16-abb1-e5215c87164a")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.OriginalEndToEndIdentification"/>
    [IsoId("610dd1b6-931c-4867-af05-9dbb71755f7a")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.OriginalTransactionIdentification"/>
    [IsoId("8a523ac3-778a-4857-a07d-e659d0bf06ae")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.OriginalUETR"/>
    [IsoId("a66b61df-268a-4c50-bb01-4a6e3f0447ce")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.AcceptanceDateTime"/>
    [IsoId("c8227be5-d09b-4f0e-824d-a95ab72e73de")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.ClearingSystemReference"/>
    [IsoId("e608b458-763a-45bf-b35f-32d729979bb7")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.InstructingAgent"/>
    [IsoId("a6917c43-d533-4fb1-ad70-1a1a6b08cb70")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.InstructedAgent"/>
    [IsoId("d6529ce8-dc5b-4a21-a311-3e3b8d36243b")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.OriginalTransactionReference"/>
    [IsoId("ac62a849-873b-49a7-897a-028862fb572a")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference47? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction171.SupplementaryData"/>
    [IsoId("a0c30313-1d0a-44b1-b8e9-8c07859c02a2")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
