// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType17Choice.Code))]
    [KnownType(typeof(RepurchaseType17Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType17Choice.Code), nameof(RepurchaseType17Choice.Code))]
    [JsonDerivedType(
        typeof(RepurchaseType17Choice.Proprietary),
        nameof(RepurchaseType17Choice.Proprietary)
    )]
    [IsoId("_6Id1k5NLEeWGlc8L7oPDIg")]
    [DisplayName("Repurchase Type 17 Choice")]
    public abstract record RepurchaseType17Choice_ { }
}
