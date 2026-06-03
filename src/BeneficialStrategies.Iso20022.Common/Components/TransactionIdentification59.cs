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
[IsoId("_3uzC8WPuEfCX7uJiAWHfoQ")]
[DisplayName("Transaction Identification59")]
public record TransactionIdentification59
{
    [IsoId("_3yOxcWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Local Date")]
    [IsoXmlTag("LclDt")]
    public required IsoISODate LocalDate { get; init; }

    [IsoId("_3yOxhWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Local Time")]
    [IsoXmlTag("LclTm")]
    public IsoISOTime? LocalTime { get; init; }

    [IsoId("_3yOxmWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public IsoMax70Text? TimeZone { get; init; }

    [IsoId("_3yOxm2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType3Code? PurchaseIdentifierType { get; init; }

    [IsoId("_3yOxn2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    [IsoId("_3yOxoWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public IsoISODateTime? TransmissionDateTime { get; init; }

    [IsoId("_3yOxqWPuEfCX7uJiAWHfoQ")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; }

    [IsoId("_3yOxsWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    [IsoId("_3yOxuWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Support")]
    [IsoXmlTag("LifeCyclSpprt")]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; }

    [IsoId("_3yOxu2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoExact15Text? LifeCycleIdentification { get; init; }

    [IsoId("_3yOxw2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Authorisation Sequence Number")]
    [IsoXmlTag("AuthstnSeqNb")]
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; }

    [IsoId("_3yOxy2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Presentment Sequence Number")]
    [IsoXmlTag("PresntmntSeqNb")]
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; }

    [IsoId("_3yOx02PuEfCX7uJiAWHfoQ")]
    [DisplayName("Presentment Sequence Count")]
    [IsoXmlTag("PresntmntSeqCnt")]
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; }

    [IsoId("_3yOx1WPuEfCX7uJiAWHfoQ")]
    [DisplayName("Authentication Token")]
    [IsoXmlTag("AuthntcnTkn")]
    public IsoMax35Text? AuthenticationToken { get; init; }

    [IsoId("_3yOx3WPuEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Identification Missing")]
    [IsoXmlTag("LifeCyclIdMssng")]
    public IsoMax70Text? LifeCycleIdentificationMissing { get; init; }

    [IsoId("_3yOx32PuEfCX7uJiAWHfoQ")]
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    public IsoMax140Text? AcquirerReferenceData { get; init; }

    [IsoId("_3yOx52PuEfCX7uJiAWHfoQ")]
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; }

    [IsoId("_3yOx72PuEfCX7uJiAWHfoQ")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax1000Text? IssuerReferenceData { get; init; }

    [IsoId("_3yOx92PuEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data")]
    [IsoXmlTag("AssoctdData")]
    public IsoTrueFalseIndicator? AssociatedData { get; init; }

    [IsoId("_3yOx-WPuEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    [IsoId("_3yOx-2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    [IsoId("_7rVxAWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_7rVxAmPuEfCX7uJiAWHfoQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
