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
/// Specifies the values used for every line item service in the statement.
/// </summary>
[IsoId("_aySiUDq2EeWZFYSPlduMhw")]
[DisplayName("Billing Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingService2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingService2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingService2( BillingServiceParameters3 reqServiceDetail,ServicePaymentMethod1Code reqPaymentMethod,AmountAndDirection34 reqOriginalChargePrice,ServiceTaxDesignation1 reqTaxDesignation )
    {
        ServiceDetail = reqServiceDetail;
        PaymentMethod = reqPaymentMethod;
        OriginalChargePrice = reqOriginalChargePrice;
        TaxDesignation = reqTaxDesignation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies further detailed values for this service.
    /// </summary>
    [IsoId("_a5J_UTq2EeWZFYSPlduMhw")]
    [DisplayName("Service Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcDtl")]
    #endif
    [IsoXmlTag("SvcDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingServiceParameters3 ServiceDetail { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingServiceParameters3 ServiceDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingServiceParameters3 ServiceDetail { get; init; } 
    #else
    public BillingServiceParameters3 ServiceDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Price applied to the service, expressed in the pricing currency.
    /// </summary>
    [IsoId("_a5J_Uzq2EeWZFYSPlduMhw")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingPrice1? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingPrice1? Price { get; init; } 
    #else
    public BillingPrice1? Price { get; set; } 
    #endif
    
    /// <summary>
    /// Code identifying the disposition of the calculated charge.
    /// </summary>
    [IsoId("_a5J_VTq2EeWZFYSPlduMhw")]
    [DisplayName("Payment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtd")]
    #endif
    [IsoXmlTag("PmtMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ServicePaymentMethod1Code PaymentMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ServicePaymentMethod1Code PaymentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServicePaymentMethod1Code PaymentMethod { get; init; } 
    #else
    public ServicePaymentMethod1Code PaymentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the calculated charge, expressed in the pricing currency. This value does not include any tax on the service.
    /// </summary>
    [IsoId("_a5J_Vzq2EeWZFYSPlduMhw")]
    [DisplayName("Original Charge Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlChrgPric")]
    #endif
    [IsoXmlTag("OrgnlChrgPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 OriginalChargePrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 OriginalChargePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 OriginalChargePrice { get; init; } 
    #else
    public AmountAndDirection34 OriginalChargePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the calculated charge, expressed in the settlement currency.
    /// </summary>
    [IsoId("_a5J_WTq2EeWZFYSPlduMhw")]
    [DisplayName("Original Charge Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlChrgSttlmAmt")]
    #endif
    [IsoXmlTag("OrgnlChrgSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? OriginalChargeSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? OriginalChargeSettlementAmount { get; init; } 
    #else
    public AmountAndDirection34? OriginalChargeSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Average daily collected balance required to offset a balance compensable service charge, exclusive of taxes, expressed in the account currency.
    /// </summary>
    [IsoId("_a5J_Wzq2EeWZFYSPlduMhw")]
    [DisplayName("Balance Required Account Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalReqrdAcctAmt")]
    #endif
    [IsoXmlTag("BalReqrdAcctAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? BalanceRequiredAccountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? BalanceRequiredAccountAmount { get; init; } 
    #else
    public AmountAndDirection34? BalanceRequiredAccountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the taxable status of a service.
    /// </summary>
    [IsoId("_a5J_XTq2EeWZFYSPlduMhw")]
    [DisplayName("Tax Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDsgnt")]
    #endif
    [IsoXmlTag("TaxDsgnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ServiceTaxDesignation1 TaxDesignation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ServiceTaxDesignation1 TaxDesignation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceTaxDesignation1 TaxDesignation { get; init; } 
    #else
    public ServiceTaxDesignation1 TaxDesignation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides tax related values for tax calculation methods A, B or D.
    /// </summary>
    [IsoId("_a5J_Xzq2EeWZFYSPlduMhw")]
    [DisplayName("Tax Calculation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctn")]
    #endif
    [IsoXmlTag("TaxClctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingMethod1Choice_? TaxCalculation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingMethod1Choice_? TaxCalculation { get; init; } 
    #else
    public BillingMethod1Choice_? TaxCalculation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
