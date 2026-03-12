// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation3Choice
{
    /// <summary>
    /// Indicates the type of contract confirmation.
    /// </summary>
    [IsoId("_PQNwEVo3Ee23K4GXSpBSeg")]
    [DisplayName("Confirmed")]
    public partial record Confirmed : TradeConfirmation3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies whether the contract was confirmed electronically or non-electronically.
        /// </summary>
        [IsoId("_V9SsEVo3Ee23K4GXSpBSeg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public TradeConfirmationType1Code? Type { get; init; } 
        
        /// <summary>
        /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
        /// </summary>
        [IsoId("_V9SsE1o3Ee23K4GXSpBSeg")]
        [DisplayName("Time Stamp")]
        [IsoXmlTag("TmStmp")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? TimeStamp { get; init; } 
        
        
        #nullable disable
        
    }
}
