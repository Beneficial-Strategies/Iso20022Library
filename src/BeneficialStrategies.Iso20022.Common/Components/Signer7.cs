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
[IsoId("_q1KeIXDFEe2MCaKO5AtGsA")]
[DisplayName("Signer")]
public record Signer7
{
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    [IsoId("_q8wT4XDFEe2MCaKO5AtGsA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    [IsoId("_q8wT43DFEe2MCaKO5AtGsA")]
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    public Recipient13Choice_? SignerIdentification { get; init; }

    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_q8xiAXDFEe2MCaKO5AtGsA")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification21 DigestAlgorithm { get; init; }

    /// <summary>
    /// Collection of attributes that are signed.
    /// </summary>
    [IsoId("_q8yJEXDFEe2MCaKO5AtGsA")]
    [DisplayName("Signed Attributes")]
    [IsoXmlTag("SgndAttrbts")]
    public ValueList<GenericInformation1> SignedAttributes { get; init; } = [];

    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    [IsoId("_q8ywIXDFEe2MCaKO5AtGsA")]
    [DisplayName("Signature Algorithm")]
    [IsoXmlTag("SgntrAlgo")]
    public required AlgorithmIdentification30 SignatureAlgorithm { get; init; }

    /// <summary>
    /// Digital signature.
    /// </summary>
    [IsoId("_q8ywI3DFEe2MCaKO5AtGsA")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public required IsoMax3000Binary Signature { get; init; }
}
