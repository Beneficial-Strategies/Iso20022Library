// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction12Choice
{
    /// <summary>
    /// Token Response.
    /// </summary>
    [DisplayName("Token Response")]
    public partial record TokenResponse : CardPaymentDataSetTransaction12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("TknRspn")]
        public required TokenRequestComponent4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
