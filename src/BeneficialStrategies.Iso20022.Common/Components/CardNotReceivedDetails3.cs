// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Not Received Details3.
/// </summary>
[IsoId("_NiHOgZLCEe6TWIDarRgYow")]
[DisplayName("Card Not Received Details3")]
public partial record CardNotReceivedDetails3
{
    #nullable enable

    /// <summary>
    /// Card Security Capability.
    /// </summary>
    [DisplayName("Card Security Capability")]
    [IsoXmlTag("CardSctyCpblty")]
    public ValueList<CardSecurityCapability1> CardSecurityCapability { get; init; } = [];

    /// <summary>
    /// Card Security Code.
    /// </summary>
    [DisplayName("Card Security Code")]
    [IsoXmlTag("CardSctyCd")]
    public IsoTrueFalseIndicator? CardSecurityCode { get; init; } 

    /// <summary>
    /// Date Mailed.
    /// </summary>
    [DisplayName("Date Mailed")]
    [IsoXmlTag("DtMld")]
    public required IsoISODate DateMailed { get; init; } 

    /// <summary>
    /// Mailed From Postal Code.
    /// </summary>
    [DisplayName("Mailed From Postal Code")]
    [IsoXmlTag("MldFrPstlCd")]
    public required IsoMax16Text MailedFromPostalCode { get; init; } 

    /// <summary>
    /// Mailing Address.
    /// </summary>
    [DisplayName("Mailing Address")]
    [IsoXmlTag("MlngAdr")]
    public Address2? MailingAddress { get; init; } 

    /// <summary>
    /// Mailing Address Unstructured.
    /// </summary>
    [DisplayName("Mailing Address Unstructured")]
    [IsoXmlTag("MlngAdrUstrd")]
    public IsoMax256Text? MailingAddressUnstructured { get; init; } 

    /// <summary>
    /// Valid From.
    /// </summary>
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public IsoISODate? ValidFrom { get; init; } 

    
    #nullable disable
    
}
