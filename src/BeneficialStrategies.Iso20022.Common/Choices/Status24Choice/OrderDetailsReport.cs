// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.Status24Choice
{
    /// <summary>
    /// Status report details of all the individual orders conveyed in a bulk or multiple order message. Can be used if all the individual orders conveyed in a bulk or multiple order message have the same status.
    /// </summary>
    [IsoId("_bpQwY0HPEeazV4RAqPV71g")]
    [DisplayName("Order Details Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OrderDetailsReport : Status24Choice_
    #else
    public partial class OrderDetailsReport : Status24Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OrderDetailsReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OrderDetailsReport( OrderStatus3Choice_ reqOrderStatus )
        {
            OrderStatus = reqOrderStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reference assigned to a set of orders or trades in order to link them together.
        /// </summary>
        [IsoId("_7RE7FTbsEead9bDRE_1DAQ")]
        [DisplayName("Master Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MstrRef")]
        #endif
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MasterReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MasterReference { get; init; } 
        #else
        public System.String? MasterReference { get; set; } 
        #endif
        
        /// <summary>
        /// Status of a &apos;bulk&apos; of orders. Can be used if all the individual orders conveyed in a bulk or multiple order message have the same status.
        /// </summary>
        [IsoId("_-AO8kEH7EeaV3ab_pHzFIQ")]
        [DisplayName("Order Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrdrSts")]
        #endif
        [IsoXmlTag("OrdrSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OrderStatus3Choice_ OrderStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OrderStatus3Choice_ OrderStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrderStatus3Choice_ OrderStatus { get; init; } 
        #else
        public OrderStatus3Choice_ OrderStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Party that initiates the status of the order.
        /// </summary>
        [IsoId("_7RE7IzbsEead9bDRE_1DAQ")]
        [DisplayName("Status Initiator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StsInitr")]
        #endif
        [IsoXmlTag("StsInitr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification113? StatusInitiator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification113? StatusInitiator { get; init; } 
        #else
        public PartyIdentification113? StatusInitiator { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
