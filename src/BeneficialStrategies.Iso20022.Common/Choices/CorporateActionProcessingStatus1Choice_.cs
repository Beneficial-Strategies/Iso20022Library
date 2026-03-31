// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionProcessingStatus1Choice.EventStatus))]
    [KnownType(typeof(CorporateActionProcessingStatus1Choice.ForInformationOnlyIndicator))]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus1Choice.EventStatus),
        nameof(CorporateActionProcessingStatus1Choice.EventStatus)
    )]
    [JsonDerivedType(
        typeof(CorporateActionProcessingStatus1Choice.ForInformationOnlyIndicator),
        nameof(CorporateActionProcessingStatus1Choice.ForInformationOnlyIndicator)
    )]
    [IsoId("_Q1O85Np-Ed-ak6NoX_4Aeg_-1142477030")]
    [DisplayName("Corporate Action Processing Status 1 Choice")]
    public abstract record CorporateActionProcessingStatus1Choice_ { }
}
