// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PortfolioTransferStatus1Choice
{
    /// <summary>
    /// Status of the allegement reported.
    /// </summary>
    [IsoId("_BJu8wa3EEeeBVbuVcoH9Nw")]
    [DisplayName("Code")]
    public partial record Code : PortfolioTransferStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an allegement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AllegementStatus2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
