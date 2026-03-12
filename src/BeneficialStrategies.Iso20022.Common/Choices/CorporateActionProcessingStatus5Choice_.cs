// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionProcessingStatus5Choice.Code))]
    [KnownType(typeof(CorporateActionProcessingStatus5Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionProcessingStatus5Choice.Code),nameof(CorporateActionProcessingStatus5Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionProcessingStatus5Choice.Proprietary),nameof(CorporateActionProcessingStatus5Choice.Proprietary))]
    [IsoId("_JZXjFTnXEeWLJsP1cO-amg")]
    [DisplayName("Corporate Action Processing Status 5 Choice")]
    public abstract partial record CorporateActionProcessingStatus5Choice_
    {
    }
}
