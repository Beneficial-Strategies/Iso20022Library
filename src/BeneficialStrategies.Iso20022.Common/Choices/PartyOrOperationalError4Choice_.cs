// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Or Operational Error4Choice.
    /// </summary>
    [KnownType(typeof(PartyOrOperationalError4Choice.OperationalError))]
    [KnownType(typeof(PartyOrOperationalError4Choice.PartyReport))]
    [JsonDerivedType(typeof(PartyOrOperationalError4Choice.OperationalError),nameof(PartyOrOperationalError4Choice.OperationalError))]
    [JsonDerivedType(typeof(PartyOrOperationalError4Choice.PartyReport),nameof(PartyOrOperationalError4Choice.PartyReport))]
    [IsoId("_YNzVUTE_Ee62xuUQ2zyZww")]
    [DisplayName("Party Or Operational Error4Choice")]
    public abstract partial record PartyOrOperationalError4Choice_
    {
    }
}
