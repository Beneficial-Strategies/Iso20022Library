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
/// Information used to calculate the tax.
/// </summary>
[IsoId("_VSSXBdp-Ed-ak6NoX_4Aeg_-1673886358")]
[DisplayName("Tax Calculation Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxCalculationInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_VSSXBtp-Ed-ak6NoX_4Aeg_-1625862857")]
    [DisplayName("EU Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUCptlGn")]
    #endif
    [IsoXmlTag("EUCptlGn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUCapitalGain1? EUCapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUCapitalGain1? EUCapitalGain { get; init; } 
    #else
    public EUCapitalGain1? EUCapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_VSSXB9p-Ed-ak6NoX_4Aeg_-1140089322")]
    [DisplayName("Percentage Of Debt Claim")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgOfDebtClm")]
    #endif
    [IsoXmlTag("PctgOfDebtClm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageOfDebtClaim { get; init; } 
    #else
    public System.Decimal? PercentageOfDebtClaim { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of grandfathered debt claim.
    /// </summary>
    [IsoId("_VSSXCNp-Ed-ak6NoX_4Aeg_-1286004635")]
    [DisplayName("Percentage Grandfathered Debt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgGrdfthdDebt")]
    #endif
    [IsoXmlTag("PctgGrdfthdDebt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageGrandfatheredDebt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageGrandfatheredDebt { get; init; } 
    #else
    public System.Decimal? PercentageGrandfatheredDebt { get; set; } 
    #endif
    
    
    #nullable disable
    
}
