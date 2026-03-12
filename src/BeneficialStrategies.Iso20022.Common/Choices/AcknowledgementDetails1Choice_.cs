// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference of the PayInSchedule or the PayInCall being acknowledged. This is the Message Identification element from the Report Data sequence of the Pay In Schedule message or the Pay In Call message.
    /// </summary>
    [KnownType(typeof(AcknowledgementDetails1Choice.PayInScheduleReference))]
    [KnownType(typeof(AcknowledgementDetails1Choice.PayInCallReference))]
    [JsonDerivedType(typeof(AcknowledgementDetails1Choice.PayInScheduleReference),nameof(AcknowledgementDetails1Choice.PayInScheduleReference))]
    [JsonDerivedType(typeof(AcknowledgementDetails1Choice.PayInCallReference),nameof(AcknowledgementDetails1Choice.PayInCallReference))]
    [IsoId("_oIaocSzSEeKZfox_pyYpTA")]
    [DisplayName("Acknowledgement Details 1 Choice")]
    public abstract partial record AcknowledgementDetails1Choice_
    {
    }
}
