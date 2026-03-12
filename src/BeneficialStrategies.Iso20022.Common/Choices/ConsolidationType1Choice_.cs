// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of consolidation.
    /// </summary>
    [KnownType(typeof(ConsolidationType1Choice.Code))]
    [KnownType(typeof(ConsolidationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ConsolidationType1Choice.Code),nameof(ConsolidationType1Choice.Code))]
    [JsonDerivedType(typeof(ConsolidationType1Choice.Proprietary),nameof(ConsolidationType1Choice.Proprietary))]
    [IsoId("_NJKKkCDVEeWCLu74WLgP4w")]
    [DisplayName("Consolidation Type 1 Choice")]
    public abstract partial record ConsolidationType1Choice_
    {
    }
}
