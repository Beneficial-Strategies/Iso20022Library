// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the business process type.
    /// </summary>
    [KnownType(typeof(BusinessProcessType1Choice.Code))]
    [KnownType(typeof(BusinessProcessType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BusinessProcessType1Choice.Code),
        nameof(BusinessProcessType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BusinessProcessType1Choice.Proprietary),
        nameof(BusinessProcessType1Choice.Proprietary)
    )]
    [IsoId("_AcY2hNokEeC60axPepSq7g_-749390701")]
    [DisplayName("Business Process Type 1 Choice")]
    public abstract record BusinessProcessType1Choice_ { }
}
