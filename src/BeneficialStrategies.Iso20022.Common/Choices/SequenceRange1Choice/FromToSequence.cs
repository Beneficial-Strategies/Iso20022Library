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
namespace BeneficialStrategies.Iso20022.Choices.SequenceRange1Choice
{
    /// <summary>
    /// Particular sequence range specified between a start sequence and an end sequence.
    /// </summary>
    [IsoId("_64OLoIy3EeeGkvZr3jtnCQ")]
    [DisplayName("From To Sequence")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FromToSequence : SequenceRange1Choice_
    #else
    public partial class FromToSequence : SequenceRange1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FromToSequence instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FromToSequence( System.String reqFromSequence,System.String reqToSequence )
        {
            FromSequence = reqFromSequence;
            ToSequence = reqToSequence;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Start sequence of the range.
        /// </summary>
        [IsoId("_9nPeAIy0EeeGkvZr3jtnCQ")]
        [DisplayName("From Sequence")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrSeq")]
        #endif
        [IsoXmlTag("FrSeq")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text FromSequence { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String FromSequence { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String FromSequence { get; init; } 
        #else
        public System.String FromSequence { get; set; } 
        #endif
        
        /// <summary>
        /// End sequence of the range.
        /// </summary>
        [IsoId("__3Gn0Iy0EeeGkvZr3jtnCQ")]
        [DisplayName("To Sequence")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ToSeq")]
        #endif
        [IsoXmlTag("ToSeq")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text ToSequence { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ToSequence { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ToSequence { get; init; } 
        #else
        public System.String ToSequence { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
