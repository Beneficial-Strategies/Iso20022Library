// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Closure reason expressed as a code or a bilaterally agreed code.
    /// </summary>
    [KnownType(typeof(ClosureReason2Choice.Code))]
    [KnownType(typeof(ClosureReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(ClosureReason2Choice.Code), nameof(ClosureReason2Choice.Code))]
    [JsonDerivedType(
        typeof(ClosureReason2Choice.Proprietary),
        nameof(ClosureReason2Choice.Proprietary)
    )]
    [IsoId("_72rN8KMgEeCJ6YNENx4h-w_-681649909")]
    [DisplayName("Closure Reason 2 Choice")]
    public abstract record ClosureReason2Choice_ { }
}
