// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PortfolioCode1Choice
{
    /// <summary>
    /// Unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_KN8581fVEeqqKf65rDYWYw")]
    [DisplayName("Portfolio")]
    public record Portfolio : PortfolioCode1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 52 characters.
        /// </summary>
        [IsoXmlTag("Prtfl")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text Value { get; init; }
    }
}
