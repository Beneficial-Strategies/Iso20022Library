// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the transaction for network management.
/// </summary>
[IsoId("_DKplwWPwEfCX7uJiAWHfoQ")]
[DisplayName("Transaction Identification60")]
public record TransactionIdentification60
{
    [IsoId("_DNEnoWPwEfCX7uJiAWHfoQ")]
    [DisplayName("Local Date")]
    [IsoXmlTag("LclDt")]
    public IsoISODate? LocalDate { get; init; }

    [IsoId("_DNEntWPwEfCX7uJiAWHfoQ")]
    [DisplayName("Local Time")]
    [IsoXmlTag("LclTm")]
    public IsoISOTime? LocalTime { get; init; }

    [IsoId("_DNEnyWPwEfCX7uJiAWHfoQ")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public IsoMax70Text? TimeZone { get; init; }

    [IsoId("_DNEny2PwEfCX7uJiAWHfoQ")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType3Code? PurchaseIdentifierType { get; init; }

    [IsoId("_DNEnz2PwEfCX7uJiAWHfoQ")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    [IsoId("_DNEn0WPwEfCX7uJiAWHfoQ")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public IsoISODateTime? TransmissionDateTime { get; init; }

    [IsoId("_DNEn2WPwEfCX7uJiAWHfoQ")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; }

    [IsoId("_DNEn4WPwEfCX7uJiAWHfoQ")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    [IsoId("_DNEn6WPwEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Support")]
    [IsoXmlTag("LifeCyclSpprt")]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; }

    [IsoId("_DNEn62PwEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoExact15Text? LifeCycleIdentification { get; init; }

    [IsoId("_DNEn82PwEfCX7uJiAWHfoQ")]
    [DisplayName("Authorisation Sequence Number")]
    [IsoXmlTag("AuthstnSeqNb")]
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; }

    [IsoId("_DNEn-2PwEfCX7uJiAWHfoQ")]
    [DisplayName("Presentment Sequence Number")]
    [IsoXmlTag("PresntmntSeqNb")]
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; }

    [IsoId("_DNEoA2PwEfCX7uJiAWHfoQ")]
    [DisplayName("Presentment Sequence Count")]
    [IsoXmlTag("PresntmntSeqCnt")]
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; }

    [IsoId("_DNEoBWPwEfCX7uJiAWHfoQ")]
    [DisplayName("Authentication Token")]
    [IsoXmlTag("AuthntcnTkn")]
    public IsoMax35Text? AuthenticationToken { get; init; }

    [IsoId("_DNEoDWPwEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Identification Missing")]
    [IsoXmlTag("LifeCyclIdMssng")]
    public IsoMax70Text? LifeCycleIdentificationMissing { get; init; }

    [IsoId("_DNEoD2PwEfCX7uJiAWHfoQ")]
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    public IsoMax140Text? AcquirerReferenceData { get; init; }

    [IsoId("_DNEoF2PwEfCX7uJiAWHfoQ")]
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; }

    [IsoId("_DNEoH2PwEfCX7uJiAWHfoQ")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax1000Text? IssuerReferenceData { get; init; }

    [IsoId("_F9gu8mPwEfCX7uJiAWHfoQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_F9gu82PwEfCX7uJiAWHfoQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
