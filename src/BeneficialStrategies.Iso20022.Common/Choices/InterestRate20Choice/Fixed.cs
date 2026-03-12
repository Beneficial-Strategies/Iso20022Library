// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestRate20Choice
{
    /// <summary>
    /// Details of the fixed rate.
    /// </summary>
    [IsoId("_hFv8Eax2Eem81-uIvTF5rQ")]
    [DisplayName("Fixed")]
    public partial record Fixed : InterestRate20Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Annualised interest rate on the principal amount of the repurchase transaction in accordance with the day count convention.
        /// </summary>
        [IsoId("_g04ioayDEem81-uIvTF5rQ")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? Rate { get; init; } 
        
        /// <summary>
        /// Method for calculating the accrued interest on the principal amount for a fixed rate.
        /// </summary>
        [IsoId("_g04io6yDEem81-uIvTF5rQ")]
        [DisplayName("Day Count Basis")]
        [IsoXmlTag("DayCntBsis")]
        public InterestComputationMethodFormat6Choice_? DayCountBasis { get; init; } 
        
        
        #nullable disable
        
    }
}
