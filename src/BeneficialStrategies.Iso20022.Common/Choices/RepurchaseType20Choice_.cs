// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType20Choice.Code))]
    [KnownType(typeof(RepurchaseType20Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType20Choice.Code), nameof(RepurchaseType20Choice.Code))]
    [JsonDerivedType(
        typeof(RepurchaseType20Choice.Proprietary),
        nameof(RepurchaseType20Choice.Proprietary)
    )]
    [IsoId("_6drRR5NLEeWGlc8L7oPDIg")]
    [DisplayName("Repurchase Type 20 Choice")]
    public abstract record RepurchaseType20Choice_ { }
}
