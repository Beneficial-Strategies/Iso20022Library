// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the source of the Foreign Account Tax Compliance Act (FATCA).
    /// </summary>
    [KnownType(typeof(FATCASource1Choice.Code))]
    [KnownType(typeof(FATCASource1Choice.Proprietary))]
    [JsonDerivedType(typeof(FATCASource1Choice.Code), nameof(FATCASource1Choice.Code))]
    [JsonDerivedType(
        typeof(FATCASource1Choice.Proprietary),
        nameof(FATCASource1Choice.Proprietary)
    )]
    [IsoId("_jR2x4QjUEeS5F6qHcKOrew")]
    [DisplayName("FATCA Source 1 Choice")]
    public abstract record FATCASource1Choice_ { }
}
