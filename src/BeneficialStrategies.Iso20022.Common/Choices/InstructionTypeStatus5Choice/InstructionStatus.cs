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
namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus5Choice
{
    /// <summary>
    /// Status of each individual meeting instruction(s) included in the instruction message identified in InstructionType/InstructionIdentification.
    /// </summary>
    [IsoId("_hD-EIRrpEeyhRdHRjakS2w")]
    [DisplayName("Instruction Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record InstructionStatus : InstructionTypeStatus5Choice_
    #else
    public partial class InstructionStatus : InstructionTypeStatus5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a InstructionStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public InstructionStatus( System.String reqSingleInstructionIdentification,InstructionStatus11Choice_ reqValue )
        {
            SingleInstructionIdentification = reqSingleInstructionIdentification;
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the specific individual instruction from the original meeting instruction message element InstructionIdentification, for which the status is provided.
        /// </summary>
        [IsoId("_hY-q1RrpEeyhRdHRjakS2w")]
        [DisplayName("Single Instruction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SnglInstrId")]
        #endif
        [IsoXmlTag("SnglInstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text SingleInstructionIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String SingleInstructionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SingleInstructionIdentification { get; init; } 
        #else
        public System.String SingleInstructionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the securities account.
        /// </summary>
        [IsoId("_hY-q1xrpEeyhRdHRjakS2w")]
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
        /// Identification of the subaccount within the safekeeping account.
        /// </summary>
        [IsoId("_hY-q2RrpEeyhRdHRjakS2w")]
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
        /// Status of the individual meeting instruction.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstrSts")]
        #endif
        [IsoXmlTag("InstrSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InstructionStatus11Choice_ Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InstructionStatus11Choice_ Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InstructionStatus11Choice_ Value { get; init; } 
        #else
        public InstructionStatus11Choice_ Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
