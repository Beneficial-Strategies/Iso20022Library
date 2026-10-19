// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason16Choice
{
    /// <summary>
    /// Specifies the reason why the request was denied.
    /// </summary>
    [IsoId("_kYkAeznvEeWfSKvvZlhRKg")]
    [DisplayName("Denied Reason")]
    public partial record DeniedReason : Reason16Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DndRsn")]
        public required DeniedReason14Choice_ Value { get; init; }
    }
}
