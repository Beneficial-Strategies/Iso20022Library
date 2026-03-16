// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Manifest Data2.
/// </summary>
[IsoId("_kz8lEexNEe6M4Kz-BKMIbA")]
[DisplayName("Manifest Data2")]
public partial record ManifestData2
{
    #nullable enable

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

    
    #nullable disable
    
}
