// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemEventType4Choice
{
    /// <summary>
    /// Type of system event that has occurred, expressed in a coded form.
    /// </summary>
    [IsoId("_eFPKI3hkEeidzqjNEfehPg")]
    [DisplayName("Code")]
    public record Code : SystemEventType4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type an event generated within a system, as published in an system event type code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalSystemEventType1Code Value { get; init; }
    }
}
