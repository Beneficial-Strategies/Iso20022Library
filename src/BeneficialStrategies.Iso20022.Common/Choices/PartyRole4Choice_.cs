// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the role.
    /// </summary>
    [KnownType(typeof(PartyRole4Choice.Code))]
    [KnownType(typeof(PartyRole4Choice.Proprietary))]
    [JsonDerivedType(typeof(PartyRole4Choice.Code), nameof(PartyRole4Choice.Code))]
    [JsonDerivedType(typeof(PartyRole4Choice.Proprietary), nameof(PartyRole4Choice.Proprietary))]
    [IsoId("_XXtRYV92EeS7xuKaq75oiQ")]
    [DisplayName("Party Role 4 Choice")]
    public abstract record PartyRole4Choice_ { }
}
