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
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus20Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_ce_gT5KQEeWHWpTQn1FFVg")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : RejectedStatus20Choice_
    #else
    public partial class Reason : RejectedStatus20Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( RejectedReason18Choice_ reqReasonCode )
        {
            ReasonCode = reqReasonCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been rejected.
        /// </summary>
        [IsoId("_ce_gX5KQEeWHWpTQn1FFVg")]
        [DisplayName("Reason Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RsnCd")]
        #endif
        [IsoXmlTag("RsnCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RejectedReason18Choice_ ReasonCode { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RejectedReason18Choice_ ReasonCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RejectedReason18Choice_ ReasonCode { get; init; } 
        #else
        public RejectedReason18Choice_ ReasonCode { get; set; } 
        #endif
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_ce_gZ5KQEeWHWpTQn1FFVg")]
        [DisplayName("Additional Reason Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlRsnInf")]
        #endif
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalReasonInformation { get; init; } 
        #else
        public System.String? AdditionalReasonInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
