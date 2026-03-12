// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio1Choice
{
    /// <summary>
    /// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt &apos;wrappers&apos; in which equities, bonds and funds can be held to shelter them from various types of tax.
    /// In the UK, a typical tax wrapper product is known as an &apos;ISA&apos; (Individual Savings Account).
    /// </summary>
    [IsoId("_ibqr0U4HEeiQHa-q1Uephw")]
    [DisplayName("Tax Efficient Product")]
    public partial record TaxEfficientProduct : FundPortfolio1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
        /// </summary>
        [IsoId("_-BnMwE4KEeiQHa-q1Uephw")]
        [DisplayName("Tax Efficient Product Type")]
        [IsoXmlTag("TaxEffcntPdctTp")]
        public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; } 
        
        /// <summary>
        /// Investment plans issued during previous years.
        /// </summary>
        [IsoId("_xRJK904KEeiQHa-q1Uephw")]
        [DisplayName("Previous Years")]
        [IsoXmlTag("PrvsYrs")]
        public PreviousYear2Choice_? PreviousYears { get; init; } 
        
        /// <summary>
        /// Indicates that the product was issued during the current fiscal year.
        /// </summary>
        [IsoId("_xRJK9U4KEeiQHa-q1Uephw")]
        [DisplayName("Current Year")]
        [IsoXmlTag("CurYr")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? CurrentYear { get; init; } 
        
        /// <summary>
        /// Additional information about the tax efficient product.
        /// </summary>
        [IsoId("_DlX7IV3AEeiFXdiLi_Nf4A")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
