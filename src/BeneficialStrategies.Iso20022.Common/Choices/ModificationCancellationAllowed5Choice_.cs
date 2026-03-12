// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the modification cancellation information.
    /// </summary>
    [KnownType(typeof(ModificationCancellationAllowed5Choice.Indicator))]
    [KnownType(typeof(ModificationCancellationAllowed5Choice.Proprietary))]
    [JsonDerivedType(typeof(ModificationCancellationAllowed5Choice.Indicator),nameof(ModificationCancellationAllowed5Choice.Indicator))]
    [JsonDerivedType(typeof(ModificationCancellationAllowed5Choice.Proprietary),nameof(ModificationCancellationAllowed5Choice.Proprietary))]
    [IsoId("_6dr4i5NLEeWGlc8L7oPDIg")]
    [DisplayName("Modification Cancellation Allowed 5 Choice")]
    public abstract partial record ModificationCancellationAllowed5Choice_
    {
    }
}
