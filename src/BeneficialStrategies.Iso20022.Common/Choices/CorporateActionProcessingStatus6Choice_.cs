// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionProcessingStatus6Choice.Code))]
    [KnownType(typeof(CorporateActionProcessingStatus6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus6Choice.Code),
        nameof(CorporateActionProcessingStatus6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus6Choice.Proprietary),
        nameof(CorporateActionProcessingStatus6Choice.Proprietary)
    )]
    [IsoId("_W9mj5ZmtEeWLs7cvLxlyAg")]
    [DisplayName("Corporate Action Processing Status 6 Choice")]
    public abstract record CorporateActionProcessingStatus6Choice_ { }
}
