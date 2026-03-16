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
[IsoId("_zw4wQcW4EeuhguwJmlgagQ")]
[DisplayName("Card Not Received Details")]
public record CardNotReceivedDetails2
{
    /// <summary>
    /// Date of card when mailed to the cardholder.
    /// </summary>
    [IsoId("_z1398cW4EeuhguwJmlgagQ")]
    [DisplayName("Date Of Card Mailed")]
    [IsoXmlTag("DtOfCardMld")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateOfCardMailed { get; init; }

    /// <summary>
    /// Address where card was mailed to.
    /// </summary>
    [IsoId("_z13988W4EeuhguwJmlgagQ")]
    [DisplayName("Mailing Address")]
    [IsoXmlTag("MlngAdr")]
    public Address2? MailingAddress { get; init; }

    /// <summary>
    /// Unstructured mailing address where card was mailed to.
    /// </summary>
    [IsoId("_z1399cW4EeuhguwJmlgagQ")]
    [DisplayName("Mailing Address Unstructured")]
    [IsoXmlTag("MlngAdrUstrd")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? MailingAddressUnstructured { get; init; }

    /// <summary>
    /// Postal code where the card was mailed from.
    /// </summary>
    [IsoId("_z13998W4EeuhguwJmlgagQ")]
    [DisplayName("Mailed From Postal Code")]
    [IsoXmlTag("MldFrPstlCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoMax16Text MailedFromPostalCode { get; init; }

    /// <summary>
    /// Date of the beginning of validation of the card.
    /// </summary>
    [IsoId("_z139-cW4EeuhguwJmlgagQ")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidFrom { get; init; }

    /// <summary>
    /// Indicates whether card provides a Card Security Code.
    /// True: Card provides a Card Security Code.
    /// False: Card does not provide a Card Security Code.
    /// </summary>
    [IsoId("_z139-8W4EeuhguwJmlgagQ")]
    [DisplayName("Card Security Code Indicator")]
    [IsoXmlTag("CardSctyCdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardSecurityCodeIndicator { get; init; }

    /// <summary>
    /// Identifies the security capabilities of the card.
    /// </summary>
    [IsoId("_z139_cW4EeuhguwJmlgagQ")]
    [DisplayName("Card Security Capability")]
    [IsoXmlTag("CardSctyCpblty")]
    public ValueList<CardSecurityCapability1> CardSecurityCapability { get; init; } = [];
}
