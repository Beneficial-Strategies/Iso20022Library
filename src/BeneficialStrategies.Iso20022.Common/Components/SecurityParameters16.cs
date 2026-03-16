// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security Parameters16.
/// </summary>
[IsoId("_hD7woZEHEe6Un9Rms6YuCg")]
[DisplayName("Security Parameters16")]
public partial record SecurityParameters16
{
    #nullable enable

    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 

    /// <summary>
    /// POI Challenge.
    /// </summary>
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    public IsoMax140Binary? POIChallenge { get; init; } 

    /// <summary>
    /// Security Element.
    /// </summary>
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public ValueList<CryptographicKey18> SecurityElement { get; init; } = [];

    /// <summary>
    /// TM Challenge.
    /// </summary>
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    public IsoMax140Binary? TMChallenge { get; init; } 

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required IsoMax256Text Version { get; init; } 

    
    #nullable disable
    
}
