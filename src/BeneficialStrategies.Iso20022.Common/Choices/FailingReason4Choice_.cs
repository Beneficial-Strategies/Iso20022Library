// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason4Choice.Code))]
    [KnownType(typeof(FailingReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason4Choice.Code),nameof(FailingReason4Choice.Code))]
    [JsonDerivedType(typeof(FailingReason4Choice.Proprietary),nameof(FailingReason4Choice.Proprietary))]
    [IsoId("_Iu4UcRqLEeG38P9Gj2JZJw")]
    [DisplayName("Failing Reason 4 Choice")]
    public abstract partial record FailingReason4Choice_
    {
    }
}
