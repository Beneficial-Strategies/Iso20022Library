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
/// Telecom services summary component carries summary level telephony billing data. 
/// </summary>
[IsoId("_7nW5oSCDEey8XKHwKquEQw")]
[DisplayName("Telecom Services Summary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TelecomServicesSummary2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the details of the customer. Also known as the user of the service.
    /// </summary>
    [IsoId("_7stTsSCDEey8XKHwKquEQw")]
    [DisplayName("Customer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cstmr")]
    #endif
    [IsoXmlTag("Cstmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Customer6? Customer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Customer6? Customer { get; init; } 
    #else
    public Customer6? Customer { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the billing period start date for telecommunication or related services.
    /// </summary>
    [IsoId("_7stTsyCDEey8XKHwKquEQw")]
    [DisplayName("Billing Statement Period Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgStmtPrdStart")]
    #endif
    [IsoXmlTag("BllgStmtPrdStart")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BillingStatementPeriodStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BillingStatementPeriodStart { get; init; } 
    #else
    public System.DateOnly? BillingStatementPeriodStart { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the billing period end date for telecommunication or related services.
    /// </summary>
    [IsoId("_7stTtSCDEey8XKHwKquEQw")]
    [DisplayName("Billing Statement Period End")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgStmtPrdEnd")]
    #endif
    [IsoXmlTag("BllgStmtPrdEnd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BillingStatementPeriodEnd { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BillingStatementPeriodEnd { get; init; } 
    #else
    public System.DateOnly? BillingStatementPeriodEnd { get; set; } 
    #endif
    
    /// <summary>
    /// Summary of the charges associated with the billing event. 
    /// </summary>
    [IsoId("_7stTtyCDEey8XKHwKquEQw")]
    [DisplayName("Billing Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgEvt")]
    #endif
    [IsoXmlTag("BllgEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount19? BillingEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount19? BillingEvent { get; init; } 
    #else
    public Amount19? BillingEvent { get; set; } 
    #endif
    
    /// <summary>
    /// Total of taxes applicable to the billing amount.
    /// </summary>
    [IsoId("_7stTuSCDEey8XKHwKquEQw")]
    [DisplayName("Total Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTax")]
    #endif
    [IsoXmlTag("TtlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax39? TotalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax39? TotalTax { get; init; } 
    #else
    public Tax39? TotalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Additional user-defined data pertaining to the shipment.
    /// </summary>
    [IsoId("_7stTuyCDEey8XKHwKquEQw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
