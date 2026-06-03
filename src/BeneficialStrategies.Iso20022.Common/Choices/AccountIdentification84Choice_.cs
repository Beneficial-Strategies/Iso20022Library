// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the name and identification of an account.
    /// </summary>
    [KnownType(typeof(AccountIdentification84Choice.Identification))]
    [KnownType(typeof(AccountIdentification84Choice.Name))]
    [JsonDerivedType(typeof(AccountIdentification84Choice.Identification), nameof(AccountIdentification84Choice.Identification))]
    [JsonDerivedType(typeof(AccountIdentification84Choice.Name), nameof(AccountIdentification84Choice.Name))]
    [IsoId("_dADsIanOEfC5VNwixU6YfQ")]
    [DisplayName("AccountIdentification84Choice")]
    public abstract record AccountIdentification84Choice_ { }
}
