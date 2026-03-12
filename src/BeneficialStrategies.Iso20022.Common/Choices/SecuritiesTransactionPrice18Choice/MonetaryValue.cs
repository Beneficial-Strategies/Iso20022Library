// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice18Choice
{
    /// <summary>
    /// Indicates that price is expressed as a monetary value.
    /// </summary>
    [IsoId("_m8q24MgpEeuGrNSsxk3B0A")]
    [DisplayName("Monetary Value")]
    public partial record MonetaryValue : SecuritiesTransactionPrice18Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Amount of money in the cash entry.
        /// </summary>
        [IsoId("_XYj_4Mz3EeufhKfUxzsnrQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveOrHistoricCurrencyAnd20DecimalAmount Amount { get; init; } 
        
        /// <summary>
        /// Indicates that the amount value is positive or negative.
        /// </summary>
        [IsoId("_ZY5f8Mz3EeufhKfUxzsnrQ")]
        [DisplayName("Sign")]
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        public IsoPlusOrMinusIndicator? Sign { get; init; } 
        
        
        #nullable disable
        
    }
}
