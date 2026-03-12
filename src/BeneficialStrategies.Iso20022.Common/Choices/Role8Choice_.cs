// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role8Choice.Code))]
    [KnownType(typeof(Role8Choice.Proprietary))]
    [JsonDerivedType(typeof(Role8Choice.Code),nameof(Role8Choice.Code))]
    [JsonDerivedType(typeof(Role8Choice.Proprietary),nameof(Role8Choice.Proprietary))]
    [IsoId("_hn_C8dyREeqKxsvOxFQHKA")]
    [DisplayName("Role 8 Choice")]
    public abstract partial record Role8Choice_
    {
    }
}
