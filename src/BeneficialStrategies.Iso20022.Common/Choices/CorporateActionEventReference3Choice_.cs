// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a corporate action identification or a corporate action official identification.
    /// </summary>
    [KnownType(typeof(CorporateActionEventReference3Choice.LinkedOfficialCorporateActionEventIdentification))]
    [KnownType(typeof(CorporateActionEventReference3Choice.LinkedCorporateActionIdentification))]
    [JsonDerivedType(typeof(CorporateActionEventReference3Choice.LinkedOfficialCorporateActionEventIdentification),nameof(CorporateActionEventReference3Choice.LinkedOfficialCorporateActionEventIdentification))]
    [JsonDerivedType(typeof(CorporateActionEventReference3Choice.LinkedCorporateActionIdentification),nameof(CorporateActionEventReference3Choice.LinkedCorporateActionIdentification))]
    [IsoId("_4VgxsTncEeWLJsP1cO-amg")]
    [DisplayName("Corporate Action Event Reference 3 Choice")]
    public abstract partial record CorporateActionEventReference3Choice_
    {
    }
}
