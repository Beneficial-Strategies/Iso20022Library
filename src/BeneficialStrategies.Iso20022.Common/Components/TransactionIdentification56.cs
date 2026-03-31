// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Identification56.
/// </summary>
[IsoId("_XosNUY7aEe6S0_1AaJzQCA")]
[DisplayName("Transaction Identification56")]
public record TransactionIdentification56
{
    /// <summary>
    /// Associated Data.
    /// </summary>
    [DisplayName("Associated Data")]
    [IsoXmlTag("AssoctdData")]
    public IsoTrueFalseIndicator? AssociatedData { get; init; }

    /// <summary>
    /// Associated Data Destination.
    /// </summary>
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Associated Data Reference.
    /// </summary>
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Life Cycle Identification.
    /// </summary>
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoExact15Text? LifeCycleIdentification { get; init; }

    /// <summary>
    /// Other Purchase Identifier Type.
    /// </summary>
    [DisplayName("Other Purchase Identifier Type")]
    [IsoXmlTag("OthrPurchsIdrTp")]
    public IsoMax35Text? OtherPurchaseIdentifierType { get; init; }

    /// <summary>
    /// Purchase Identifier.
    /// </summary>
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    /// <summary>
    /// Purchase Identifier Type.
    /// </summary>
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType2Code? PurchaseIdentifierType { get; init; }

    /// <summary>
    /// Retrieval Reference Number.
    /// </summary>
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    /// <summary>
    /// System Trace Audit Number.
    /// </summary>
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Transmission Date Time.
    /// </summary>
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public required IsoISODateTime TransmissionDateTime { get; init; }
}
