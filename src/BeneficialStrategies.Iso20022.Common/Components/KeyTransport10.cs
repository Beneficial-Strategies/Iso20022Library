// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key Transport10.
/// </summary>
[IsoId("_TAt6YY-PEe6oobnCtR50kw")]
[DisplayName("Key Transport10")]
public partial record KeyTransport10
{
    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public Number? Version { get; init; }

    /// <summary>
    /// Recipient Identification.
    /// </summary>
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public required Recipient13Choice_ RecipientIdentification { get; init; }

    /// <summary>
    /// Key Encryption Algorithm.
    /// </summary>
    [DisplayName("Key Encryption Algorithm")]
    [IsoXmlTag("KeyNcrptnAlgo")]
    public required AlgorithmIdentification35 KeyEncryptionAlgorithm { get; init; }

    /// <summary>
    /// Encrypted Key.
    /// </summary>
    [DisplayName("Encrypted Key")]
    [IsoXmlTag("NcrptdKey")]
    public required Max5000Binary EncryptedKey { get; init; }
}
