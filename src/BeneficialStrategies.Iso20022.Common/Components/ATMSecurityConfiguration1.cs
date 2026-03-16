// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters in use by the security device.
/// </summary>
[IsoId("_4FKwEIr6EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
public record ATMSecurityConfiguration1
{
    /// <summary>
    /// Configuration of the cryptographic keys.
    /// </summary>
    [IsoId("_LT8SEIr7EeSvuOJS0mmL0g")]
    [DisplayName("Keys")]
    [IsoXmlTag("Keys")]
    public ATMSecurityConfiguration2? Keys { get; init; }

    /// <summary>
    /// Configuration of the encryption or digital envelope, if the security module is able to perform encryption.
    /// </summary>
    [IsoId("_vEEGgIr7EeSvuOJS0mmL0g")]
    [DisplayName("Encryption")]
    [IsoXmlTag("Ncrptn")]
    public ATMSecurityConfiguration3? Encryption { get; init; }

    /// <summary>
    /// MAC (Message Authentication Code) algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_gRAscIr8EeSvuOJS0mmL0g")]
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public Algorithm12Code? MACAlgorithm { get; init; }

    /// <summary>
    /// Digest algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_kEKN8Ir8EeSvuOJS0mmL0g")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm11Code? DigestAlgorithm { get; init; }

    /// <summary>
    /// Configuration of the digital signatures if the security module is able to perform digital signatures with an asymmetric key.
    /// </summary>
    [IsoId("_2MDAYIr8EeSvuOJS0mmL0g")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public ATMSecurityConfiguration4? DigitalSignature { get; init; }

    /// <summary>
    /// Configuration of the PIN online verification.
    /// </summary>
    [IsoId("_fAcnAIr9EeSvuOJS0mmL0g")]
    [DisplayName("PIN")]
    [IsoXmlTag("PIN")]
    public ATMSecurityConfiguration5? PIN { get; init; }

    /// <summary>
    /// Mechanism used to protect the message of the ATM protocol.
    /// </summary>
    [IsoId("_KGeSAIr-EeSvuOJS0mmL0g")]
    [DisplayName("Message Protection")]
    [IsoXmlTag("MsgPrtcn")]
    public MessageProtection1Code? MessageProtection { get; init; }
}
