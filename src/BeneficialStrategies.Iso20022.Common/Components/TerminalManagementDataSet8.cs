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
[IsoId("_BS2goTV8EeODSIIQsYYKhw")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet8
{
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_BjXo4TV8EeODSIIQsYYKhw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification3 Identification { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_BjXo4zV8EeODSIIQsYYKhw")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_BjXo5TV8EeODSIIQsYYKhw")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Transport key encrypted by the TM (Terminal manager) key encryption RSA key.
    /// </summary>
    [IsoId("_BjXo5zV8EeODSIIQsYYKhw")]
    [DisplayName("Encrypted Key")]
    [IsoXmlTag("NcrptdKey")]
    public ContentInformationType7? EncryptedKey { get; init; }
}
