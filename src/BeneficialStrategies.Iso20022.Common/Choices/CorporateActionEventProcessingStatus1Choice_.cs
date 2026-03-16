// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of corporate action processing status.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingStatus1Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingStatus1Choice.Code),
        nameof(CorporateActionEventProcessingStatus1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingStatus1Choice.Proprietary),
        nameof(CorporateActionEventProcessingStatus1Choice.Proprietary)
    )]
    [IsoId("_Qsl-Q9p-Ed-ak6NoX_4Aeg_-1300232814")]
    [DisplayName("Corporate Action Event Processing Status 1 Choice")]
    public abstract record CorporateActionEventProcessingStatus1Choice_ { }
}
