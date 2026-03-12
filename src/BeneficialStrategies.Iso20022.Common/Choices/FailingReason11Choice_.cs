// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason11Choice.Code))]
    [KnownType(typeof(FailingReason11Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason11Choice.Code),nameof(FailingReason11Choice.Code))]
    [JsonDerivedType(typeof(FailingReason11Choice.Proprietary),nameof(FailingReason11Choice.Proprietary))]
    [IsoId("_6BKUI5NLEeWGlc8L7oPDIg")]
    [DisplayName("Failing Reason 11 Choice")]
    public abstract partial record FailingReason11Choice_
    {
    }
}
