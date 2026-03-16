// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital signature of data, with an asymmetric key.
/// </summary>
[IsoId("_SIFo4VW8EeOlEMHvp-ipJg")]
[DisplayName("Signed Data")]
public record SignedData3
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SS0SMVW8EeOlEMHvp-ipJg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_SS0SM1W8EeOlEMHvp-ipJg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification5> DigestAlgorithm { get; init; } = [];

    // ID for the above is _SS0SM1W8EeOlEMHvp-ipJg

    /// <summary>
    /// Data to sign.
    /// </summary>
    [IsoId("_SS0SNVW8EeOlEMHvp-ipJg")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent2 EncapsulatedContent { get; init; }

    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [IsoId("_SS0SN1W8EeOlEMHvp-ipJg")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax3000Binary> Certificate { get; init; } = [];

    /// <summary>
    /// Entity who has signed the data.
    /// </summary>
    [IsoId("_SS0SOVW8EeOlEMHvp-ipJg")]
    [DisplayName("Signer")]
    [IsoXmlTag("Sgnr")]
    public ValueList<Signer2> Signer { get; init; } = [];
    // ID for the above is _SS0SOVW8EeOlEMHvp-ipJg
}
