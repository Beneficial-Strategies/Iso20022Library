// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indication of no disclosure and the provision of shareholding disclosure information.
    /// </summary>
    [KnownType(typeof(Disclosure1Choice.NoDisclosure))]
    [KnownType(typeof(Disclosure1Choice.SafekeepingAccountAndHoldings))]
    [JsonDerivedType(
        typeof(Disclosure1Choice.NoDisclosure),
        nameof(Disclosure1Choice.NoDisclosure)
    )]
    [JsonDerivedType(
        typeof(Disclosure1Choice.SafekeepingAccountAndHoldings),
        nameof(Disclosure1Choice.SafekeepingAccountAndHoldings)
    )]
    [IsoId("_xP2q0MAMEembi_x1QDJfxw")]
    [DisplayName("Disclosure 1 Choice")]
    public abstract record Disclosure1Choice_ { }
}
