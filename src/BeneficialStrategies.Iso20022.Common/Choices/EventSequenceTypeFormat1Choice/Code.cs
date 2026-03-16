// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventSequenceTypeFormat1Choice
{
    /// <summary>
    /// Type of an event sequence, in a coded format.
    /// </summary>
    [IsoId("_jkjDILXIEeiTob_PrFFUxA")]
    [DisplayName("Code")]
    public record Code : EventSequenceTypeFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the event is an interim or a final event in a series of successive events.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EventSequenceType1Code Value { get; init; }
    }
}
