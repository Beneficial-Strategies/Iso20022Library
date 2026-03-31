// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification70Choice
{
    /// <summary>
    /// For All Accounts.
    /// </summary>
    [DisplayName("For All Accounts")]
    public record ForAllAccounts : AccountIdentification70Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ForAllAccts")]
        public required AccountIdentification10 Value { get; init; }
    }
}
