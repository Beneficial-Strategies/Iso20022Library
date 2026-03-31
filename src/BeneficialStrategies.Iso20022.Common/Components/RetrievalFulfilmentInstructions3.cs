// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Retrieval Fulfilment Instructions3.
/// </summary>
[IsoId("_NRcA0YVyEe6odei_lsRKtw")]
[DisplayName("Retrieval Fulfilment Instructions3")]
public record RetrievalFulfilmentInstructions3
{
    /// <summary>
    /// Actual Delivery Method.
    /// </summary>
    [DisplayName("Actual Delivery Method")]
    [IsoXmlTag("ActlDlvryMtd")]
    public IsoMax35Text? ActualDeliveryMethod { get; init; }

    /// <summary>
    /// Contact.
    /// </summary>
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactBusiness1? Contact { get; init; }

    /// <summary>
    /// Established Method.
    /// </summary>
    [DisplayName("Established Method")]
    [IsoXmlTag("EstblishdMtd")]
    public ValueList<IsoMax35Text> EstablishedMethod { get; init; } = [];

    /// <summary>
    /// Format.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat4Code? Format { get; init; }

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public Address2? PostalAddress { get; init; }

    /// <summary>
    /// Recipient.
    /// </summary>
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public PartyType19Code? Recipient { get; init; }

    /// <summary>
    /// Requested Method.
    /// </summary>
    [DisplayName("Requested Method")]
    [IsoXmlTag("ReqdMtd")]
    public ValueList<IsoMax35Text> RequestedMethod { get; init; } = [];

    /// <summary>
    /// Target.
    /// </summary>
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public ValueList<UserInterface8Code> Target { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required IsoMax20KText Value { get; init; }
}
