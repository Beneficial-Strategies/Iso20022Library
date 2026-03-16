// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument26Choice
{
    /// <summary>
    /// Bankers Draft Details.
    /// </summary>
    [DisplayName("Bankers Draft Details")]
    public partial record BankersDraftDetails : PaymentInstrument26Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BkrsDrftDtls")]
        public required Cheque21 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
