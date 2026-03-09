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
namespace BeneficialStrategies.Iso20022.Choices.KeyChoiceValue2
{
    /// <summary>
    /// Data block for a TR31 or TR34 block, where the block does not contain a key (for example the TR34 unbind which contains the signed authorization data).
    /// </summary>
    [IsoId("_FjgS07TqEeeQy4o2AayYHg")]
    [DisplayName("TR Related Data")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TRRelatedData : KeyChoiceValue2_
    #else
    public partial class TRRelatedData : KeyChoiceValue2_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specific TR34 command where the TRBlock is a TR34 block.
        /// </summary>
        [IsoId("_PZ0GEbTpEeeQy4o2AayYHg")]
        [DisplayName("TR 34 Command")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TR34Cmd")]
        #endif
        [IsoXmlTag("TR34Cmd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TR34Command1Code? TR34Command { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TR34Command1Code? TR34Command { get; init; } 
        #else
        public TR34Command1Code? TR34Command { get; set; } 
        #endif
        
        /// <summary>
        /// TR31 or TR34 data block.
        /// </summary>
        [IsoId("_PZ0GE7TpEeeQy4o2AayYHg")]
        [DisplayName("TR Block")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TRBlck")]
        #endif
        [IsoXmlTag("TRBlck")]
        [IsoSimpleType(IsoSimpleType.Max100KBinary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax100KBinary? TRBlock { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[]? TRBlock { get; init; } 
        #else
        public System.Byte[]? TRBlock { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
