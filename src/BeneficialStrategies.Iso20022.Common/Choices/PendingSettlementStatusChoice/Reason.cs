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
namespace BeneficialStrategies.Iso20022.Choices.PendingSettlementStatusChoice
{
    /// <summary>
    /// Reason for a pending status in the report.
    /// </summary>
    [IsoId("_U1POptp-Ed-ak6NoX_4Aeg_-485496729")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : PendingSettlementStatusChoice_
    #else
    public partial class Reason : PendingSettlementStatusChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( PendingSettlementStatusReason1Code reqStructured )
        {
            Structured = reqStructured;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for a settlement pending status in structured form.
        /// </summary>
        [IsoId("_U1YYkdp-Ed-ak6NoX_4Aeg_-913088435")]
        [DisplayName("Structured")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Strd")]
        #endif
        [IsoXmlTag("Strd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PendingSettlementStatusReason1Code Structured { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PendingSettlementStatusReason1Code Structured { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PendingSettlementStatusReason1Code Structured { get; init; } 
        #else
        public PendingSettlementStatusReason1Code Structured { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the reason for the settlement pending status in textual form.
        /// </summary>
        [IsoId("_U1YYktp-Ed-ak6NoX_4Aeg_-888151424")]
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
