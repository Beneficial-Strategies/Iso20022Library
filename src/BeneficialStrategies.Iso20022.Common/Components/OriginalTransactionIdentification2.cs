// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the original transaction.
/// </summary>
[IsoId("_BEtQ4WvbEfCyxsm1jzUNug")]
[DisplayName("Original Transaction Identification2")]
public record OriginalTransactionIdentification2
{
    /// <summary>
    /// Local date the transaction takes place at the card acceptor location.
    /// </summary>
    [IsoId("_BI3YIWvbEfCyxsm1jzUNug")]
    [DisplayName("Local Date")]
    [IsoXmlTag("LclDt")]
    public IsoISODate? LocalDate { get; init; }

    /// <summary>
    /// Local time the transaction takes place at the card acceptor location.
    /// </summary>
    [IsoId("_BI3YNWvbEfCyxsm1jzUNug")]
    [DisplayName("Local Time")]
    [IsoXmlTag("LclTm")]
    public IsoISOTime? LocalTime { get; init; }

    /// <summary>
    /// Time zone name (for example, as defined by IANA in the time zone database).
    /// </summary>
    [IsoId("_BI3YSWvbEfCyxsm1jzUNug")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public IsoMax70Text? TimeZone { get; init; }

    /// <summary>
    /// Specifies the type of identifier present in the message.
    /// </summary>
    [IsoId("_BI3YS2vbEfCyxsm1jzUNug")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType3Code? PurchaseIdentifierType { get; init; }

    /// <summary>
    /// Contains a value identifying Invoice Data or Purchase Request Data.
    /// </summary>
    [IsoId("_BI3YT2vbEfCyxsm1jzUNug")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// </summary>
    [IsoId("_BI3YUWvbEfCyxsm1jzUNug")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public IsoISODateTime? TransmissionDateTime { get; init; }

    /// <summary>
    /// Number assigned by a transaction originator to assist in identifying a transaction uniquely.
    /// </summary>
    [IsoId("_BI3YWWvbEfCyxsm1jzUNug")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public IsoMax12NumericText? SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// </summary>
    [IsoId("_BI3YYWvbEfCyxsm1jzUNug")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    [IsoId("_BI3YaWvbEfCyxsm1jzUNug")]
    [DisplayName("Life Cycle Support")]
    [IsoXmlTag("LifeCyclSpprt")]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; }

    /// <summary>
    /// Transaction lifecycle identification.
    /// </summary>
    [IsoId("_BI3Ya2vbEfCyxsm1jzUNug")]
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoExact15Text? LifeCycleIdentification { get; init; }

    /// <summary>
    /// Contains authorisation sequence number.
    /// </summary>
    [IsoId("_BI3Yc2vbEfCyxsm1jzUNug")]
    [DisplayName("Authorisation Sequence Number")]
    [IsoXmlTag("AuthstnSeqNb")]
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; }

    /// <summary>
    /// Number used with trace identifier to uniquely identify where a single authorisation was obtained covering a number of financial presentments.
    /// </summary>
    [IsoId("_BI3Ye2vbEfCyxsm1jzUNug")]
    [DisplayName("Presentment Sequence Number")]
    [IsoXmlTag("PresntmntSeqNb")]
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; }

    /// <summary>
    /// Expected maximum number of presentments for this transaction.
    /// </summary>
    [IsoId("_BI3Yg2vbEfCyxsm1jzUNug")]
    [DisplayName("Presentment Sequence Count")]
    [IsoXmlTag("PresntmntSeqCnt")]
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; }

    /// <summary>
    /// Code calculated using an algorithm against key transaction data elements that are common to both authorisation and financial messages.
    /// </summary>
    [IsoId("_BI3YhWvbEfCyxsm1jzUNug")]
    [DisplayName("Authentication Token")]
    [IsoXmlTag("AuthntcnTkn")]
    public IsoMax35Text? AuthenticationToken { get; init; }

    /// <summary>
    /// Reason for not providing a lifecycle trace identification information.
    /// </summary>
    [IsoId("_BI3YjWvbEfCyxsm1jzUNug")]
    [DisplayName("Life Cycle Identification Missing")]
    [IsoXmlTag("LifeCyclIdMssng")]
    public IsoMax70Text? LifeCycleIdentificationMissing { get; init; }

    /// <summary>
    /// Data supplied by an acquirer in an authorisation or financial request, advice or notification that may be required to be provided in a subsequent transaction.
    /// </summary>
    [IsoId("_BI3Yj2vbEfCyxsm1jzUNug")]
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    public IsoMax140Text? AcquirerReferenceData { get; init; }

    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction.
    /// </summary>
    [IsoId("_BI3Yl2vbEfCyxsm1jzUNug")]
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; }

    /// <summary>
    /// Data supplied by a card issuer in an authorisation response, financial response message or in a chargeback transaction.
    /// </summary>
    [IsoId("_BI3Yn2vbEfCyxsm1jzUNug")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax1000Text? IssuerReferenceData { get; init; }
}
