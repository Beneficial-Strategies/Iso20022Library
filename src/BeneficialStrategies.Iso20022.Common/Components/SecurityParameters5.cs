// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security parameters of the host downloading the key.
/// </summary>
[IsoId("_iobOIYtcEeST3ocKVc8_qA")]
[DisplayName("Security Parameters")]
public record SecurityParameters5
{
    /// <summary>
    /// Random value from the host.
    /// </summary>
    [IsoId("_i2b094tcEeST3ocKVc8_qA")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? HostChallenge { get; init; }

    /// <summary>
    /// Cryptographic key used to store in the ATM.
    /// </summary>
    [IsoId("_i2b08YtcEeST3ocKVc8_qA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey8? Key { get; init; }

    /// <summary>
    /// Digital signature of implicit data depending on the security scheme download procedure.
    /// </summary>
    [IsoId("_i2b084tcEeST3ocKVc8_qA")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public ContentInformationType14? DigitalSignature { get; init; }
}
