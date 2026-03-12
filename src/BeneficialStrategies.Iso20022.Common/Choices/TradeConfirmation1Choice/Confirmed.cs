// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation1Choice
{
    /// <summary>
    /// Indicates the type of contract confirmation.
    /// </summary>
    [IsoId("_PZ43oA28EeWmAKKPnqYEVQ")]
    [DisplayName("Confirmed")]
    public partial record Confirmed : TradeConfirmation1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies whether the contract was confirmed electronically or non-electronically.
        /// </summary>
        [IsoId("_8KV5lg27EeWmAKKPnqYEVQ")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required TradeConfirmationType1Code Type { get; init; } 
        
        /// <summary>
        /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
        /// </summary>
        [IsoId("_8KV5lQ27EeWmAKKPnqYEVQ")]
        [DisplayName("Time Stamp")]
        [IsoXmlTag("TmStmp")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime TimeStamp { get; init; } 
        
        
        #nullable disable
        
    }
}
