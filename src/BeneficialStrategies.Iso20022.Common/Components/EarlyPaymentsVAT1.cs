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
/// Specifies the payment terms of the underlying transaction.
/// </summary>
[IsoId("_2ioGoVnKEeOQYsoJizpkVw")]
[DisplayName("Early Payments VAT")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EarlyPaymentsVAT1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EarlyPaymentsVAT1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EarlyPaymentsVAT1( System.Decimal reqTaxRate,System.String reqDiscountTaxType,CurrencyAndAmount reqDiscountTaxAmount )
    {
        TaxRate = reqTaxRate;
        DiscountTaxType = reqDiscountTaxType;
        DiscountTaxAmount = reqDiscountTaxAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Tax rate to be applied for early payment.
    /// </summary>
    [IsoId("__SA4oFnKEeOQYsoJizpkVw")]
    [DisplayName("Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRate")]
    #endif
    [IsoXmlTag("TaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate TaxRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal TaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal TaxRate { get; init; } 
    #else
    public System.Decimal TaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_FFf6MFnLEeOQYsoJizpkVw")]
    [DisplayName("Discount Tax Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntTaxTp")]
    #endif
    [IsoXmlTag("DscntTaxTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4Text DiscountTaxType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DiscountTaxType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DiscountTaxType { get; init; } 
    #else
    public System.String DiscountTaxType { get; set; } 
    #endif
    
    /// <summary>
    /// Early payment discount tax amount calculated using defined tax rate.
    /// </summary>
    [IsoId("_KOJPAFnLEeOQYsoJizpkVw")]
    [DisplayName("Discount Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntTaxAmt")]
    #endif
    [IsoXmlTag("DscntTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount DiscountTaxAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount DiscountTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount DiscountTaxAmount { get; init; } 
    #else
    public CurrencyAndAmount DiscountTaxAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
