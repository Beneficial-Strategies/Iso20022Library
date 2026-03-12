// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature9Choice
{
    /// <summary>
    /// Indicates that reporting party is a central counterparty.
    /// </summary>
    [IsoId("_iAf0RT7KEeq0cMLnAmm7Lg")]
    [DisplayName("Central Counter Party")]
    public partial record CentralCounterParty : CounterpartyTradeNature9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("CntrlCntrPty")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
