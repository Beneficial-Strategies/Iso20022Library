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
/// Reinvestment information.
/// </summary>
[IsoId("_miRygBQ8EeOKWo1NF21OVw")]
[DisplayName("Reinvestment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reinvestment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reinvestment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reinvestment1( FinancialInstrument29 reqFundDetails,System.Decimal reqReinvestmentPercentage )
    {
        FundDetails = reqFundDetails;
        ReinvestmentPercentage = reqReinvestmentPercentage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Investment fund for the reinvestment.
    /// </summary>
    [IsoId("_3fQRABQ8EeOKWo1NF21OVw")]
    [DisplayName("Fund Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndDtls")]
    #endif
    [IsoXmlTag("FndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument29 FundDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument29 FundDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument29 FundDetails { get; init; } 
    #else
    public FinancialInstrument29 FundDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_GWLB8BQ9EeOKWo1NF21OVw")]
    [DisplayName("Requested NAV Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdNAVCcy")]
    #endif
    [IsoXmlTag("ReqdNAVCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? RequestedNAVCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedNAVCurrency { get; init; } 
    #else
    public string? RequestedNAVCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the reinvestment.
    /// </summary>
    [IsoId("_WIXvYBQ9EeOKWo1NF21OVw")]
    [DisplayName("Reinvestment Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtPctg")]
    #endif
    [IsoXmlTag("RinvstmtPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate ReinvestmentPercentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal ReinvestmentPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ReinvestmentPercentage { get; init; } 
    #else
    public System.Decimal ReinvestmentPercentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
