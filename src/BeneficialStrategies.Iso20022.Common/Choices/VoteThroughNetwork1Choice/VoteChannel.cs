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
namespace BeneficialStrategies.Iso20022.Choices.VoteThroughNetwork1Choice
{
    /// <summary>
    /// Voting is performed via message sent through an alternate network channel, that is, either via the chain of intermediaries or via the channel as described in the processing text for next intermediary information field.
    /// </summary>
    [IsoId("_Cph1QDT8Ee2tRf29bleifQ")]
    [DisplayName("Vote Channel")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record VoteChannel : VoteThroughNetwork1Choice_
    #else
    public partial class VoteChannel : VoteThroughNetwork1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a VoteChannel instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public VoteChannel( VoteChannel1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the network channel through which the vote should be sent.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VoteChanl")]
        #endif
        [IsoXmlTag("VoteChanl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required VoteChannel1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required VoteChannel1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public VoteChannel1Code Value { get; init; } 
        #else
        public VoteChannel1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
