// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingMethod1Choice
{
    /// <summary>
    /// Tax values are based on tax calculation method B.
    /// </summary>
    [IsoId("_6P9Ds5qlEeGSON8vddiWzQ_1047988105")]
    [DisplayName("Method B")]
    public record MethodB : BillingMethod1Choice_
    {
        /// <summary>
        /// Amount of the original charge expressed in the host currency.
        /// </summary>
        [IsoId("_6P9DtpqlEeGSON8vddiWzQ_-1342564280")]
        [DisplayName("Service Charge Host Amount")]
        [IsoXmlTag("SvcChrgHstAmt")]
        public required AmountAndDirection34 ServiceChargeHostAmount { get; init; }

        /// <summary>
        /// Provides for the regional taxes on the service. Up to three regional taxes may be defined for the same service.
        /// </summary>
        [IsoId("_6P9Dt5qlEeGSON8vddiWzQ_1918530298")]
        [DisplayName("Service Tax")]
        [IsoXmlTag("SvcTax")]
        public required BillingServicesAmount1 ServiceTax { get; init; }

        /// <summary>
        /// Provides for the specific tax identification within the same tax region.
        /// Usage: This element allows for a maximum of three regional taxes on the same service.
        /// </summary>
        [IsoId("_6P9DuJqlEeGSON8vddiWzQ_1610375494")]
        [DisplayName("Tax Identification")]
        [IsoXmlTag("TaxId")]
        [MinLength(1)]
        [MaxLength(3)]
        public ValueList<BillingServicesTax1> TaxIdentification { get; init; } = [];
    }
}
