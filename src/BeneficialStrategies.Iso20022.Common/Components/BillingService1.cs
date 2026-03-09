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
[IsoId("_6PDr1ZqlEeGSON8vddiWzQ_-1150406183")]
[DisplayName("Billing Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingService1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingService1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingService1( BillingServiceParameters1 reqServiceDetail,ServicePaymentMethod1Code reqPaymentMethod,AmountAndDirection34 reqOriginalChargePrice,ServiceTaxDesignation1 reqTaxDesignation )
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
    [IsoId("_6PDr1pqlEeGSON8vddiWzQ_-1969359864")]
    [DisplayName("Service Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcDtl")]
    #endif
    [IsoXmlTag("SvcDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingServiceParameters1 ServiceDetail { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingServiceParameters1 ServiceDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingServiceParameters1 ServiceDetail { get; init; } 
    #else
    public BillingServiceParameters1 ServiceDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Price applied to the service, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6PDr15qlEeGSON8vddiWzQ_972952151")]
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
    [IsoId("_6PDr2JqlEeGSON8vddiWzQ_-322179582")]
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
    [IsoId("_6PNc0JqlEeGSON8vddiWzQ_-525586085")]
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
    [IsoId("_6PNc0ZqlEeGSON8vddiWzQ_1343532522")]
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
    [IsoId("_6PNc0pqlEeGSON8vddiWzQ_-551745174")]
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
    [IsoId("_6PNc05qlEeGSON8vddiWzQ_-1099969523")]
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
    [IsoId("_6PNc1JqlEeGSON8vddiWzQ_-972287511")]
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
