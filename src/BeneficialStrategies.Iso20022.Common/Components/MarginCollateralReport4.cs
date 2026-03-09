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
/// Details of margin collateral agreement between counterparties.
/// </summary>
[IsoId("_1w_vQVosEe23K4GXSpBSeg")]
[DisplayName("Margin Collateral Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCollateralReport4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginCollateralReport4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCollateralReport4( CollateralPortfolioCode5Choice_ reqCollateralPortfolioCode,CollateralisationType3Code reqCollateralisationCategory )
    {
        CollateralPortfolioCode = reqCollateralPortfolioCode;
        CollateralisationCategory = reqCollateralisationCategory;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_1ywp0VosEe23K4GXSpBSeg")]
    [DisplayName("Collateral Portfolio Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrtflCd")]
    #endif
    [IsoXmlTag("CollPrtflCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralPortfolioCode5Choice_ CollateralPortfolioCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralPortfolioCode5Choice_ CollateralPortfolioCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralPortfolioCode5Choice_ CollateralPortfolioCode { get; init; } 
    #else
    public CollateralPortfolioCode5Choice_ CollateralPortfolioCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of collateral agreement existing between the counterparties.
    /// </summary>
    [IsoId("_1ywp01osEe23K4GXSpBSeg")]
    [DisplayName("Collateralisation Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollstnCtgy")]
    #endif
    [IsoXmlTag("CollstnCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralisationType3Code CollateralisationCategory { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralisationType3Code CollateralisationCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralisationType3Code CollateralisationCategory { get; init; } 
    #else
    public CollateralisationType3Code CollateralisationCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the last collateral amount determination or calculation.
    /// </summary>
    [IsoId("_1ywp1VosEe23K4GXSpBSeg")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TimeStamp { get; init; } 
    #else
    public System.DateTime? TimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
