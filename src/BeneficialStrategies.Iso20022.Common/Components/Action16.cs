// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action16.
/// </summary>
[IsoId("_iMYJgXHFEe60F8I8TAMKmg")]
[DisplayName("Action16")]
public record Action16
{
    /// <summary>
    /// Certificate Identification.
    /// </summary>
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    public IsoMax70Text? CertificateIdentification { get; init; }

    /// <summary>
    /// Contact.
    /// </summary>
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal1? Contact { get; init; }

    /// <summary>
    /// Content.
    /// </summary>
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ValueList<AdditionalData1> Content { get; init; } = [];

    /// <summary>
    /// Destination.
    /// </summary>
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyType34Code? Destination { get; init; }

    /// <summary>
    /// Destination Address.
    /// </summary>
    [DisplayName("Destination Address")]
    [IsoXmlTag("DstnAdr")]
    public IsoMax70Text? DestinationAddress { get; init; }

    /// <summary>
    /// Destination Type.
    /// </summary>
    [DisplayName("Destination Type")]
    [IsoXmlTag("DstnTp")]
    public ActionDestination1Code? DestinationType { get; init; }

    /// <summary>
    /// Format.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat4Code? Format { get; init; }

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISOMax3ALanguageCode? Language { get; init; }

    /// <summary>
    /// Other Destination.
    /// </summary>
    [DisplayName("Other Destination")]
    [IsoXmlTag("OthrDstn")]
    public IsoMax35Text? OtherDestination { get; init; }

    /// <summary>
    /// Other Destination Type.
    /// </summary>
    [DisplayName("Other Destination Type")]
    [IsoXmlTag("OthrDstnTp")]
    public IsoMax35Text? OtherDestinationType { get; init; }

    /// <summary>
    /// Other Format.
    /// </summary>
    [DisplayName("Other Format")]
    [IsoXmlTag("OthrFrmt")]
    public IsoMax35Text? OtherFormat { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Signature.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public IsoMax140Binary? Signature { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ActionType14Code? Type { get; init; }
}
