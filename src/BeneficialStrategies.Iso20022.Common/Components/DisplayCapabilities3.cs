// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the display components performing the transaction.
/// </summary>
[IsoId("_FIKocXr5EeSZrs_hiwNOWA")]
[DisplayName("Display Capabilities")]
public partial record DisplayCapabilities3
{
    #nullable enable
    
    /// <summary>
    /// Destination of the message to present.
    /// </summary>
    [IsoId("_ZSGLIHr5EeSZrs_hiwNOWA")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public required UserInterface1Code Destination { get; init; } 
    
    /// <summary>
    /// Available message format.
    /// </summary>
    [IsoId("_F69h4Hr6EeSZrs_hiwNOWA")]
    [DisplayName("Available Format")]
    [IsoXmlTag("AvlblFrmt")]
    public SimpleValueList<OutputFormat1Code> AvailableFormat { get; init; } = [];
    // ID for the above is _F69h4Hr6EeSZrs_hiwNOWA
    
    /// <summary>
    /// Number of lines of the display.
    /// </summary>
    [IsoId("_FU1Lc3r5EeSZrs_hiwNOWA")]
    [DisplayName("Number Of Lines")]
    [IsoXmlTag("NbOfLines")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfLines { get; init; } 
    
    /// <summary>
    /// Number of columns of the display or printer.
    /// </summary>
    [IsoId("_FU1LdXr5EeSZrs_hiwNOWA")]
    [DisplayName("Line Width")]
    [IsoXmlTag("LineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LineWidth { get; init; } 
    
    /// <summary>
    /// Available language for the message. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_Nx3MsHr6EeSZrs_hiwNOWA")]
    [DisplayName("Available Language")]
    [IsoXmlTag("AvlblLang")]
    public LanguageCode? AvailableLanguage { get; init; } 
    
    
    #nullable disable
    
}
