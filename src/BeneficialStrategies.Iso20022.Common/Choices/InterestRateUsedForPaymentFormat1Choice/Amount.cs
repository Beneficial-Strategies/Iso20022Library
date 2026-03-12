// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestRateUsedForPaymentFormat1Choice
{
    /// <summary>
    /// Number of monetary units specified in a currency.
    /// </summary>
    [IsoId("_UOySo9p-Ed-ak6NoX_4Aeg_-1208255471")]
    [DisplayName("Amount")]
    public partial record Amount : InterestRateUsedForPaymentFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YX4O9Np-Ed-ak6NoX_4Aeg_-184934550_Currency")]
        [DisplayName("Active Currency And 13 Decimal Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; } 
        
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoXmlTag("Amount")]
        public required System.Decimal Value { get; init; } 
        
        
        #nullable disable
        
    }
}
