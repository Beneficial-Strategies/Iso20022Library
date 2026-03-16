// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification75Choice
{
    /// <summary>
    /// Accounts List.
    /// </summary>
    [DisplayName("Accounts List")]
    public record AccountsList : AccountIdentification75Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AcctsList")]
        public required AccountIdentification75 Value { get; init; }
    }
}
