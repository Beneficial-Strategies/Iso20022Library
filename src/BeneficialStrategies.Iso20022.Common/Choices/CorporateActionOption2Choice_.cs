// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption2Choice.Code))]
    [KnownType(typeof(CorporateActionOption2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption2Choice.Code),
        nameof(CorporateActionOption2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption2Choice.Proprietary),
        nameof(CorporateActionOption2Choice.Proprietary)
    )]
    [IsoId("_Q0yQ8dp-Ed-ak6NoX_4Aeg_1018924784")]
    [DisplayName("Corporate Action Option 2 Choice")]
    public abstract record CorporateActionOption2Choice_ { }
}
