// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification8Choice
{
    /// <summary>
    /// Proprietary Identification.
    /// </summary>
    [DisplayName("Proprietary Identification")]
    public record ProprietaryIdentification : PaymentIdentification8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrtryId")]
        public required IsoMax70Text Value { get; init; }
    }
}
