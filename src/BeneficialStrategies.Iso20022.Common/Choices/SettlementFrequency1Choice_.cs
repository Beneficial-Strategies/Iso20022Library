// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the settlement frequency.
    /// </summary>
    [KnownType(typeof(SettlementFrequency1Choice.Code))]
    [KnownType(typeof(SettlementFrequency1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementFrequency1Choice.Code),
        nameof(SettlementFrequency1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementFrequency1Choice.Proprietary),
        nameof(SettlementFrequency1Choice.Proprietary)
    )]
    [IsoId("_jg3o4CDUEeWCLu74WLgP4w")]
    [DisplayName("Settlement Frequency 1 Choice")]
    public abstract record SettlementFrequency1Choice_ { }
}
