// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [KnownType(typeof(Incoterms4Choice.Code))]
    [KnownType(typeof(Incoterms4Choice.Proprietary))]
    [JsonDerivedType(typeof(Incoterms4Choice.Code), nameof(Incoterms4Choice.Code))]
    [JsonDerivedType(typeof(Incoterms4Choice.Proprietary), nameof(Incoterms4Choice.Proprietary))]
    [IsoId("_S5ezYAEcEeCQm6a_G2yO_w_-552526097")]
    [DisplayName("Incoterms 4 Choice")]
    public abstract record Incoterms4Choice_ { }
}
