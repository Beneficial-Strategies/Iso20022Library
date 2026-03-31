// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionType2Choice
{
    /// <summary>
    /// Transaction type expressed as a code.
    /// </summary>
    [IsoId("_sVSKAQf_EeSaceXTzyiZRg")]
    [DisplayName("Type")]
    public record Type : TransactionType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of transaction.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required TransactionType2Code Value { get; init; }
    }
}
