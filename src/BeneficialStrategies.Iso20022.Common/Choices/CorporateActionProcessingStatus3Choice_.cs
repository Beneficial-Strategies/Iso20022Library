// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionProcessingStatus3Choice.Code))]
    [KnownType(typeof(CorporateActionProcessingStatus3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus3Choice.Code),
        nameof(CorporateActionProcessingStatus3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus3Choice.Proprietary),
        nameof(CorporateActionProcessingStatus3Choice.Proprietary)
    )]
    [IsoId("_PL-N8QuIEeGnWuuxuI2McQ")]
    [DisplayName("Corporate Action Processing Status 3 Choice")]
    public abstract record CorporateActionProcessingStatus3Choice_ { }
}
