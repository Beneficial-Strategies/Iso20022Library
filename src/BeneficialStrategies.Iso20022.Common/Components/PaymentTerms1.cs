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
[IsoId("_Prd4dNp-Ed-ak6NoX_4Aeg_851180831")]
[DisplayName("Payment Terms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTerms1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTerms1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTerms1( System.String reqOtherPaymentTerms,PaymentPeriod1 reqPaymentCode,System.Decimal reqPercentage,CurrencyAndAmount reqAmount )
    {
        OtherPaymentTerms = reqOtherPaymentTerms;
        PaymentCode = reqPaymentCode;
        Percentage = reqPercentage;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies payment terms not present in a code list.
    /// </summary>
    [IsoId("_Prd4ddp-Ed-ak6NoX_4Aeg_1227100069")]
    [DisplayName("Other Payment Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPmtTerms")]
    #endif
    [IsoXmlTag("OthrPmtTerms")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text OtherPaymentTerms { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OtherPaymentTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OtherPaymentTerms { get; init; } 
    #else
    public System.String OtherPaymentTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the payment period in coded form and a number of days.
    /// </summary>
    [IsoId("_Prd4dtp-Ed-ak6NoX_4Aeg_-1773090944")]
    [DisplayName("Payment Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCd")]
    #endif
    [IsoXmlTag("PmtCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentPeriod1 PaymentCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentPeriod1 PaymentCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentPeriod1 PaymentCode { get; init; } 
    #else
    public PaymentPeriod1 PaymentCode { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the payment conditions apply to a percentage of the amount due.
    /// </summary>
    [IsoId("_Prd4d9p-Ed-ak6NoX_4Aeg_791045590")]
    [DisplayName("Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pctg")]
    #endif
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Percentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Percentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Percentage { get; init; } 
    #else
    public System.Decimal Percentage { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_PrnpcNp-Ed-ak6NoX_4Aeg_1065328418")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount Amount { get; init; } 
    #else
    public CurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
