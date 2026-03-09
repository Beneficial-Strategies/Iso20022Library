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
/// Specifies the subtotal calculated tax applicable for this settlement.
/// </summary>
[IsoId("_sGUvgKtnEeSPCbFcs9Ilyw")]
[DisplayName("Settlement Sub Total Calculated Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementSubTotalCalculatedTax2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_A84usKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpCd")]
    #endif
    [IsoXmlTag("TpCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? TypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TypeCode { get; init; } 
    #else
    public System.String? TypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the amount of this tax, levy or duty.
    /// </summary>
    [IsoId("_S-CnAKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Calculated Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctdRate")]
    #endif
    [IsoXmlTag("ClctdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? CalculatedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CalculatedRate { get; init; } 
    #else
    public System.Decimal? CalculatedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    [IsoId("_PI8kwKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Basis Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisAmt")]
    #endif
    [IsoXmlTag("BsisAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? BasisAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? BasisAmount { get; init; } 
    #else
    public CurrencyAndAmount? BasisAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    [IsoId("_Khf4gKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Calculated Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctdAmt")]
    #endif
    [IsoXmlTag("ClctdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? CalculatedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? CalculatedAmount { get; init; } 
    #else
    public CurrencyAndAmount? CalculatedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for tax exemption expressed as a code, if invoice or card transaction is out of tax processing.
    /// </summary>
    [IsoId("_ZH9yoKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Exemption Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnRsnCd")]
    #endif
    [IsoXmlTag("XmptnRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? ExemptionReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExemptionReasonCode { get; init; } 
    #else
    public System.String? ExemptionReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for a tax exemption, if invoice or card transaction is out of tax processing.
    /// </summary>
    [IsoId("_-mMusKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Exemption Reason Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnRsnTxt")]
    #endif
    [IsoXmlTag("XmptnRsnTxt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? ExemptionReasonText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExemptionReasonText { get; init; } 
    #else
    public System.String? ExemptionReasonText { get; set; } 
    #endif
    
    /// <summary>
    /// If tax currency in tax calculation is different from invoice currency, then applied exchange rate is given in this message structure.
    /// </summary>
    [IsoId("_WOKf4KuoEeSmE8_WfXaYYg")]
    [DisplayName("Tax Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCcyXchg")]
    #endif
    [IsoXmlTag("TaxCcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyReference3? TaxCurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyReference3? TaxCurrencyExchange { get; init; } 
    #else
    public CurrencyReference3? TaxCurrencyExchange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
