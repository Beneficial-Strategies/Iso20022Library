// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the incorrect data type.
    /// </summary>
    [KnownType(typeof(IncorrectData1Choice.Code))]
    [KnownType(typeof(IncorrectData1Choice.Proprietary))]
    [JsonDerivedType(typeof(IncorrectData1Choice.Code), nameof(IncorrectData1Choice.Code))]
    [JsonDerivedType(
        typeof(IncorrectData1Choice.Proprietary),
        nameof(IncorrectData1Choice.Proprietary)
    )]
    [IsoId("_Dfigo9jLEeq5MfBBxQig1Q")]
    [DisplayName("Incorrect Data 1 Choice")]
    public abstract record IncorrectData1Choice_ { }
}
