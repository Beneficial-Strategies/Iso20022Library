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
[IsoId("_S0j3JQEcEeCQm6a_G2yO_w_-1391363136")]
[DisplayName("Settlement Sub Total Calculated Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementSubTotalCalculatedTax1
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
    [IsoId("_S0j3JgEcEeCQm6a_G2yO_w_894669063")]
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
    /// Reference used to identify the nature of tax levied, such as Value Added Tax (VAT).
    /// </summary>
    [IsoId("_S0j3JwEcEeCQm6a_G2yO_w_-604171621")]
    [DisplayName("Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyCd")]
    #endif
    [IsoXmlTag("CtgyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? CategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CategoryCode { get; init; } 
    #else
    public System.String? CategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    [IsoId("_S0j3KAEcEeCQm6a_G2yO_w_1356444979")]
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
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    [IsoId("_S0j3KQEcEeCQm6a_G2yO_w_-878123317")]
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
    /// Rate used to calculate the amount of this tax, levy or duty.
    /// </summary>
    [IsoId("_S0j3KgEcEeCQm6a_G2yO_w_-1188081468")]
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
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_S0j3KwEcEeCQm6a_G2yO_w_-1889469346")]
    [DisplayName("Exemption Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnRsn")]
    #endif
    [IsoXmlTag("XmptnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxExemptionReason1? ExemptionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxExemptionReason1? ExemptionReason { get; init; } 
    #else
    public TaxExemptionReason1? ExemptionReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
