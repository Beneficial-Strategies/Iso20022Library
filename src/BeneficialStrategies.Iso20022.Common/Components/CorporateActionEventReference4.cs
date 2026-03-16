// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a linked corporate action event.
/// </summary>
[IsoId("_chUcRZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Event Reference")]
public record CorporateActionEventReference4
{
    /// <summary>
    /// Identification of the linked corporate action event.
    /// </summary>
    [IsoId("_chUcR5KQEeWHWpTQn1FFVg")]
    [DisplayName("Event Identification")]
    [IsoXmlTag("EvtId")]
    public required CorporateActionEventReference4Choice_ EventIdentification { get; init; }

    /// <summary>
    /// Specifies when this corporate action event is to be processed relative to a linked corporate action event.
    /// </summary>
    [IsoId("_chUcT5KQEeWHWpTQn1FFVg")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition10Choice_? LinkageType { get; init; }
}
