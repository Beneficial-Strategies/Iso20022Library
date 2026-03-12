// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the information type format required.
    /// </summary>
    [KnownType(typeof(InformationTypeFormat1Choice.Code))]
    [KnownType(typeof(InformationTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(InformationTypeFormat1Choice.Code),nameof(InformationTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(InformationTypeFormat1Choice.Proprietary),nameof(InformationTypeFormat1Choice.Proprietary))]
    [IsoId("__SFAwCXaEeOFIcNWlDEvdQ")]
    [DisplayName("Information Type Format 1 Choice")]
    public abstract partial record InformationTypeFormat1Choice_
    {
    }
}
