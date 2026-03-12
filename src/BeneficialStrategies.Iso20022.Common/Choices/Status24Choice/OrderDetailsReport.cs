// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status24Choice
{
    /// <summary>
    /// Status report details of all the individual orders conveyed in a bulk or multiple order message. Can be used if all the individual orders conveyed in a bulk or multiple order message have the same status.
    /// </summary>
    [IsoId("_bpQwY0HPEeazV4RAqPV71g")]
    [DisplayName("Order Details Report")]
    public partial record OrderDetailsReport : Status24Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reference assigned to a set of orders or trades in order to link them together.
        /// </summary>
        [IsoId("_7RE7FTbsEead9bDRE_1DAQ")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; } 
        
        /// <summary>
        /// Status of a &apos;bulk&apos; of orders. Can be used if all the individual orders conveyed in a bulk or multiple order message have the same status.
        /// </summary>
        [IsoId("_-AO8kEH7EeaV3ab_pHzFIQ")]
        [DisplayName("Order Status")]
        [IsoXmlTag("OrdrSts")]
        public required OrderStatus3Choice_ OrderStatus { get; init; } 
        
        /// <summary>
        /// Party that initiates the status of the order.
        /// </summary>
        [IsoId("_7RE7IzbsEead9bDRE_1DAQ")]
        [DisplayName("Status Initiator")]
        [IsoXmlTag("StsInitr")]
        public PartyIdentification113? StatusInitiator { get; init; } 
        
        
        #nullable disable
        
    }
}
