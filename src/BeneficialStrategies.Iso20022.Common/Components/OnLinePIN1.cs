// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted personal identification number (PIN) and related information.
/// </summary>
[IsoId("_SqIIwQEcEeCQm6a_G2yO_w_-1593466438")]
[DisplayName("On Line PIN")]
public record OnLinePIN1
{
    /// <summary>
    /// Encrypted PIN (Personal Identification Number).
    /// </summary>
    [IsoId("_SqIIwgEcEeCQm6a_G2yO_w_1778537606")]
    [DisplayName("Encrypted PIN Block")]
    [IsoXmlTag("NcrptdPINBlck")]
    public required ContentInformationType2 EncryptedPINBlock { get; init; }

    /// <summary>
    /// PIN format before encryption.
    /// </summary>
    [IsoId("_SqIIwwEcEeCQm6a_G2yO_w_-1684147451")]
    [DisplayName("PIN Format")]
    [IsoXmlTag("PINFrmt")]
    public required PINFormat1Code PINFormat { get; init; }

    /// <summary>
    /// Additional information required to verify the PIN.
    /// </summary>
    [IsoId("_SqIIxAEcEeCQm6a_G2yO_w_1043641581")]
    [DisplayName("Additional Input")]
    [IsoXmlTag("AddtlInpt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalInput { get; init; }
}
