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
namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice
{
    /// <summary>
    /// Specifies a frequency in terms of an exact point in time or moment within a specified period type.
    /// </summary>
    [IsoId("_6IxUQWk2Eeanu6HLe77Rkg")]
    [DisplayName("Point In Time")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PointInTime : Frequency36Choice_
    #else
    public partial class PointInTime : Frequency36Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PointInTime instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PointInTime( Frequency6Code reqType,System.String reqValue )
        {
            Type = reqType;
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Period for which the number of instructions are to be created and processed.
        /// </summary>
        [IsoId("_CWY19Wk3Eeanu6HLe77Rkg")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Frequency6Code Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Frequency6Code Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency6Code Type { get; init; } 
        #else
        public Frequency6Code Type { get; set; } 
        #endif
        
        /// <summary>
        /// Further information on the exact point in time the event should take place.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PtInTm")]
        #endif
        [IsoXmlTag("PtInTm")]
        [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExact2NumericText Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
