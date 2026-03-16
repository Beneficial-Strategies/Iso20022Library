// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateFrequency2Choice
{
    /// <summary>
    /// Frequency expressed in tenor notation.
    /// </summary>
    [IsoId("_mNON4fOFEeaS7fYULSI4_Q")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public record Term : InterestRateFrequency2Choice_
    {
        /// <summary>
        /// Unit for the rate basis.
        /// </summary>
        [IsoId("_sO0L0exREeakeva4q26Yqg")]
        [DisplayName("Unit")]
        [IsoXmlTag("Unit")]
        public RateBasis1Code? Unit { get; init; }

        /// <summary>
        /// Value of the contract term in number of units.
        /// </summary>
        [IsoId("_sO0L0-xREeakeva4q26Yqg")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.Max3Number)]
        public IsoMax3Number? Value { get; init; }
    }
}
