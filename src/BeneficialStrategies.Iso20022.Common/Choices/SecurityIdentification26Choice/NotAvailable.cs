// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification26Choice
{
    /// <summary>
    /// Default value, when not identification is available.
    /// </summary>
    [IsoId("_OQJ8k47DEeaxxtxaoOwzAg")]
    [DisplayName("Not Available")]
    public record NotAvailable : SecurityIdentification26Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a not available value code.
        /// </summary>
        [IsoXmlTag("NotAvlbl")]
        public required NotAvailable1Code Value { get; init; }
    }
}
