// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the type of event in a series of predefined or planned events.
    /// </summary>
    [KnownType(typeof(EventSequenceTypeFormat1Choice.Code))]
    [KnownType(typeof(EventSequenceTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(EventSequenceTypeFormat1Choice.Code),nameof(EventSequenceTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(EventSequenceTypeFormat1Choice.Proprietary),nameof(EventSequenceTypeFormat1Choice.Proprietary))]
    [IsoId("_jkicELXIEeiTob_PrFFUxA")]
    [DisplayName("Event Sequence Type Format 1 Choice")]
    public abstract partial record EventSequenceTypeFormat1Choice_
    {
    }
}
