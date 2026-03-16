// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the update information.
    /// </summary>
    [KnownType(typeof(UpdateType4Choice.Code))]
    [KnownType(typeof(UpdateType4Choice.Proprietary))]
    [JsonDerivedType(typeof(UpdateType4Choice.Code), nameof(UpdateType4Choice.Code))]
    [JsonDerivedType(typeof(UpdateType4Choice.Proprietary), nameof(UpdateType4Choice.Proprietary))]
    [IsoId("_m_7dcvNBEeCuA5Tr22BnwA_1235220635")]
    [DisplayName("Update Type 4 Choice")]
    public abstract record UpdateType4Choice_ { }
}
