// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity who has signed the data and its digital signature.
/// </summary>
[IsoId("_gThY8dtbEee9e6xduATmQg")]
[DisplayName("Signer")]
public record Signer4
{
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    [IsoId("_gc2UEdtbEee9e6xduATmQg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    [IsoId("_gc2UE9tbEee9e6xduATmQg")]
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    public Recipient5Choice_? SignerIdentification { get; init; }

    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_gc2UFdtbEee9e6xduATmQg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification21 DigestAlgorithm { get; init; }

    /// <summary>
    /// Collection of attributes that are signed.
    /// </summary>
    [IsoId("_T-zv0N9dEeeNt9bWIs54cw")]
    [DisplayName("Signed Attributes")]
    [IsoXmlTag("SgndAttrbts")]
    public ValueList<GenericInformation1> SignedAttributes { get; init; } = [];

    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    [IsoId("_gc2UF9tbEee9e6xduATmQg")]
    [DisplayName("Signature Algorithm")]
    [IsoXmlTag("SgntrAlgo")]
    public required AlgorithmIdentification20 SignatureAlgorithm { get; init; }

    /// <summary>
    /// Digital signature.
    /// </summary>
    [IsoId("_gc2UGdtbEee9e6xduATmQg")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public required IsoMax3000Binary Signature { get; init; }
}
