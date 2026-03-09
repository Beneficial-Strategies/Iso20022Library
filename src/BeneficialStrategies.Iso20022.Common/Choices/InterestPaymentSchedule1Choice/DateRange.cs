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
namespace BeneficialStrategies.Iso20022.Choices.InterestPaymentSchedule1Choice
{
    /// <summary>
    /// Specifies an expected date and a due date for the interest payment.
    /// </summary>
    [IsoId("_u7i5ROFWEeSvv6t4Ka7B7A")]
    [DisplayName("Date Range")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DateRange : InterestPaymentSchedule1Choice_
    #else
    public partial class DateRange : InterestPaymentSchedule1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the interest payment schedule.
        /// </summary>
        [IsoId("_L71BfdOJEeSQ_-lmj1tzfw")]
        [DisplayName("Interest Schedule Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrstSchdlId")]
        #endif
        [IsoXmlTag("IntrstSchdlId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? InterestScheduleIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? InterestScheduleIdentification { get; init; } 
        #else
        public System.String? InterestScheduleIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Expected interest payment date.
        /// </summary>
        [IsoId("_L71Be9OJEeSQ_-lmj1tzfw")]
        [DisplayName("Expected Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="XpctdDt")]
        #endif
        [IsoXmlTag("XpctdDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ExpectedDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ExpectedDate { get; init; } 
        #else
        public System.DateOnly? ExpectedDate { get; set; } 
        #endif
        
        /// <summary>
        /// Latest date whereby the interest must be paid.
        /// </summary>
        [IsoId("_L71BfNOJEeSQ_-lmj1tzfw")]
        [DisplayName("Due Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DueDt")]
        #endif
        [IsoXmlTag("DueDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? DueDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? DueDate { get; init; } 
        #else
        public System.DateOnly? DueDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
