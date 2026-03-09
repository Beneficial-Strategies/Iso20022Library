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
namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionForMeetingResolution1Choice
{
    /// <summary>
    /// Specifies the vote recommendation for resolutions added during the meeting.
    /// </summary>
    [IsoId("_TK1iUdp-Ed-ak6NoX_4Aeg_853994670")]
    [DisplayName("Vote Indication")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record VoteIndication : VoteInstructionForMeetingResolution1Choice_
    #else
    public partial class VoteIndication : VoteInstructionForMeetingResolution1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a VoteIndication instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public VoteIndication( VoteInstructionAtMeeting1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the possible types of voting instructions for resolutions proposed at the meeting.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VoteIndctn")]
        #endif
        [IsoXmlTag("VoteIndctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required VoteInstructionAtMeeting1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required VoteInstructionAtMeeting1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public VoteInstructionAtMeeting1Code Value { get; init; } 
        #else
        public VoteInstructionAtMeeting1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
