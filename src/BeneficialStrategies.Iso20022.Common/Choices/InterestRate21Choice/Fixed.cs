// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestRate21Choice
{
    /// <summary>
    /// Attributes related specifically to fixed rate of an interest rate contract.
    /// </summary>
    [IsoId("_GPqvsQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Fixed")]
    public partial record Fixed : InterestRate21Choice_
    {
        #nullable enable
        
        /// <summary>
        /// An indication of the fixed rate used.
        /// </summary>
        [IsoId("_mY0Z4_OFEeaS7fYULSI4_Q")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? Rate { get; init; } 
        
        /// <summary>
        /// Actual number of days in the relevant fixed rate calculation period.
        /// </summary>
        [IsoId("_mY0Z5fOFEeaS7fYULSI4_Q")]
        [DisplayName("Day Count")]
        [IsoXmlTag("DayCnt")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? DayCount { get; init; } 
        
        /// <summary>
        /// Information related to payment frequency.
        /// </summary>
        [IsoId("_mY0Z5_OFEeaS7fYULSI4_Q")]
        [DisplayName("Payment Frequency")]
        [IsoXmlTag("PmtFrqcy")]
        public InterestRateFrequency2Choice_? PaymentFrequency { get; init; } 
        
        
        #nullable disable
        
    }
}
