// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of processing restrictions.
    /// </summary>
    [KnownType(typeof(ProcessingType1Choice.Code))]
    [KnownType(typeof(ProcessingType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingType1Choice.Code), nameof(ProcessingType1Choice.Code))]
    [JsonDerivedType(
        typeof(ProcessingType1Choice.Proprietary),
        nameof(ProcessingType1Choice.Proprietary)
    )]
    [IsoId("_705FQqMgEeCJ6YNENx4h-w_1984754535")]
    [DisplayName("Processing Type 1 Choice")]
    public abstract record ProcessingType1Choice_ { }
}
