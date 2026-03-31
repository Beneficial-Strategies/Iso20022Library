// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of requested data set.
/// </summary>
[IsoId("_MjsGMCmzEeKIjpr--01h3Q")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet7
{
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_p2fR4CmzEeKIjpr--01h3Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification3 Identification { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_yItmwCmzEeKIjpr--01h3Q")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_8yisMCmzEeKIjpr--01h3Q")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Transport key encrypted by the TM key encryption RSA key.
    /// </summary>
    [IsoId("_DzipwCm0EeKIjpr--01h3Q")]
    [DisplayName("Encrypted Key")]
    [IsoXmlTag("NcrptdKey")]
    public ContentInformationType5? EncryptedKey { get; init; }
}
