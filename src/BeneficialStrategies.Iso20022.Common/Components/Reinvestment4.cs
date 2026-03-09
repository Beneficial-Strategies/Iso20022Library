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
[IsoId("_QD7KJZS8EemqYPWMBuVawg")]
[DisplayName("Reinvestment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reinvestment4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reinvestment4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reinvestment4( FinancialInstrument87 reqFinancialInstrumentDetails,System.Decimal reqReinvestmentPercentage )
    {
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        ReinvestmentPercentage = reqReinvestmentPercentage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Investment fund for the reinvestment.
    /// </summary>
    [IsoId("_QXj3gZS8EemqYPWMBuVawg")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument87 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument87 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument87 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument87 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_QXj3g5S8EemqYPWMBuVawg")]
    [DisplayName("Requested NAV Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdNAVCcy")]
    #endif
    [IsoXmlTag("ReqdNAVCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? RequestedNAVCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedNAVCurrency { get; init; } 
    #else
    public string? RequestedNAVCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the reinvestment.
    /// </summary>
    [IsoId("_QXj3hZS8EemqYPWMBuVawg")]
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
