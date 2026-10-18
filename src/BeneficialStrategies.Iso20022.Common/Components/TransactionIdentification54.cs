// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Identification54.
/// </summary>
[IsoId("_quHvEYJCEe6dZ_jHhjXHQg")]
[DisplayName("Transaction Identification54")]
public record TransactionIdentification54
{
    /// <summary>
    /// Local Date.
    /// </summary>
    [DisplayName("Local Date")]
    [IsoXmlTag("LclDt")]
    public ISODate? LocalDate { get; init; }

    /// <summary>
    /// Local Time.
    /// </summary>
    [DisplayName("Local Time")]
    [IsoXmlTag("LclTm")]
    public ISOTime? LocalTime { get; init; }

    /// <summary>
    /// Time Zone.
    /// </summary>
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public Max70Text? TimeZone { get; init; }

    /// <summary>
    /// Purchase Identifier Type.
    /// </summary>
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType2Code? PurchaseIdentifierType { get; init; }

    /// <summary>
    /// Other Purchase Identifier Type.
    /// </summary>
    [DisplayName("Other Purchase Identifier Type")]
    [IsoXmlTag("OthrPurchsIdrTp")]
    public Max35Text? OtherPurchaseIdentifierType { get; init; }

    /// <summary>
    /// Purchase Identifier.
    /// </summary>
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public Max99Text? PurchaseIdentifier { get; init; }

    /// <summary>
    /// Transmission Date Time.
    /// </summary>
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public ISODateTime? TransmissionDateTime { get; init; }

    /// <summary>
    /// System Trace Audit Number.
    /// </summary>
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public required Max12NumericText SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Retrieval Reference Number.
    /// </summary>
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public required Exact12Text RetrievalReferenceNumber { get; init; }

    /// <summary>
    /// Life Cycle Support.
    /// </summary>
    [DisplayName("Life Cycle Support")]
    [IsoXmlTag("LifeCyclSpprt")]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; }

    /// <summary>
    /// Life Cycle Identification.
    /// </summary>
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public Exact15Text? LifeCycleIdentification { get; init; }

    /// <summary>
    /// Authorisation Sequence Number.
    /// </summary>
    [DisplayName("Authorisation Sequence Number")]
    [IsoXmlTag("AuthstnSeqNb")]
    public Exact2NumericText? AuthorisationSequenceNumber { get; init; }

    /// <summary>
    /// Presentment Sequence Number.
    /// </summary>
    [DisplayName("Presentment Sequence Number")]
    [IsoXmlTag("PresntmntSeqNb")]
    public Exact2NumericText? PresentmentSequenceNumber { get; init; }

    /// <summary>
    /// Presentment Sequence Count.
    /// </summary>
    [DisplayName("Presentment Sequence Count")]
    [IsoXmlTag("PresntmntSeqCnt")]
    public Exact2NumericText? PresentmentSequenceCount { get; init; }

    /// <summary>
    /// Authentication Token.
    /// </summary>
    [DisplayName("Authentication Token")]
    [IsoXmlTag("AuthntcnTkn")]
    public Max35Text? AuthenticationToken { get; init; }

    /// <summary>
    /// Life Cycle Identification Missing.
    /// </summary>
    [DisplayName("Life Cycle Identification Missing")]
    [IsoXmlTag("LifeCyclIdMssng")]
    public Max70Text? LifeCycleIdentificationMissing { get; init; }

    /// <summary>
    /// Acquirer Reference Data.
    /// </summary>
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    public Max140Text? AcquirerReferenceData { get; init; }

    /// <summary>
    /// Acquirer Reference Number.
    /// </summary>
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    public Max23NumericText? AcquirerReferenceNumber { get; init; }

    /// <summary>
    /// Issuer Reference Data.
    /// </summary>
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public Max1000Text? IssuerReferenceData { get; init; }
}
