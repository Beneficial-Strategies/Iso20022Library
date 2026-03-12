// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Timeframe2Choice
{
    /// <summary>
    /// An agreed number of days after the Trade date (T) used to define standard timeframes e.g T+3 settlement period. ||Where = T is the date that the price is applied to a transaction.
    /// </summary>
    [IsoId("_UAoh7Np-Ed-ak6NoX_4Aeg_348286010")]
    [DisplayName("Trade Plus")]
    public partial record TradePlus : Timeframe2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("TPlus")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
