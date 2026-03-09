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
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus3Choice
{
    /// <summary>
    /// Reason for a rejected status in the report.
    /// </summary>
    [IsoId("_U3BXUNp-Ed-ak6NoX_4Aeg_456007921")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : RejectedStatus3Choice_
    #else
    public partial class Reason : RejectedStatus3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( TransferRejectedStatusReason1Code reqStructured )
        {
            Structured = reqStructured;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for a rejected status in structured form.
        /// </summary>
        [IsoId("_U3LIVNp-Ed-ak6NoX_4Aeg_431072629")]
        [DisplayName("Structured")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Strd")]
        #endif
        [IsoXmlTag("Strd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TransferRejectedStatusReason1Code Structured { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TransferRejectedStatusReason1Code Structured { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransferRejectedStatusReason1Code Structured { get; init; } 
        #else
        public TransferRejectedStatusReason1Code Structured { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the reason for the rejected status in textual form.
        /// </summary>
        [IsoId("_U3LIVdp-Ed-ak6NoX_4Aeg_431072681")]
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
