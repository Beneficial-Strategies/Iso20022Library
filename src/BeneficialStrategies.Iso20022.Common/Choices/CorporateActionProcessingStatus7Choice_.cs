// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Processing Status7Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionProcessingStatus7Choice.EventInformationStatus))]
    [KnownType(typeof(CorporateActionProcessingStatus7Choice.ForInformationOnly))]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus7Choice.EventInformationStatus),
        nameof(CorporateActionProcessingStatus7Choice.EventInformationStatus)
    )]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus7Choice.ForInformationOnly),
        nameof(CorporateActionProcessingStatus7Choice.ForInformationOnly)
    )]
    [IsoId("_y2LgkEmeEe-NocYul3BKXQ")]
    [DisplayName("Corporate Action Processing Status7Choice")]
    public abstract record CorporateActionProcessingStatus7Choice_ { }
}
