// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MarketIdentificationOrCashPurpose1Choice
{
    /// <summary>
    /// Underlying reason for the payment SSI instruction, expressed as a code.
    /// </summary>
    [IsoId("_3LyNoUiNEeOdL6nMHefDgg")]
    [DisplayName("Cash SSI Purpose")]
    public partial record CashSSIPurpose : MarketIdentificationOrCashPurpose1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external market code, to which the instruction, operation or report relates, in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code set published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("CshSSIPurp")]
        public required ExternalMarketArea1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
