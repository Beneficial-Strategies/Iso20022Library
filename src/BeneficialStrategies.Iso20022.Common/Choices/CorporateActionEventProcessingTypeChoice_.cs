// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code for specifying the processing type of a corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingTypeChoice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingTypeChoice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingTypeChoice.Code),
        nameof(CorporateActionEventProcessingTypeChoice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingTypeChoice.Proprietary),
        nameof(CorporateActionEventProcessingTypeChoice.Proprietary)
    )]
    [IsoId("_Q4g6aNp-Ed-ak6NoX_4Aeg_944669894")]
    [DisplayName("Corporate Action Event Processing Type Choice")]
    public abstract record CorporateActionEventProcessingTypeChoice_ { }
}
