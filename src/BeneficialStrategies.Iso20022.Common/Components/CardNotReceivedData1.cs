// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a non-received card.
/// </summary>
[IsoId("_t-vZMXR4EfC68Y4jZPNEug")]
[DisplayName("Card Not Received Data1")]
public record CardNotReceivedData1
{
    /// <summary>
    /// Date of card when mailed to the cardholder.
    /// </summary>
    [IsoId("_uBd9EXR4EfC68Y4jZPNEug")]
    [DisplayName("Date Mailed")]
    [IsoXmlTag("DtMld")]
    public required IsoISODate DateMailed { get; init; }

    /// <summary>
    /// Address where card was mailed to.
    /// </summary>
    [IsoId("_uBd9E3R4EfC68Y4jZPNEug")]
    [DisplayName("Mailing Address")]
    [IsoXmlTag("MlngAdr")]
    public Address4? MailingAddress { get; init; }

    /// <summary>
    /// Unstructured mailing address where card was mailed to.
    /// </summary>
    [IsoId("_uBd9FXR4EfC68Y4jZPNEug")]
    [DisplayName("Mailing Address Unstructured")]
    [IsoXmlTag("MlngAdrUstrd")]
    public IsoMax256Text? MailingAddressUnstructured { get; init; }

    /// <summary>
    /// Postal code where the card was mailed from.
    /// </summary>
    [IsoId("_uBd9F3R4EfC68Y4jZPNEug")]
    [DisplayName("Mailed From Postal Code")]
    [IsoXmlTag("MldFrPstlCd")]
    public required IsoMax16Text MailedFromPostalCode { get; init; }

    /// <summary>
    /// Date of the beginning of validation of the card.
    /// </summary>
    [IsoId("_uBd9GXR4EfC68Y4jZPNEug")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public IsoISODate? ValidFrom { get; init; }

    /// <summary>
    /// Indicates whether card provides a Card Security Code.
    /// </summary>
    [IsoId("_uBd9G3R4EfC68Y4jZPNEug")]
    [DisplayName("Card Security Code")]
    [IsoXmlTag("CardSctyCd")]
    public IsoTrueFalseIndicator? CardSecurityCode { get; init; }

    /// <summary>
    /// Identifies the security capabilities of the card.
    /// </summary>
    [IsoId("_uBd9HXR4EfC68Y4jZPNEug")]
    [DisplayName("Card Security Capability")]
    [IsoXmlTag("CardSctyCpblty")]
    public SimpleValueList<CardSecurityCapability2Code> CardSecurityCapability { get; init; } = [];
}
