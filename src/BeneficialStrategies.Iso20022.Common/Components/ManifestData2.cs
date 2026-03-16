// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Manifest Data2.
/// </summary>
[IsoId("_kz8lEexNEe6M4Kz-BKMIbA")]
[DisplayName("Manifest Data2")]
public record ManifestData2
{
    /// <summary>
    /// Document Type.
    /// </summary>
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    public required IsoMax35Text DocumentType { get; init; }

    /// <summary>
    /// Number Of Documents.
    /// </summary>
    [DisplayName("Number Of Documents")]
    [IsoXmlTag("NbOfDocs")]
    public required IsoNumber NumberOfDocuments { get; init; }
}
