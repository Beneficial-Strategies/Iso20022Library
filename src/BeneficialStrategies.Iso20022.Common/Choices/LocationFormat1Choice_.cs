// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the formats to indicate the location of the meeting.
    /// </summary>
    [KnownType(typeof(LocationFormat1Choice.Address))]
    [KnownType(typeof(LocationFormat1Choice.LocationCode))]
    [JsonDerivedType(typeof(LocationFormat1Choice.Address),nameof(LocationFormat1Choice.Address))]
    [JsonDerivedType(typeof(LocationFormat1Choice.LocationCode),nameof(LocationFormat1Choice.LocationCode))]
    [IsoId("_RXD3l9p-Ed-ak6NoX_4Aeg_-341096000")]
    [DisplayName("Location Format 1 Choice")]
    public abstract partial record LocationFormat1Choice_
    {
    }
}
