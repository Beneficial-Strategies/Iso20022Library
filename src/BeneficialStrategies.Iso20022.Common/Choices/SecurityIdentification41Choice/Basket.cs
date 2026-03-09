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
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice
{
    /// <summary>
    /// Identification of constituents for a basket of indexes.
    /// </summary>
    [IsoId("_idD051o2Ee23K4GXSpBSeg")]
    [DisplayName("Basket")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Basket : SecurityIdentification41Choice_
    #else
    public partial class Basket : SecurityIdentification41Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the structurer of the customer basket.
        /// </summary>
        [IsoId("_mv1RoVo2Ee23K4GXSpBSeg")]
        [DisplayName("Structurer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Strr")]
        #endif
        [IsoXmlTag("Strr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? Structurer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Structurer { get; init; } 
        #else
        public System.String? Structurer { get; set; } 
        #endif
        
        /// <summary>
        /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
        /// </summary>
        [IsoId("_mv1Ro1o2Ee23K4GXSpBSeg")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax52Text? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Identification { get; init; } 
        #else
        public System.String? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Identifier of the underliers that represent the constituents of a custom basket.
        /// </summary>
        [IsoId("_mv1RpVo2Ee23K4GXSpBSeg")]
        [DisplayName("Constituents")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cnsttnts")]
        #endif
        [IsoXmlTag("Cnsttnts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BasketConstituents3? Constituents { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BasketConstituents3? Constituents { get; init; } 
        #else
        public BasketConstituents3? Constituents { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
