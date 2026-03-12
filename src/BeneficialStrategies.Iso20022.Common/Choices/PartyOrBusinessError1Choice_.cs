// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the party reference data or a business error.
    /// </summary>
    [KnownType(typeof(PartyOrBusinessError1Choice.BusinessError))]
    [KnownType(typeof(PartyOrBusinessError1Choice.SystemParty))]
    [JsonDerivedType(typeof(PartyOrBusinessError1Choice.BusinessError),nameof(PartyOrBusinessError1Choice.BusinessError))]
    [JsonDerivedType(typeof(PartyOrBusinessError1Choice.SystemParty),nameof(PartyOrBusinessError1Choice.SystemParty))]
    [IsoId("_knr44-5NEeCisYr99QEiWA_102228919")]
    [DisplayName("Party Or Business Error 1 Choice")]
    public abstract partial record PartyOrBusinessError1Choice_
    {
    }
}
