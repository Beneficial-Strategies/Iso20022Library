// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the ModificationCancellation information.
    /// </summary>
    [KnownType(typeof(ModificationCancellationAllowed3Choice.Indicator))]
    [KnownType(typeof(ModificationCancellationAllowed3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModificationCancellationAllowed3Choice.Indicator),
        nameof(ModificationCancellationAllowed3Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(ModificationCancellationAllowed3Choice.Proprietary),
        nameof(ModificationCancellationAllowed3Choice.Proprietary)
    )]
    [IsoId("_AYz-E9okEeC60axPepSq7g_1104436379")]
    [DisplayName("Modification Cancellation Allowed 3 Choice")]
    public abstract record ModificationCancellationAllowed3Choice_ { }
}
