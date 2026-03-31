// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authenticated Data10.
/// </summary>
[IsoId("_kXtJcY-REe6oobnCtR50kw")]
[DisplayName("Authenticated Data10")]
public record AuthenticatedData10
{
    /// <summary>
    /// Encapsulated Content.
    /// </summary>
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; }

    /// <summary>
    /// MAC.
    /// </summary>
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    public required IsoMax140Binary MAC { get; init; }

    /// <summary>
    /// MAC Algorithm.
    /// </summary>
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public required AlgorithmIdentification31 MACAlgorithm { get; init; }

    /// <summary>
    /// Recipient.
    /// </summary>
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient15Choice_> Recipient { get; init; } = [];

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoNumber? Version { get; init; }
}
