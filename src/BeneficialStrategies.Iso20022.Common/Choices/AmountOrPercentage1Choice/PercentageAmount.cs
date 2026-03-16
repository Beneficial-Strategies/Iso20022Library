// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrPercentage1Choice
{
    /// <summary>
    /// Details related to an amount percentage.
    /// </summary>
    [IsoId("_986x6HltEeG7BsjMvd1mEw_-131852339")]
    [DisplayName("Percentage Amount")]
    [IsoXmlTag("PctgAmt")]
    public record PercentageAmount : AmountOrPercentage1Choice_
    {
        /// <summary>
        /// Percentage of an amount.
        /// </summary>
        [IsoId("_99Ei53ltEeG7BsjMvd1mEw_-1531427799")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Rate { get; init; }

        /// <summary>
        /// Indication of what the percentage is relative to.
        /// </summary>
        [IsoId("_99Ei6HltEeG7BsjMvd1mEw_880195488")]
        [DisplayName("Relative To")]
        [IsoXmlTag("RltvTo")]
        public required ExternalRelativeTo1Code RelativeTo { get; init; }
    }
}
