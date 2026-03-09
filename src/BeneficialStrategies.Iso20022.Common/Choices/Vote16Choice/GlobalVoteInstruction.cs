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
namespace BeneficialStrategies.Iso20022.Choices.Vote16Choice
{
    /// <summary>
    /// Instruction specifying a vote instruction per resolution for the entire entitlement.
    /// </summary>
    [IsoId("_XbSml_NoEeqRfth943bvEA")]
    [DisplayName("Global Vote Instruction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record GlobalVoteInstruction : Vote16Choice_
    #else
    public partial class GlobalVoteInstruction : Vote16Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a GlobalVoteInstruction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public GlobalVoteInstruction( System.String reqIssuerLabel,VoteInstructionType2Choice_ reqVoteOption )
        {
            IssuerLabel = reqIssuerLabel;
            VoteOption = reqVoteOption;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Number of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_XuyKUfNoEeqRfth943bvEA")]
        [DisplayName("Issuer Label")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IssrLabl")]
        #endif
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text IssuerLabel { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String IssuerLabel { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String IssuerLabel { get; init; } 
        #else
        public System.String IssuerLabel { get; set; } 
        #endif
        
        /// <summary>
        /// Vote instructed.
        /// </summary>
        [IsoId("_XuyKU_NoEeqRfth943bvEA")]
        [DisplayName("Vote Option")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VoteOptn")]
        #endif
        [IsoXmlTag("VoteOptn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required VoteInstructionType2Choice_ VoteOption { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required VoteInstructionType2Choice_ VoteOption { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public VoteInstructionType2Choice_ VoteOption { get; init; } 
        #else
        public VoteInstructionType2Choice_ VoteOption { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
