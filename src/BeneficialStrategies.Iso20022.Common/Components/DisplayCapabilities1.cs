// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The capabilities of the display components performing the transaction.
/// </summary>
[IsoId("_TGJWZgEcEeCQm6a_G2yO_w_-976075927")]
[DisplayName("Display Capabilities")]
public partial record DisplayCapabilities1
{
    #nullable enable
    
    /// <summary>
    /// Type of display (for example merchant or cardholder).
    /// </summary>
    [IsoId("_TGJWZwEcEeCQm6a_G2yO_w_-1888573626")]
    [DisplayName("Display Type")]
    [IsoXmlTag("DispTp")]
    public required UserInterface2Code DisplayType { get; init; } 
    
    /// <summary>
    /// Number of lines of the display component.
    /// </summary>
    [IsoId("_TGJWaAEcEeCQm6a_G2yO_w_-1153627396")]
    [DisplayName("Number Of Lines")]
    [IsoXmlTag("NbOfLines")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText NumberOfLines { get; init; } 
    
    /// <summary>
    /// Number of columns of the display component.
    /// </summary>
    [IsoId("_TGJWaQEcEeCQm6a_G2yO_w_1903246972")]
    [DisplayName("Line Width")]
    [IsoXmlTag("LineWidth")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText LineWidth { get; init; } 
    
    
    #nullable disable
    
}
