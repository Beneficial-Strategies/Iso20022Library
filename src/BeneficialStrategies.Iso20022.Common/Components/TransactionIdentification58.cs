// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the transaction.
/// </summary>
[IsoId("_715D4SHyEfCkq6-p7S3J1Q")]
[DisplayName("Transaction Identification58")]
public record TransactionIdentification58
{
    [IsoId("_74aMYSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Local Date")]
    [IsoXmlTag("LclDt")]
    public IsoISODate? LocalDate { get; init; }

    [IsoId("_74aMdSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Local Time")]
    [IsoXmlTag("LclTm")]
    public IsoISOTime? LocalTime { get; init; }

    [IsoId("_74aMiSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public IsoMax70Text? TimeZone { get; init; }

    [IsoId("_74aMiyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType3Code? PurchaseIdentifierType { get; init; }

    [IsoId("_74aMjyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    [IsoId("_74aMkSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public IsoISODateTime? TransmissionDateTime { get; init; }

    [IsoId("_74aMmSHyEfCkq6-p7S3J1Q")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; }

    [IsoId("_74aMoSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    [IsoId("_74aMqSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Life Cycle Support")]
    [IsoXmlTag("LifeCyclSpprt")]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; }

    [IsoId("_74aMqyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoMax36Text? LifeCycleIdentification { get; init; }

    [IsoId("_lBiF1CHzEfCkq6-p7S3J1Q")]
    [DisplayName("Associated Transaction Life Cycle Identification")]
    [IsoXmlTag("AssoctdTxLifeCyclId")]
    public IsoMax36Text? AssociatedTransactionLifeCycleIdentification { get; init; }

    [IsoId("_TDHjBCH0EfCkq6-p7S3J1Q")]
    [DisplayName("Life Cycle Identification Validation")]
    [IsoXmlTag("LifeCyclIdVldtn")]
    public IsoMax37Text? LifeCycleIdentificationValidation { get; init; }

    [IsoId("_74aMsyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Authorisation Sequence Number")]
    [IsoXmlTag("AuthstnSeqNb")]
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; }

    [IsoId("_74aMuyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Presentment Sequence Number")]
    [IsoXmlTag("PresntmntSeqNb")]
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; }

    [IsoId("_74aMwyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Presentment Sequence Count")]
    [IsoXmlTag("PresntmntSeqCnt")]
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; }

    [IsoId("_74aMxSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Authentication Token")]
    [IsoXmlTag("AuthntcnTkn")]
    public IsoMax36Text? AuthenticationToken { get; init; }

    [IsoId("_74aMzSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Life Cycle Identification Missing")]
    [IsoXmlTag("LifeCyclIdMssng")]
    public IsoMax70Text? LifeCycleIdentificationMissing { get; init; }

    [IsoId("_74aMzyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    public IsoMax140Text? AcquirerReferenceData { get; init; }

    [IsoId("_74aM1yHyEfCkq6-p7S3J1Q")]
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; }

    [IsoId("_74aM3yHyEfCkq6-p7S3J1Q")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax1000Text? IssuerReferenceData { get; init; }

    [IsoId("_74aM5yHyEfCkq6-p7S3J1Q")]
    [DisplayName("Associated Data")]
    [IsoXmlTag("AssoctdData")]
    public IsoTrueFalseIndicator? AssociatedData { get; init; }

    [IsoId("_74aM6SHyEfCkq6-p7S3J1Q")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    [IsoId("_74aM6yHyEfCkq6-p7S3J1Q")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    [IsoId("_XsFLUkVYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_XsFLU0VYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
