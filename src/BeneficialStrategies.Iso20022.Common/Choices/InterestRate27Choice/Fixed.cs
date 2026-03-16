// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate27Choice
{
    /// <summary>
    /// Details of the fixed rate.
    /// </summary>
    [IsoId("_Z-T6Ucg6Eeu4ecZgAYuz5w")]
    [DisplayName("Fixed")]
    [IsoXmlTag("Fxd")]
    public record Fixed : InterestRate27Choice_
    {
        /// <summary>
        /// Annualised interest rate on the principal amount of the repurchase transaction in accordance with the day count convention.
        /// </summary>
        [IsoId("_6GPnwa5qEeuo-IflVgGqiA")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? Rate { get; init; }

        /// <summary>
        /// Method for calculating the accrued interest on the principal amount for a fixed rate.
        /// </summary>
        [IsoId("_6GPnw65qEeuo-IflVgGqiA")]
        [DisplayName("Day Count Basis")]
        [IsoXmlTag("DayCntBsis")]
        public InterestComputationMethodFormat6Choice_? DayCountBasis { get; init; }
    }
}
