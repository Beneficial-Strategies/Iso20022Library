// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType14Choice.Code))]
    [KnownType(typeof(RepurchaseType14Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType14Choice.Code), nameof(RepurchaseType14Choice.Code))]
    [JsonDerivedType(
        typeof(RepurchaseType14Choice.Proprietary),
        nameof(RepurchaseType14Choice.Proprietary)
    )]
    [IsoId("_IhOYwTtFEeWRTLSN0i0tng")]
    [DisplayName("Repurchase Type 14 Choice")]
    public abstract record RepurchaseType14Choice_ { }
}
