// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IPurpose1Choice"/>
    [KnownType(typeof(Purpose1Choice.Code))]
    [KnownType(typeof(Purpose1Choice.Proprietary))]
    [JsonDerivedType(typeof(Purpose1Choice.Code), nameof(Purpose1Choice.Code))]
    [JsonDerivedType(typeof(Purpose1Choice.Proprietary), nameof(Purpose1Choice.Proprietary))]
    [IsoId("_PrK9gNp-Ed-ak6NoX_4Aeg_-891374754")]
    [DisplayName("Purpose 1 Choice")]
    public abstract partial record Purpose1Choice_ { }
}
