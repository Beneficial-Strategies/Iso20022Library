// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a corporate action identification or a corporate action official identification.
    /// </summary>
    [KnownType(typeof(CorporateActionEventReference4Choice.LinkedOfficialCorporateActionEventIdentification))]
    [KnownType(typeof(CorporateActionEventReference4Choice.LinkedCorporateActionIdentification))]
    [JsonDerivedType(typeof(CorporateActionEventReference4Choice.LinkedOfficialCorporateActionEventIdentification),nameof(CorporateActionEventReference4Choice.LinkedOfficialCorporateActionEventIdentification))]
    [JsonDerivedType(typeof(CorporateActionEventReference4Choice.LinkedCorporateActionIdentification),nameof(CorporateActionEventReference4Choice.LinkedCorporateActionIdentification))]
    [IsoId("_chUcWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Reference 4 Choice")]
    public abstract partial record CorporateActionEventReference4Choice_
    {
    }
}
