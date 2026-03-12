// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the type of event in a series of predefined or planned events.
    /// </summary>
    [KnownType(typeof(EventSequenceTypeFormat2Choice.Code))]
    [KnownType(typeof(EventSequenceTypeFormat2Choice.Proprietary))]
    [JsonDerivedType(typeof(EventSequenceTypeFormat2Choice.Code),nameof(EventSequenceTypeFormat2Choice.Code))]
    [JsonDerivedType(typeof(EventSequenceTypeFormat2Choice.Proprietary),nameof(EventSequenceTypeFormat2Choice.Proprietary))]
    [IsoId("_5yK74fyVEeiKOe8GCUL1Lg")]
    [DisplayName("Event Sequence Type Format 2 Choice")]
    public abstract partial record EventSequenceTypeFormat2Choice_
    {
    }
}
