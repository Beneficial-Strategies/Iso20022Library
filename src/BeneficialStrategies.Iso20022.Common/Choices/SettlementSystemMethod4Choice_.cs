// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement system/method.
    /// </summary>
    [KnownType(typeof(SettlementSystemMethod4Choice.Code))]
    [KnownType(typeof(SettlementSystemMethod4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementSystemMethod4Choice.Code),
        nameof(SettlementSystemMethod4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementSystemMethod4Choice.Proprietary),
        nameof(SettlementSystemMethod4Choice.Proprietary)
    )]
    [IsoId("_R9Xe8TqIEeWVrPy0StzzSg")]
    [DisplayName("Settlement System Method 4 Choice")]
    public abstract record SettlementSystemMethod4Choice_ { }
}
