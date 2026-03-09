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
namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation3Choice
{
    /// <summary>
    /// Indicates the type of contract confirmation.
    /// </summary>
    [IsoId("_PQNwEVo3Ee23K4GXSpBSeg")]
    [DisplayName("Confirmed")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Confirmed : TradeConfirmation3Choice_
    #else
    public partial class Confirmed : TradeConfirmation3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies whether the contract was confirmed electronically or non-electronically.
        /// </summary>
        [IsoId("_V9SsEVo3Ee23K4GXSpBSeg")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TradeConfirmationType1Code? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeConfirmationType1Code? Type { get; init; } 
        #else
        public TradeConfirmationType1Code? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
        /// </summary>
        [IsoId("_V9SsE1o3Ee23K4GXSpBSeg")]
        [DisplayName("Time Stamp")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TmStmp")]
        #endif
        [IsoXmlTag("TmStmp")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? TimeStamp { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? TimeStamp { get; init; } 
        #else
        public System.DateTime? TimeStamp { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
