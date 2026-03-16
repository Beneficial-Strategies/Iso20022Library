// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a meeting event identification or a meeting event official identification.
    /// </summary>
    [KnownType(typeof(MeetingEventReference1Choice.LinkedIssuerMeetingIdentification))]
    [KnownType(typeof(MeetingEventReference1Choice.LinkedMeetingIdentification))]
    [JsonDerivedType(
        typeof(MeetingEventReference1Choice.LinkedIssuerMeetingIdentification),
        nameof(MeetingEventReference1Choice.LinkedIssuerMeetingIdentification)
    )]
    [JsonDerivedType(
        typeof(MeetingEventReference1Choice.LinkedMeetingIdentification),
        nameof(MeetingEventReference1Choice.LinkedMeetingIdentification)
    )]
    [IsoId("__b3CGa7rEemG7MmivSuE5g")]
    [DisplayName("Meeting Event Reference 1 Choice")]
    public abstract record MeetingEventReference1Choice_ { }
}
