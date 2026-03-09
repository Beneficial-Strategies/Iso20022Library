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
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus4Choice
{
    /// <summary>
    /// Status advising on the rejection of the instruction.
    /// </summary>
    [IsoId("_RCpGx9p-Ed-ak6NoX_4Aeg_-1261069059")]
    [DisplayName("Rejection Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RejectionStatus : InstructionStatus4Choice_
    #else
    public partial class RejectionStatus : InstructionStatus4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RejectionStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RejectionStatus( InstructionRejectionStatus1Choice_ reqReason )
        {
            Reason = reqReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason advising the rejection of the instruction.
        /// </summary>
        [IsoId("_RCfVw9p-Ed-ak6NoX_4Aeg_-1090217196")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InstructionRejectionStatus1Choice_ Reason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InstructionRejectionStatus1Choice_ Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InstructionRejectionStatus1Choice_ Reason { get; init; } 
        #else
        public InstructionRejectionStatus1Choice_ Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the reason.
        /// </summary>
        [IsoId("_RCfVxNp-Ed-ak6NoX_4Aeg_-1755939689")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalInformation { get; init; } 
        #else
        public System.String? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
