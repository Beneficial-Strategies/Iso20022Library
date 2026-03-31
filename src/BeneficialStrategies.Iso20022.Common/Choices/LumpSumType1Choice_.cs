// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of lump sum.
    /// </summary>
    [KnownType(typeof(LumpSumType1Choice.Code))]
    [KnownType(typeof(LumpSumType1Choice.Proprietary))]
    [JsonDerivedType(typeof(LumpSumType1Choice.Code), nameof(LumpSumType1Choice.Code))]
    [JsonDerivedType(
        typeof(LumpSumType1Choice.Proprietary),
        nameof(LumpSumType1Choice.Proprietary)
    )]
    [IsoId("_AB4QYLKdEeiXL6Ccd-oU8g")]
    [DisplayName("Lump Sum Type 1 Choice")]
    public abstract record LumpSumType1Choice_ { }
}
