// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio3Choice
{
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax.
    /// The Individual Savings Account (ISA) is provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_L26-t_sqEeCXvelB0HU7AQ")]
    [DisplayName("ISA")]
    public record ISA : ISAPortfolio3Choice_
    {
        /// <summary>
        /// ISA that was issued during the current fiscal year.
        /// </summary>
        [IsoId("_3gqDQEXfEeGY6MkiuzuPOA_-1966733702")]
        [DisplayName("Current Year")]
        [IsoXmlTag("CurYr")]
        public CurrentYearType2Choice_? CurrentYear { get; init; }

        /// <summary>
        /// Selection of investment plans issued during previous years.
        /// </summary>
        [IsoId("_3gqDQUXfEeGY6MkiuzuPOA_334088888")]
        [DisplayName("Previous Years")]
        [IsoXmlTag("PrvsYrs")]
        public PreviousYearChoice_? PreviousYears { get; init; }
    }
}
