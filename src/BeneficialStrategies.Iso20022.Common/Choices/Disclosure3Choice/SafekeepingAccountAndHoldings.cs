// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Disclosure3Choice
{
    /// <summary>
    /// Safekeeping Account And Holdings.
    /// </summary>
    [DisplayName("Safekeeping Account And Holdings")]
    public record SafekeepingAccountAndHoldings : Disclosure3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("SfkpgAcctAndHldgs")]
        public required SafekeepingAccount17 Value { get; init; }
    }
}
