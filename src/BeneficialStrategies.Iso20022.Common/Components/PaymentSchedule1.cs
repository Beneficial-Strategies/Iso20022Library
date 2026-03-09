// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an payment schedule, that is an amount that must be paid no sooner than the expected payment date and no later than the due date.
/// </summary>
[IsoId("_QeqY8bJVEeuX8-p7DPhoRw")]
[DisplayName("Payment Schedule")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentSchedule1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the payment schedule.
    /// </summary>
    [IsoId("_QgascbJVEeuX8-p7DPhoRw")]
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
    [IsoId("_Qgasc7JVEeuX8-p7DPhoRw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Expected date whereby the amount must be paid.
    /// </summary>
    [IsoId("_QgasdbJVEeuX8-p7DPhoRw")]
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
    [IsoId("_Qgasd7JVEeuX8-p7DPhoRw")]
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
    
    /// <summary>
    /// Further details on the payments.
    /// </summary>
    [IsoId("_R9n00LJWEeuX8-p7DPhoRw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
