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
/// Provides the valuation of a collateral, identified through an ISIN.
/// </summary>
[IsoId("_iZO6CaidEeWHO_l3hf2rlA")]
[DisplayName("Collateral Valuation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValuation6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralValuation6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralValuation6( System.String reqISIN )
    {
        ISIN = reqISIN;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Nominal amount of the security pledged as collateral. Except for tri-party repos and any other transaction in which the security pledged is not identified via a single ISIN.
    /// </summary>
    [IsoId("_i2_NAaidEeWHO_l3hf2rlA")]
    [DisplayName("Nominal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmnlAmt")]
    #endif
    [IsoXmlTag("NmnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NominalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NominalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NominalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_i2_NA6idEeWHO_l3hf2rlA")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier ISIN { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ISIN { get; init; } 
    #else
    public System.String ISIN { get; set; } 
    #endif
    
    
    #nullable disable
    
}
