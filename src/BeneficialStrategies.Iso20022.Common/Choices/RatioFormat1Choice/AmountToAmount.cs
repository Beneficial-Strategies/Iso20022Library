// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat1Choice
{
    /// <summary>
    /// The ratio is expressed as an amount per another amount.
    /// </summary>
    [IsoId("_Rj3kgdp-Ed-ak6NoX_4Aeg_-251071667")]
    [DisplayName("Amount To Amount")]
    public partial record AmountToAmount : RatioFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Numerator of the quotient of amounts.
        /// </summary>
        [IsoId("_UHySwdp-Ed-ak6NoX_4Aeg_622579243")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt1")]
        public required ActiveCurrencyAndAmount Amount1 { get; init; } 
        
        /// <summary>
        /// Denominator of the quotient of amounts.
        /// </summary>
        [IsoId("_UHySwtp-Ed-ak6NoX_4Aeg_636432914")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt2")]
        public required ActiveCurrencyAndAmount Amount2 { get; init; } 
        
        
        #nullable disable
        
    }
}
