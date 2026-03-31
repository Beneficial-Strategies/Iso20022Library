// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code for specifying the processing type of a corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingType2Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingType2Choice.Code),
        nameof(CorporateActionEventProcessingType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingType2Choice.Proprietary),
        nameof(CorporateActionEventProcessingType2Choice.Proprietary)
    )]
    [IsoId("_RLnv5zndEeWLJsP1cO-amg")]
    [DisplayName("Corporate Action Event Processing Type 2 Choice")]
    public abstract record CorporateActionEventProcessingType2Choice_ { }
}
