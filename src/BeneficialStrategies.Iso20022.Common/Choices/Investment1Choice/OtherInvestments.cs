// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Investment1Choice
{
    /// <summary>
    /// Indicates that the investment is not covered by other available investment options.
    /// </summary>
    [IsoId("_MRa04LLnEeavNMum-T1eEA")]
    [DisplayName("Other Investments")]
    [IsoXmlTag("OthrInvstmts")]
    public record OtherInvestments : Investment1Choice_
    {
        /// <summary>
        /// Text description of the investment.
        /// </summary>
        [IsoId("_YaCMgLLnEeavNMum-T1eEA")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text Description { get; init; }

        /// <summary>
        /// Value of the other investment.
        /// </summary>
        [IsoId("_b8JBULLnEeavNMum-T1eEA")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }
    }
}
