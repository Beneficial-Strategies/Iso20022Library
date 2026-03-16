// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of characters to be matched to be considered as valid.
    /// </summary>
    [KnownType(typeof(CharacterSearch1Choice.Equal))]
    [KnownType(typeof(CharacterSearch1Choice.NotEqual))]
    [KnownType(typeof(CharacterSearch1Choice.Contain))]
    [KnownType(typeof(CharacterSearch1Choice.NotContain))]
    [JsonDerivedType(typeof(CharacterSearch1Choice.Equal), nameof(CharacterSearch1Choice.Equal))]
    [JsonDerivedType(
        typeof(CharacterSearch1Choice.NotEqual),
        nameof(CharacterSearch1Choice.NotEqual)
    )]
    [JsonDerivedType(
        typeof(CharacterSearch1Choice.Contain),
        nameof(CharacterSearch1Choice.Contain)
    )]
    [JsonDerivedType(
        typeof(CharacterSearch1Choice.NotContain),
        nameof(CharacterSearch1Choice.NotContain)
    )]
    [IsoId("_F7k20ZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Character Search 1 Choice")]
    public abstract record CharacterSearch1Choice_ { }
}
