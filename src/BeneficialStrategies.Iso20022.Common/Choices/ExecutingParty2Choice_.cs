// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Executing Party2Choice.
    /// </summary>
    [KnownType(typeof(ExecutingParty2Choice.Algorithm))]
    [KnownType(typeof(ExecutingParty2Choice.Client))]
    [KnownType(typeof(ExecutingParty2Choice.Person))]
    [JsonDerivedType(
        typeof(ExecutingParty2Choice.Algorithm),
        nameof(ExecutingParty2Choice.Algorithm)
    )]
    [JsonDerivedType(typeof(ExecutingParty2Choice.Client), nameof(ExecutingParty2Choice.Client))]
    [JsonDerivedType(typeof(ExecutingParty2Choice.Person), nameof(ExecutingParty2Choice.Person))]
    [IsoId("_rtQugXDrEe2ynKFl65Hnmw")]
    [DisplayName("Executing Party2Choice")]
    public abstract record ExecutingParty2Choice_ { }
}
