// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Direction2Choice
{
    /// <summary>
    /// Identifies whether the reporting counterparty is the buyer or the seller as determined at the time of transaction.|
    /// </summary>
    [IsoId("_oKFn03g-Eeu3kecHd7QKUQ")]
    [DisplayName("Counterparty Side")]
    public partial record CounterpartySide : Direction2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies if a trade party is a buyer or a seller.
        /// </summary>
        [IsoXmlTag("CtrPtySd")]
        public required OptionParty1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
