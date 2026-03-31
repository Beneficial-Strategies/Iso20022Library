// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Investment2Choice
{
    /// <summary>
    /// Other Investments.
    /// </summary>
    [DisplayName("Other Investments")]
    public record OtherInvestments : Investment2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OthrInvstmts")]
        public required OtherInvestment1 Value { get; init; }
    }
}
