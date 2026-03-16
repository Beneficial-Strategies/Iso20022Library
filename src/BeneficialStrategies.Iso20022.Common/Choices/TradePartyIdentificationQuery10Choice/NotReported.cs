// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradePartyIdentificationQuery10Choice
{
    /// <summary>
    /// Not Reported.
    /// </summary>
    [DisplayName("Not Reported")]
    public partial record NotReported : TradePartyIdentificationQuery10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NotRptd")]
        public required NotReported1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
