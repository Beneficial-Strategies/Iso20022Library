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
/// Information regarding the total amount of taxes.
/// </summary>
[IsoId("_WKLBTNp-Ed-ak6NoX_4Aeg_-1710794276")]
[DisplayName("Total Taxes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalTaxes5
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
    [IsoId("_WKULMNp-Ed-ak6NoX_4Aeg_-1709874182")]
    [DisplayName("EU Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUCptlGn")]
    #endif
    [IsoXmlTag("EUCptlGn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    #else
    public EUCapitalGain2Code? EUCapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_WKULMdp-Ed-ak6NoX_4Aeg_-1709874006")]
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
    /// Information related to a specific tax.
    /// </summary>
    [IsoId("_WKULMtp-Ed-ak6NoX_4Aeg_-1709873727")]
    [DisplayName("Tax Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDtls")]
    #endif
    [IsoXmlTag("TaxDtls")]
    [MinLength(0)]
    [MaxLength(7)]
    public ValueList<Tax20> TaxDetails { get; init; } = new ValueList<Tax20>(){};
    
    
    #nullable disable
    
}
