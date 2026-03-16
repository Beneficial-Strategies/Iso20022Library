// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payload Description2.
/// </summary>
[IsoId("_ZeIjYexNEe6M4Kz-BKMIbA")]
[DisplayName("Payload Description2")]
public partial record PayloadDescription2
{
    #nullable enable

    /// <summary>
    /// Application Specifics.
    /// </summary>
    [DisplayName("Application Specifics")]
    [IsoXmlTag("ApplSpcfcs")]
    public ApplicationSpecifics1? ApplicationSpecifics { get; init; } 

    /// <summary>
    /// Manifest Data.
    /// </summary>
    [DisplayName("Manifest Data")]
    [IsoXmlTag("MnfstData")]
    public ValueList<ManifestData2> ManifestData { get; init; } = [];

    /// <summary>
    /// Payload Data.
    /// </summary>
    [DisplayName("Payload Data")]
    [IsoXmlTag("PyldData")]
    public required PayloadData2 PayloadData { get; init; } 

    /// <summary>
    /// Payload Type.
    /// </summary>
    [DisplayName("Payload Type")]
    [IsoXmlTag("PyldTp")]
    public required IsoMax256Text PayloadType { get; init; } 

    
    #nullable disable
    
}
