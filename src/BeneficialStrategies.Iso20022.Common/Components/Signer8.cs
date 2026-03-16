// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signer8.
/// </summary>
[IsoId("_YearcY-KEe6oobnCtR50kw")]
[DisplayName("Signer8")]
public record Signer8
{
    /// <summary>
    /// Digest Algorithm.
    /// </summary>
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification36 DigestAlgorithm { get; init; }

    /// <summary>
    /// Signature.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public required IsoMax3000Binary Signature { get; init; }

    /// <summary>
    /// Signature Algorithm.
    /// </summary>
    [DisplayName("Signature Algorithm")]
    [IsoXmlTag("SgntrAlgo")]
    public required AlgorithmIdentification33 SignatureAlgorithm { get; init; }

    /// <summary>
    /// Signed Attributes.
    /// </summary>
    [DisplayName("Signed Attributes")]
    [IsoXmlTag("SgndAttrbts")]
    public ValueList<GenericInformation1> SignedAttributes { get; init; } = [];

    /// <summary>
    /// Signer Identification.
    /// </summary>
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    public Recipient13Choice_? SignerIdentification { get; init; }

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoNumber? Version { get; init; }
}
