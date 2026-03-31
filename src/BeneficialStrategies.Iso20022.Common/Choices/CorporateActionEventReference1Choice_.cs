// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a corporate action identification or a corporate action official identification.
    /// </summary>
    [KnownType(
        typeof(CorporateActionEventReference1Choice.LinkedOfficialCorporateActionEventIdentification)
    )]
    [KnownType(typeof(CorporateActionEventReference1Choice.LinkedCorporateActionIdentification))]
    [JsonDerivedType(
        typeof(CorporateActionEventReference1Choice.LinkedOfficialCorporateActionEventIdentification),
        nameof(
            CorporateActionEventReference1Choice.LinkedOfficialCorporateActionEventIdentification
        )
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventReference1Choice.LinkedCorporateActionIdentification),
        nameof(CorporateActionEventReference1Choice.LinkedCorporateActionIdentification)
    )]
    [IsoId("_QxNYidp-Ed-ak6NoX_4Aeg_-50751727")]
    [DisplayName("Corporate Action Event Reference 1 Choice")]
    public abstract record CorporateActionEventReference1Choice_ { }
}
