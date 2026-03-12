// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of corporate action processing status.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingStatus4Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingStatus4Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingStatus4Choice.Code),nameof(CorporateActionEventProcessingStatus4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingStatus4Choice.Proprietary),nameof(CorporateActionEventProcessingStatus4Choice.Proprietary))]
    [IsoId("_8QborZNLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Processing Status 4 Choice")]
    public abstract partial record CorporateActionEventProcessingStatus4Choice_
    {
    }
}
