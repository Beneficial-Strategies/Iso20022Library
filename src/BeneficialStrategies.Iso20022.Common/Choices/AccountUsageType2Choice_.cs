// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of account usage.
    /// </summary>
    [KnownType(typeof(AccountUsageType2Choice.Code))]
    [KnownType(typeof(AccountUsageType2Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountUsageType2Choice.Code), nameof(AccountUsageType2Choice.Code))]
    [JsonDerivedType(
        typeof(AccountUsageType2Choice.Proprietary),
        nameof(AccountUsageType2Choice.Proprietary)
    )]
    [IsoId("_K-b04b-FEeWfsa741pI6WA")]
    [DisplayName("Account Usage Type 2 Choice")]
    public abstract record AccountUsageType2Choice_ { }
}
