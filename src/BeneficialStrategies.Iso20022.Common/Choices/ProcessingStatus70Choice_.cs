// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus70Choice.Code))]
    [KnownType(typeof(ProcessingStatus70Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus70Choice.Code),nameof(ProcessingStatus70Choice.Code))]
    [JsonDerivedType(typeof(ProcessingStatus70Choice.Proprietary),nameof(ProcessingStatus70Choice.Proprietary))]
    [IsoId("_mLAX4eGHEeWCAvUNsZ5u6g")]
    [DisplayName("Processing Status 70 Choice")]
    public abstract partial record ProcessingStatus70Choice_
    {
    }
}
