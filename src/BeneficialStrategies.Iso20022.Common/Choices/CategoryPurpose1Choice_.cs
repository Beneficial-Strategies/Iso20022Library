// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="ICategoryPurpose1Choice"/>
    [KnownType(typeof(CategoryPurpose1Choice.Code))]
    [KnownType(typeof(CategoryPurpose1Choice.Proprietary))]
    [JsonDerivedType(typeof(CategoryPurpose1Choice.Code), nameof(CategoryPurpose1Choice.Code))]
    [JsonDerivedType(
        typeof(CategoryPurpose1Choice.Proprietary),
        nameof(CategoryPurpose1Choice.Proprietary)
    )]
    [IsoId("_THaa5Np-Ed-ak6NoX_4Aeg_1223014142")]
    [DisplayName("Category Purpose 1 Choice")]
    public abstract partial record CategoryPurpose1Choice_ { }
}
