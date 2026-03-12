// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a predefined code value or a proprietary code value for a general meeting voting participation method. 
    /// </summary>
    [KnownType(typeof(ParticipationMethod1Choice.Code))]
    [KnownType(typeof(ParticipationMethod1Choice.Proprietary))]
    [JsonDerivedType(typeof(ParticipationMethod1Choice.Code),nameof(ParticipationMethod1Choice.Code))]
    [JsonDerivedType(typeof(ParticipationMethod1Choice.Proprietary),nameof(ParticipationMethod1Choice.Proprietary))]
    [IsoId("_X1CUoK31EemG7MmivSuE5g")]
    [DisplayName("Participation Method 1 Choice")]
    public abstract partial record ParticipationMethod1Choice_
    {
    }
}
