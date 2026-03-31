// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IssuerOrInvestor2Choice
{
    /// <summary>
    /// Investor CSD.
    /// </summary>
    [DisplayName("Investor CSD")]
    public record InvestorCSD : IssuerOrInvestor2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("InvstrCSD")]
        public required SystemPartyIdentification2Choice_ Value { get; init; }
    }
}
