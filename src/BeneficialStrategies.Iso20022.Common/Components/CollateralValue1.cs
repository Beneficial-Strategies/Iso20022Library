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
/// Provides details of the collateral reference data.
/// </summary>
[IsoId("_jAaZE-5NEeCisYr99QEiWA_851211093")]
[DisplayName("Collateral Value")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValue1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralValue1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralValue1( System.String reqSecurityIdentification,System.DateOnly reqValuationDate,AmountOrCoefficientPrice1Choice_ reqValuationPrice )
    {
        SecurityIdentification = reqSecurityIdentification;
        ValuationDate = reqValuationDate;
        ValuationPrice = reqValuationPrice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_jAaZFO5NEeCisYr99QEiWA_-548343837")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINIdentifier SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecurityIdentification { get; init; } 
    #else
    public System.String SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation date for the price.
    /// </summary>
    [IsoId("_jAkKEO5NEeCisYr99QEiWA_1592137702")]
    [DisplayName("Valuation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDt")]
    #endif
    [IsoXmlTag("ValtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValuationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValuationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValuationDate { get; init; } 
    #else
    public System.DateOnly ValuationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the currency of the valuation.
    /// </summary>
    [IsoId("_jAkKEe5NEeCisYr99QEiWA_-1467045805")]
    [DisplayName("Valuation Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnCcy")]
    #endif
    [IsoXmlTag("ValtnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? ValuationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ValuationCurrency { get; init; } 
    #else
    public string? ValuationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the price provided for the security.
    /// </summary>
    [IsoId("_jAkKEu5NEeCisYr99QEiWA_2030771480")]
    [DisplayName("Valuation Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnPric")]
    #endif
    [IsoXmlTag("ValtnPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrCoefficientPrice1Choice_ ValuationPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrCoefficientPrice1Choice_ ValuationPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrCoefficientPrice1Choice_ ValuationPrice { get; init; } 
    #else
    public AmountOrCoefficientPrice1Choice_ ValuationPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
