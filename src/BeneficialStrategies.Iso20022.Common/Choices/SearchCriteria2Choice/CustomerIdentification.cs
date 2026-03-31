// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria2Choice
{
    /// <summary>
    /// Customer Identification.
    /// </summary>
    [DisplayName("Customer Identification")]
    public record CustomerIdentification : SearchCriteria2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CstmrId")]
        public required CustomerIdentification2 Value { get; init; }
    }
}
