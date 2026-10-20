// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason6Choice
{
    /// <summary>
    /// Specifies the reason why the request was denied.
    /// </summary>
    [IsoId("_itAn9EAAEeCaq78Ig8ATcA")]
    [DisplayName("Denied Reason")]
    public partial record DeniedReason : Reason6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DndRsn")]
        public required DeniedReason1Choice_ Value { get; init; }
    }
}
