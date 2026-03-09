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
namespace BeneficialStrategies.Iso20022.Choices.ReportItemStatus1Choice
{
    /// <summary>
    /// Statement is accepted with an exception/s.
    /// </summary>
    [IsoId("_TKSsQkitEeSlHoYg_EudVQ")]
    [DisplayName("Accepted With Exception")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AcceptedWithException : ReportItemStatus1Choice_
    #else
    public partial class AcceptedWithException : ReportItemStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AcceptedWithException instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AcceptedWithException( ReportItemRejectionReason1Choice_ reqException )
        {
            Exception = reqException;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for the exception status.
        /// </summary>
        [IsoId("_j5TZgClEEeWwYv6HydV_vw")]
        [DisplayName("Exception")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Xcptn")]
        #endif
        [IsoXmlTag("Xcptn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReportItemRejectionReason1Choice_ Exception { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReportItemRejectionReason1Choice_ Exception { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReportItemRejectionReason1Choice_ Exception { get; init; } 
        #else
        public ReportItemRejectionReason1Choice_ Exception { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the reason for the status that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_j5TZgilEEeWwYv6HydV_vw")]
        [DisplayName("Additional Reason Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlRsnInf")]
        #endif
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalReasonInformation { get; init; } 
        #else
        public System.String? AdditionalReasonInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Details of the report item.
        /// </summary>
        [IsoId("_j5TZhClEEeWwYv6HydV_vw")]
        [DisplayName("Report Item")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptItm")]
        #endif
        [IsoXmlTag("RptItm")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReportItem1? ReportItem { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReportItem1? ReportItem { get; init; } 
        #else
        public ReportItem1? ReportItem { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
