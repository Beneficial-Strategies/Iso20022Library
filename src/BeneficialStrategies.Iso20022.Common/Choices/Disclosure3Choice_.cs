// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Disclosure3Choice.
    /// </summary>
    [KnownType(typeof(Disclosure3Choice.NoDisclosure))]
    [KnownType(typeof(Disclosure3Choice.SafekeepingAccountAndHoldings))]
    [JsonDerivedType(typeof(Disclosure3Choice.NoDisclosure),nameof(Disclosure3Choice.NoDisclosure))]
    [JsonDerivedType(typeof(Disclosure3Choice.SafekeepingAccountAndHoldings),nameof(Disclosure3Choice.SafekeepingAccountAndHoldings))]
    [IsoId("_wl7OcVx7Ee6fgZt44_IqFA")]
    [DisplayName("Disclosure3Choice")]
    public abstract partial record Disclosure3Choice_
    {
    }
}
