// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason3Choice.Code))]
    [KnownType(typeof(FailingReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason3Choice.Code),nameof(FailingReason3Choice.Code))]
    [JsonDerivedType(typeof(FailingReason3Choice.Proprietary),nameof(FailingReason3Choice.Proprietary))]
    [IsoId("_K41SQRqFEeG38P9Gj2JZJw")]
    [DisplayName("Failing Reason 3 Choice")]
    public abstract partial record FailingReason3Choice_
    {
    }
}
