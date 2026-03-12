// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the party reference data or an operational error.
    /// </summary>
    [KnownType(typeof(PartyOrOperationalError1Choice.PartyReport))]
    [KnownType(typeof(PartyOrOperationalError1Choice.OperationalError))]
    [JsonDerivedType(typeof(PartyOrOperationalError1Choice.PartyReport),nameof(PartyOrOperationalError1Choice.PartyReport))]
    [JsonDerivedType(typeof(PartyOrOperationalError1Choice.OperationalError),nameof(PartyOrOperationalError1Choice.OperationalError))]
    [IsoId("_kniH4-5NEeCisYr99QEiWA_-677861699")]
    [DisplayName("Party Or Operational Error 1 Choice")]
    public abstract partial record PartyOrOperationalError1Choice_
    {
    }
}
