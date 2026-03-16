// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType23Choice.Code))]
    [KnownType(typeof(RepurchaseType23Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType23Choice.Code), nameof(RepurchaseType23Choice.Code))]
    [JsonDerivedType(
        typeof(RepurchaseType23Choice.Proprietary),
        nameof(RepurchaseType23Choice.Proprietary)
    )]
    [IsoId("_ATHRgY-VEeaVK-2bgpxeYw")]
    [DisplayName("Repurchase Type 23 Choice")]
    public abstract record RepurchaseType23Choice_ { }
}
