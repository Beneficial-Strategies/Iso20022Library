// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType22Choice.Code))]
    [KnownType(typeof(RepurchaseType22Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType22Choice.Code), nameof(RepurchaseType22Choice.Code))]
    [JsonDerivedType(
        typeof(RepurchaseType22Choice.Proprietary),
        nameof(RepurchaseType22Choice.Proprietary)
    )]
    [IsoId("_w61AQY-REeaVK-2bgpxeYw")]
    [DisplayName("Repurchase Type 22 Choice")]
    public abstract record RepurchaseType22Choice_ { }
}
