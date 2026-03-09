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
namespace BeneficialStrategies.Iso20022.Choices.PaymentSchedule1Choice
{
    /// <summary>
    /// Specifies a payment sub-schedule, that is the amount of money that must be paid no sooner than the expected date and no later than the latest shipment date.
    /// </summary>
    [IsoId("_Bhnbc9OAEeSQ_-lmj1tzfw")]
    [DisplayName("Sub Schedule")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SubSchedule : PaymentSchedule1Choice_
    #else
    public partial class SubSchedule : PaymentSchedule1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SubSchedule instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SubSchedule( ActiveCurrencyAndAmount reqAmount,System.DateOnly reqDueDate )
        {
            Amount = reqAmount;
            DueDate = reqDueDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the payment schedule.
        /// </summary>
        [IsoId("_L71Bg9OJEeSQ_-lmj1tzfw")]
        [DisplayName("Payment Schedule Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtSchdlId")]
        #endif
        [IsoXmlTag("PmtSchdlId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? PaymentScheduleIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PaymentScheduleIdentification { get; init; } 
        #else
        public System.String? PaymentScheduleIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Amount that must be paid no sooner than the expected payment date and no later than the due date.
        /// </summary>
        [IsoId("_L71BgdOJEeSQ_-lmj1tzfw")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount Amount { get; init; } 
        #else
        public ActiveCurrencyAndAmount Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Expected date whereby the amount must be paid.
        /// </summary>
        [IsoId("_L71BgNOJEeSQ_-lmj1tzfw")]
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
        /// Latest date whereby the amount of money must be paid.
        /// </summary>
        [IsoId("_L71Bf9OJEeSQ_-lmj1tzfw")]
        [DisplayName("Due Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DueDt")]
        #endif
        [IsoXmlTag("DueDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate DueDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly DueDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly DueDate { get; init; } 
        #else
        public System.DateOnly DueDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
