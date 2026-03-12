// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the party reference data or an operational error.
    /// </summary>
    [KnownType(typeof(PartyOrOperationalError3Choice.PartyReport))]
    [KnownType(typeof(PartyOrOperationalError3Choice.OperationalError))]
    [JsonDerivedType(typeof(PartyOrOperationalError3Choice.PartyReport),nameof(PartyOrOperationalError3Choice.PartyReport))]
    [JsonDerivedType(typeof(PartyOrOperationalError3Choice.OperationalError),nameof(PartyOrOperationalError3Choice.OperationalError))]
    [IsoId("_7VYvRVhLEeih3fUfzR38Ig")]
    [DisplayName("Party Or Operational Error 3 Choice")]
    public abstract partial record PartyOrOperationalError3Choice_
    {
    }
}
