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
/// Customer order attached to a customer, recorded in the POI system.
/// </summary>
[IsoId("_R4AvQNuAEeiXqq0XHEoNUA")]
[DisplayName("Customer Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerOrder1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerOrder1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerOrder1( System.String reqCustomerOrderIdentification,System.String reqSaleReferenceIdentification,System.DateTime reqStartDate,ImpliedCurrencyAndAmount reqForecastedAmount )
    {
        CustomerOrderIdentification = reqCustomerOrderIdentification;
        SaleReferenceIdentification = reqSaleReferenceIdentification;
        StartDate = reqStartDate;
        ForecastedAmount = reqForecastedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a customer order.
    /// </summary>
    [IsoId("_Z4JOkNuAEeiXqq0XHEoNUA")]
    [DisplayName("Customer Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrOrdrId")]
    #endif
    [IsoXmlTag("CstmrOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CustomerOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CustomerOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CustomerOrderIdentification { get; init; } 
    #else
    public System.String CustomerOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a Sale transaction for a sequence of related POI transactions.
    /// </summary>
    [IsoId("_ewpOkNuAEeiXqq0XHEoNUA")]
    [DisplayName("Sale Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRefId")]
    #endif
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SaleReferenceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SaleReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SaleReferenceIdentification { get; init; } 
    #else
    public System.String SaleReferenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if a customer order is currently open.
    /// </summary>
    [IsoId("_pcoQINuAEeiXqq0XHEoNUA")]
    [DisplayName("Open Order State")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpnOrdrStat")]
    #endif
    [IsoXmlTag("OpnOrdrStat")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OpenOrderState { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OpenOrderState { get; init; } 
    #else
    public System.String? OpenOrderState { get; set; } 
    #endif
    
    /// <summary>
    /// Date time of the beginning of an operation.
    /// </summary>
    [IsoId("_vD5aoNuAEeiXqq0XHEoNUA")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime StartDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime StartDate { get; init; } 
    #else
    public System.DateTime StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date time of the end of an operation.
    /// </summary>
    [IsoId("_yyOtkNuAEeiXqq0XHEoNUA")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? EndDate { get; init; } 
    #else
    public System.DateTime? EndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of amount.
    /// </summary>
    [IsoId("_3d_SENuAEeiXqq0XHEoNUA")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountUnit1Code? Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountUnit1Code? Unit { get; init; } 
    #else
    public AmountUnit1Code? Unit { get; set; } 
    #endif
    
    /// <summary>
    /// Initial or global amount of the order.
    /// </summary>
    [IsoId("_7BbjoNuAEeiXqq0XHEoNUA")]
    [DisplayName("Forecasted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrcstdAmt")]
    #endif
    [IsoXmlTag("FrcstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount ForecastedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount ForecastedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount ForecastedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount ForecastedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of all completed transactions of a customer order.
    /// </summary>
    [IsoId("__wALkNuAEeiXqq0XHEoNUA")]
    [DisplayName("Current Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurAmt")]
    #endif
    [IsoXmlTag("CurAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? CurrentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? CurrentAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? CurrentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of monetary amount.
    /// </summary>
    [IsoId("_DvlmkNuBEeiXqq0XHEoNUA")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of an entity accessing data to perform an operation.
    /// </summary>
    [IsoId("_HYXEENuBEeiXqq0XHEoNUA")]
    [DisplayName("Accessed By")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccsdBy")]
    #endif
    [IsoXmlTag("AccsdBy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccessedBy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccessedBy { get; init; } 
    #else
    public System.String? AccessedBy { get; set; } 
    #endif
    
    /// <summary>
    /// Unqualified information related to customer order.
    /// </summary>
    [IsoId("_KkheENuBEeiXqq0XHEoNUA")]
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
