// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of meeting type classification.
    /// </summary>
    [KnownType(typeof(MeetingTypeClassification2Choice.Code))]
    [KnownType(typeof(MeetingTypeClassification2Choice.Proprietary))]
    [JsonDerivedType(typeof(MeetingTypeClassification2Choice.Code),nameof(MeetingTypeClassification2Choice.Code))]
    [JsonDerivedType(typeof(MeetingTypeClassification2Choice.Proprietary),nameof(MeetingTypeClassification2Choice.Proprietary))]
    [IsoId("_edv9767NEemG7MmivSuE5g")]
    [DisplayName("Meeting Type Classification 2 Choice")]
    public abstract partial record MeetingTypeClassification2Choice_
    {
    }
}
