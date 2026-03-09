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
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatusChoice
{
    /// <summary>
    /// Explains the reason for rejecting a payment cancellation request.
    /// </summary>
    [IsoId("_UuYYtdp-Ed-ak6NoX_4Aeg_1934789984")]
    [DisplayName("Rejected Cancellation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RejectedCancellation : InvestigationStatusChoice_
    #else
    public partial class RejectedCancellation : InvestigationStatusChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RejectedCancellation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RejectedCancellation( PaymentCancellationRejection1Code reqReasonCode )
        {
            ReasonCode = reqReasonCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Justification for the rejection of the cancellation.
        /// </summary>
        [IsoId("_T9gVY9p-Ed-ak6NoX_4Aeg_173058696")]
        [DisplayName("Reason Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RsnCd")]
        #endif
        [IsoXmlTag("RsnCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PaymentCancellationRejection1Code ReasonCode { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PaymentCancellationRejection1Code ReasonCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentCancellationRejection1Code ReasonCode { get; init; } 
        #else
        public PaymentCancellationRejection1Code ReasonCode { get; set; } 
        #endif
        
        /// <summary>
        /// Free text justification for rejecting a cancellation.
        /// </summary>
        [IsoId("_T9gVZNp-Ed-ak6NoX_4Aeg_1563536447")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Reason { get; init; } 
        #else
        public System.String? Reason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
