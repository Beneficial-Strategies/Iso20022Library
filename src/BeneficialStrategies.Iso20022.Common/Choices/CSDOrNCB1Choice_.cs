// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a central securities depositary or a national central bank for querying party reference data.
    /// </summary>
    [KnownType(typeof(CSDOrNCB1Choice.CSDIdentification))]
    [KnownType(typeof(CSDOrNCB1Choice.NCBIdentification))]
    [JsonDerivedType(typeof(CSDOrNCB1Choice.CSDIdentification),nameof(CSDOrNCB1Choice.CSDIdentification))]
    [JsonDerivedType(typeof(CSDOrNCB1Choice.NCBIdentification),nameof(CSDOrNCB1Choice.NCBIdentification))]
    [IsoId("_knY98O5NEeCisYr99QEiWA_761515761")]
    [DisplayName("CSD Or NCB 1 Choice")]
    public abstract partial record CSDOrNCB1Choice_
    {
    }
}
