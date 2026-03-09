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
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus11Choice
{
    /// <summary>
    /// Status advising on the processing of the instruction.
    /// </summary>
    [IsoId("_htjMoxrpEeyhRdHRjakS2w")]
    [DisplayName("Processing Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProcessingStatus : InstructionStatus11Choice_
    #else
    public partial class ProcessingStatus : InstructionStatus11Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProcessingStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProcessingStatus( Status9Code reqStatus )
        {
            Status = reqStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Status code.
        /// </summary>
        [IsoId("_M57j0fNsEeqRfth943bvEA")]
        [DisplayName("Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sts")]
        #endif
        [IsoXmlTag("Sts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Status9Code Status { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Status9Code Status { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Status9Code Status { get; init; } 
        #else
        public Status9Code Status { get; set; } 
        #endif
        
        /// <summary>
        /// Number of the admission ticket that has been granted by the custodian or the issuer.
        /// </summary>
        [IsoId("_f1l8kPNsEeqRfth943bvEA")]
        [DisplayName("Attendance Card Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AttndncCardNb")]
        #endif
        [IsoXmlTag("AttndncCardNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? AttendanceCardNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AttendanceCardNumber { get; init; } 
        #else
        public System.String? AttendanceCardNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_M57j0_NsEeqRfth943bvEA")]
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
