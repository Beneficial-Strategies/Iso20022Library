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
namespace BeneficialStrategies.Iso20022.Choices.TransferCancellationCompleteStatusChoice
{
    /// <summary>
    /// Reason of the complete status.
    /// </summary>
    [IsoId("_U0C70tp-Ed-ak6NoX_4Aeg_-1208524222")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : TransferCancellationCompleteStatusChoice_
    #else
    public partial class Reason : TransferCancellationCompleteStatusChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( CancellationCompleteStatusReason1Code reqStructured )
        {
            Structured = reqStructured;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for a complete status in structured form.
        /// </summary>
        [IsoId("_U0fAsNp-Ed-ak6NoX_4Aeg_109339586")]
        [DisplayName("Structured")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Strd")]
        #endif
        [IsoXmlTag("Strd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CancellationCompleteStatusReason1Code Structured { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CancellationCompleteStatusReason1Code Structured { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CancellationCompleteStatusReason1Code Structured { get; init; } 
        #else
        public CancellationCompleteStatusReason1Code Structured { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the reason for the complete status in textual form.
        /// </summary>
        [IsoId("_U0fAsdp-Ed-ak6NoX_4Aeg_551704444")]
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
