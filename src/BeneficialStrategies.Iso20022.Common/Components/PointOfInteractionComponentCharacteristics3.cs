// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical and logical characteristics of a POI component (Point of Interaction).
/// </summary>
[IsoId("_NCWNobCZEeapjPTKZHuM2w")]
[DisplayName("Point Of Interaction Component Characteristics")]
public record PointOfInteractionComponentCharacteristics3
{
    /// <summary>
    /// Memory characteristics of the component.
    /// </summary>
    [IsoId("_NOE8gbCZEeapjPTKZHuM2w")]
    [DisplayName("Memory")]
    [IsoXmlTag("Mmry")]
    public ValueList<MemoryCharacteristics1> Memory { get; init; } = [];

    /// <summary>
    /// Low level communication of the hardware or software component toward another component or an external entity.
    /// </summary>
    [IsoId("_NOE8g7CZEeapjPTKZHuM2w")]
    [DisplayName("Communication")]
    [IsoXmlTag("Com")]
    public ValueList<CommunicationCharacteristics3> Communication { get; init; } = [];

    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_NOE8hbCZEeapjPTKZHuM2w")]
    [DisplayName("Security Access Modules")]
    [IsoXmlTag("SctyAccsMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SecurityAccessModules { get; init; }

    /// <summary>
    /// Number of subscriber identity modules (SIM).
    /// </summary>
    [IsoId("_NOE8h7CZEeapjPTKZHuM2w")]
    [DisplayName("Subscriber Identity Modules")]
    [IsoXmlTag("SbcbrIdntyMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SubscriberIdentityModules { get; init; }

    /// <summary>
    /// Value for checking a cryptographic key security parameter.
    /// </summary>
    [IsoId("_NOE8ibCZEeapjPTKZHuM2w")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? KeyCheckValue { get; init; }

    /// <summary>
    /// Sufficient characteristic information to identify the Key Encryption Key.
    /// </summary>
    [IsoId("_jzJhkLC9EeamYaqfhG1ZuA")]
    [DisplayName("Key Characteristic")]
    [IsoXmlTag("KeyChrtc")]
    public KEKIdentifier5? KeyCharacteristic { get; init; }

    /// <summary>
    /// Use in DUKPT Key to carry last 5 bytes of derivation value.
    /// </summary>
    [IsoId("_q8W_8LC9EeamYaqfhG1ZuA")]
    [DisplayName("Encrypted Key")]
    [IsoXmlTag("NcrptdKey")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? EncryptedKey { get; init; }
}
