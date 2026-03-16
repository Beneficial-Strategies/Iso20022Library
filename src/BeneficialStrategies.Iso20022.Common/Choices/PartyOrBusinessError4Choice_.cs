// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Or Business Error4Choice.
    /// </summary>
    [KnownType(typeof(PartyOrBusinessError4Choice.BusinessError))]
    [KnownType(typeof(PartyOrBusinessError4Choice.SystemParty))]
    [JsonDerivedType(typeof(PartyOrBusinessError4Choice.BusinessError),nameof(PartyOrBusinessError4Choice.BusinessError))]
    [JsonDerivedType(typeof(PartyOrBusinessError4Choice.SystemParty),nameof(PartyOrBusinessError4Choice.SystemParty))]
    [IsoId("_YS_-ZTE_Ee62xuUQ2zyZww")]
    [DisplayName("Party Or Business Error4Choice")]
    public abstract partial record PartyOrBusinessError4Choice_
    {
    }
}
