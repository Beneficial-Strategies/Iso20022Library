// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the data used to identify the branch of a reporting counterparty.
    /// </summary>
    [KnownType(typeof(Branch2Choice.Identification))]
    [KnownType(typeof(Branch2Choice.Country))]
    [JsonDerivedType(typeof(Branch2Choice.Identification), nameof(Branch2Choice.Identification))]
    [JsonDerivedType(typeof(Branch2Choice.Country), nameof(Branch2Choice.Country))]
    [IsoId("_6O2VwUqQEeeLKviVB0vAnA")]
    [DisplayName("Branch 2 Choice")]
    public abstract record Branch2Choice_ { }
}
