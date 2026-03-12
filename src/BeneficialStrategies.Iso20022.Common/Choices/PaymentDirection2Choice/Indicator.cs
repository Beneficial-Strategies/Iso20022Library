// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentDirection2Choice
{
    /// <summary>
    /// Indicates the direction of payment for asset or mortgage backed securities, ie, whether the repaid capital is distributed (payment direction is down) or capitalized (payment direction is up).
    /// </summary>
    [IsoId("_Qu-j59p-Ed-ak6NoX_4Aeg_1880063525")]
    [DisplayName("Indicator")]
    public partial record Indicator : PaymentDirection2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// The direction of capital repayment for asset backed securities.
        /// </summary>
        [IsoXmlTag("Ind")]
        [IsoSimpleType(IsoSimpleType.PaymentDirectionIndicator)]
        public required IsoPaymentDirectionIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
