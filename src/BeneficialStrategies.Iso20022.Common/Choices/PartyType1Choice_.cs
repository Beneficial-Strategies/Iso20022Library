// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of party.
    /// </summary>
    [KnownType(typeof(PartyType1Choice.Code))]
    [KnownType(typeof(PartyType1Choice.Proprietary))]
    [JsonDerivedType(typeof(PartyType1Choice.Code),nameof(PartyType1Choice.Code))]
    [JsonDerivedType(typeof(PartyType1Choice.Proprietary),nameof(PartyType1Choice.Proprietary))]
    [IsoId("_92zi0XltEeG7BsjMvd1mEw_-1440851436")]
    [DisplayName("Party Type 1 Choice")]
    public abstract partial record PartyType1Choice_
    {
    }
}
