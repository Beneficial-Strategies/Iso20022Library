// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionProcessingStatus4Choice.Code))]
    [KnownType(typeof(CorporateActionProcessingStatus4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus4Choice.Code),
        nameof(CorporateActionProcessingStatus4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus4Choice.Proprietary),
        nameof(CorporateActionProcessingStatus4Choice.Proprietary)
    )]
    [IsoId("_s2r48SXZEeOFIcNWlDEvdQ")]
    [DisplayName("Corporate Action Processing Status 4 Choice")]
    public abstract record CorporateActionProcessingStatus4Choice_ { }
}
