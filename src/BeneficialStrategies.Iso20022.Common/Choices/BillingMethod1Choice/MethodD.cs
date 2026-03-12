// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BillingMethod1Choice
{
    /// <summary>
    /// Tax values are based on tax calculation method D.
    /// </summary>
    [IsoId("_6P9DtJqlEeGSON8vddiWzQ_1766081075")]
    [DisplayName("Method D")]
    public partial record MethodD : BillingMethod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Equivalent amount to the service tax host amount but allows the sender to optionally express the value in the pricing currency.
        /// </summary>
        [IsoId("_6QGNoZqlEeGSON8vddiWzQ_-823441647")]
        [DisplayName("Service Tax Price Amount")]
        [IsoXmlTag("SvcTaxPricAmt")]
        public required AmountAndDirection34 ServiceTaxPriceAmount { get; init; } 
        
        /// <summary>
        /// Provides for the specific tax identification within the same tax region. 
        /// Usage: This element allows for a maximum of three regional taxes on the same service.
        /// </summary>
        [IsoId("_6QGNopqlEeGSON8vddiWzQ_480308590")]
        [DisplayName("Tax Identification")]
        [IsoXmlTag("TaxId")]
        [MinLength(1)]
        [MaxLength(3)]
        public ValueList<BillingServicesTax2> TaxIdentification { get; init; } = new ValueList<BillingServicesTax2>(){};
        
        
        #nullable disable
        
    }
}
