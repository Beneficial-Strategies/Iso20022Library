// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType19Choice.Code))]
    [KnownType(typeof(RepurchaseType19Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType19Choice.Code), nameof(RepurchaseType19Choice.Code))]
    [JsonDerivedType(
        typeof(RepurchaseType19Choice.Proprietary),
        nameof(RepurchaseType19Choice.Proprietary)
    )]
    [IsoId("_6SbqeZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repurchase Type 19 Choice")]
    public abstract record RepurchaseType19Choice_ { }
}
