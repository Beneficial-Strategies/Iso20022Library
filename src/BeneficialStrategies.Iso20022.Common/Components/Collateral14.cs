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
/// Provides the details of the security pledge as collateral.
/// </summary>
[IsoId("_hc-tS6idEeWHO_l3hf2rlA")]
[DisplayName("Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Collateral14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Collateral14( SecuredCollateral2Choice_ reqValuation )
    {
        Valuation = reqValuation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the values of the security pledged as collateral.
    /// </summary>
    [IsoId("_h6SUMaidEeWHO_l3hf2rlA")]
    [DisplayName("Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Valtn")]
    #endif
    [IsoXmlTag("Valtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuredCollateral2Choice_ Valuation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuredCollateral2Choice_ Valuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuredCollateral2Choice_ Valuation { get; init; } 
    #else
    public SecuredCollateral2Choice_ Valuation { get; set; } 
    #endif
    
    /// <summary>
    /// Risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// For reporting purposes the collateral haircut will be calculated as 100 minus the ratio between the cash lent/borrowed and the market value including accrued interest of the collateral pledged times 100. 
    /// In the case of multi-collateral repos the haircut will be based on the ratio between the cash borrowed/lent and the market value, including accrued interest of each of the individual collateral pledged. 
    /// Only actual values, as opposed to estimated or default values will be reported for this variable.
    /// </summary>
    [IsoId("_h6SUM6idEeWHO_l3hf2rlA")]
    [DisplayName("Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrcut")]
    #endif
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Haircut { get; init; } 
    #else
    public System.Decimal? Haircut { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies all repurchase agreements conducted against general collateral and those conducted against special collateral. 
    /// - General Collateral is a repurchase transaction in which the security lender may choose the security to pledge as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria; 
    /// - Special Collateral is a repurchase transaction in which the cash provider requests a specific security (individual ISIN) to be provided by the cash borrower. 
    /// Usage:
    /// This field is optional and it should be provided only in case it is feasible for the reporting agent.
    /// </summary>
    [IsoId("_h6SUNaidEeWHO_l3hf2rlA")]
    [DisplayName("Special Collateral Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclCollInd")]
    #endif
    [IsoXmlTag("SpclCollInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialCollateral1Code? SpecialCollateralIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialCollateral1Code? SpecialCollateralIndicator { get; init; } 
    #else
    public SpecialCollateral1Code? SpecialCollateralIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
