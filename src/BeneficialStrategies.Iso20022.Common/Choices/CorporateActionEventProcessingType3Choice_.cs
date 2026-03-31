// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code for specifying the processing type of a corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingType3Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingType3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingType3Choice.Code),
        nameof(CorporateActionEventProcessingType3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingType3Choice.Proprietary),
        nameof(CorporateActionEventProcessingType3Choice.Proprietary)
    )]
    [IsoId("_ctOwsZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Processing Type 3 Choice")]
    public abstract record CorporateActionEventProcessingType3Choice_ { }
}
