// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType1Choice.Code))]
    [KnownType(typeof(CorporateActionEventType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType1Choice.Code),
        nameof(CorporateActionEventType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType1Choice.Proprietary),
        nameof(CorporateActionEventType1Choice.Proprietary)
    )]
    [IsoId("_QwK2uNp-Ed-ak6NoX_4Aeg_2018145475")]
    [DisplayName("Corporate Action Event Type 1 Choice")]
    public abstract record CorporateActionEventType1Choice_ { }
}
