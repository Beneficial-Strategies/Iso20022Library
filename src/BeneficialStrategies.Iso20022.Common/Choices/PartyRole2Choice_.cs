// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the role.
    /// </summary>
    [KnownType(typeof(PartyRole2Choice.Code))]
    [KnownType(typeof(PartyRole2Choice.Proprietary))]
    [JsonDerivedType(typeof(PartyRole2Choice.Code),nameof(PartyRole2Choice.Code))]
    [JsonDerivedType(typeof(PartyRole2Choice.Proprietary),nameof(PartyRole2Choice.Proprietary))]
    [IsoId("__f4MkRUNEeOIaq8KyCdIDQ")]
    [DisplayName("Party Role 2 Choice")]
    public abstract partial record PartyRole2Choice_
    {
    }
}
