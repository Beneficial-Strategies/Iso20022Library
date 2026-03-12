// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the level of control.
    /// </summary>
    [KnownType(typeof(LevelOfControl1Choice.Code))]
    [KnownType(typeof(LevelOfControl1Choice.Proprietary))]
    [JsonDerivedType(typeof(LevelOfControl1Choice.Code),nameof(LevelOfControl1Choice.Code))]
    [JsonDerivedType(typeof(LevelOfControl1Choice.Proprietary),nameof(LevelOfControl1Choice.Proprietary))]
    [IsoId("_KcNhUCDDEeWPMvNwVtiMsA")]
    [DisplayName("Level Of Control 1 Choice")]
    public abstract partial record LevelOfControl1Choice_
    {
    }
}
