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
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus1Choice
{
    /// <summary>
    /// Status applying to individual instructions of a MeetingInstruction.
    /// </summary>
    [IsoId("_RWnLqdp-Ed-ak6NoX_4Aeg_-1745275553")]
    [DisplayName("Detailed Instruction Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DetailedInstructionStatus : InstructionStatus1Choice_
    #else
    public partial class DetailedInstructionStatus : InstructionStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DetailedInstructionStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DetailedInstructionStatus( System.String reqInstructionIdentification,InstructionStatus2Choice_ reqInstructionStatus )
        {
            InstructionIdentification = reqInstructionIdentification;
            InstructionStatus = reqInstructionStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the detailed instruction within an instruction message.
        /// </summary>
        [IsoId("_RWnLoNp-Ed-ak6NoX_4Aeg_-2110986462")]
        [DisplayName("Instruction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstrId")]
        #endif
        [IsoXmlTag("InstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text InstructionIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String InstructionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String InstructionIdentification { get; init; } 
        #else
        public System.String InstructionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the safekeeping account.
        /// </summary>
        [IsoId("_RWnLodp-Ed-ak6NoX_4Aeg_1822881804")]
        [DisplayName("Account Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctId")]
        #endif
        [IsoXmlTag("AcctId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? AccountIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AccountIdentification { get; init; } 
        #else
        public System.String? AccountIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the subaccount of the safekeeping account.
        /// </summary>
        [IsoId("_RWnLotp-Ed-ak6NoX_4Aeg_-2130380809")]
        [DisplayName("Sub Account Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SubAcctId")]
        #endif
        [IsoXmlTag("SubAcctId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SubAccountIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SubAccountIdentification { get; init; } 
        #else
        public System.String? SubAccountIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Status applying to individual instructions of a MeetingInstruction.
        /// </summary>
        [IsoId("_RWnLo9p-Ed-ak6NoX_4Aeg_1301124445")]
        [DisplayName("Instruction Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstrSts")]
        #endif
        [IsoXmlTag("InstrSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InstructionStatus2Choice_ InstructionStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InstructionStatus2Choice_ InstructionStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InstructionStatus2Choice_ InstructionStatus { get; init; } 
        #else
        public InstructionStatus2Choice_ InstructionStatus { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
