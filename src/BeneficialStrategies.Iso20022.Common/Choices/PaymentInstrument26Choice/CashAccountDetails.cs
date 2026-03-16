// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument26Choice
{
    /// <summary>
    /// Cash Account Details.
    /// </summary>
    [DisplayName("Cash Account Details")]
    public partial record CashAccountDetails : PaymentInstrument26Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CshAcctDtls")]
        public required InvestmentAccount60 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
