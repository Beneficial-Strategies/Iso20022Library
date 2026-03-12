// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indication of no disclosure and the provision of shareholding disclosure information.
    /// </summary>
    [KnownType(typeof(Disclosure2Choice.NoDisclosure))]
    [KnownType(typeof(Disclosure2Choice.SafekeepingAccountAndHoldings))]
    [JsonDerivedType(typeof(Disclosure2Choice.NoDisclosure),nameof(Disclosure2Choice.NoDisclosure))]
    [JsonDerivedType(typeof(Disclosure2Choice.SafekeepingAccountAndHoldings),nameof(Disclosure2Choice.SafekeepingAccountAndHoldings))]
    [IsoId("_L3-v4fNyEeqRfth943bvEA")]
    [DisplayName("Disclosure 2 Choice")]
    public abstract partial record Disclosure2Choice_
    {
    }
}
