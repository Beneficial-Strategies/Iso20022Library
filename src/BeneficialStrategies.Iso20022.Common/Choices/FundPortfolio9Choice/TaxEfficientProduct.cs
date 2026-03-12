// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio9Choice
{
    /// <summary>
    /// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt &apos;wrappers&apos; in which equities, bonds and funds can be held to shelter them from various types of tax.
    /// In the UK, a typical tax wrapper product is known as an &apos;ISA&apos; (Individual Savings Account).
    /// </summary>
    [IsoId("_ZYn_welqEeuvhrZwLF0fDg")]
    [DisplayName("Tax Efficient Product")]
    public partial record TaxEfficientProduct : FundPortfolio9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
        /// </summary>
        [IsoId("_PogP4ZNNEemQB_8XA98K0Q")]
        [DisplayName("Tax Efficient Product Type")]
        [IsoXmlTag("TaxEffcntPdctTp")]
        public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
        
        /// <summary>
        /// Indicates that all the current fiscal year’s products are to be included.
        /// </summary>
        [IsoId("_PogP5ZNNEemQB_8XA98K0Q")]
        [DisplayName("Current Year")]
        [IsoXmlTag("CurYr")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? CurrentYear { get; init; } 
        
        /// <summary>
        /// Investment plans issued during previous years.
        /// </summary>
        [IsoId("_PogP45NNEemQB_8XA98K0Q")]
        [DisplayName("Previous Years")]
        [IsoXmlTag("PrvsYrs")]
        public PreviousYear2Choice_? PreviousYears { get; init; } 
        
        /// <summary>
        /// Additional information about the tax efficient product.
        /// </summary>
        [IsoId("_PogP55NNEemQB_8XA98K0Q")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
