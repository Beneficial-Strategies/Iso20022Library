// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Direction2Choice
{
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the first leg as determined at the time of transaction.
    /// </summary>
    [IsoId("_oKFn0Xg-Eeu3kecHd7QKUQ")]
    [DisplayName("Direction Of The First Leg")]
    public partial record DirectionOfTheFirstLeg : Direction2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies if a trade party is a taker or a maker.
        /// </summary>
        [IsoXmlTag("DrctnOfTheFrstLeg")]
        public required OptionParty3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
