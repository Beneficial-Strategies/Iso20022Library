// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemEventType2Choice
{
    /// <summary>
    /// Type of system event that has occurred, expressed in a coded form.
    /// </summary>
    [IsoId("_72FYEKMgEeCJ6YNENx4h-w_1131843970")]
    [DisplayName("Code")]
    public record Code : SystemEventType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of event related to a system&apos;s operation.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SystemEventType2Code Value { get; init; }
    }
}
