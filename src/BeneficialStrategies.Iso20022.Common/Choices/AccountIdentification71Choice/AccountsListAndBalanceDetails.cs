// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification71Choice
{
    /// <summary>
    /// Accounts List And Balance Details.
    /// </summary>
    [DisplayName("Accounts List And Balance Details")]
    public record AccountsListAndBalanceDetails : AccountIdentification71Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AcctsListAndBalDtls")]
        public required AccountAndBalance60 Value { get; init; }
    }
}
