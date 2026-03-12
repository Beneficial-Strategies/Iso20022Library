// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the modification cancellation information.
    /// </summary>
    [KnownType(typeof(ModificationCancellationAllowed4Choice.Indicator))]
    [KnownType(typeof(ModificationCancellationAllowed4Choice.Proprietary))]
    [JsonDerivedType(typeof(ModificationCancellationAllowed4Choice.Indicator),nameof(ModificationCancellationAllowed4Choice.Indicator))]
    [JsonDerivedType(typeof(ModificationCancellationAllowed4Choice.Proprietary),nameof(ModificationCancellationAllowed4Choice.Proprietary))]
    [IsoId("_421HATtFEeWRTLSN0i0tng")]
    [DisplayName("Modification Cancellation Allowed 4 Choice")]
    public abstract partial record ModificationCancellationAllowed4Choice_
    {
    }
}
