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
/// Specifies the unique codes.
/// </summary>
[IsoId("_tm21gTICEe2fXedS_ucFOA")]
[DisplayName("Margin Portfolio")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginPortfolio3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginPortfolio3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginPortfolio3( PortfolioCode5Choice_ reqInitialMarginPortfolioCode )
    {
        InitialMarginPortfolioCode = reqInitialMarginPortfolioCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_tnypoTICEe2fXedS_ucFOA")]
    [DisplayName("Initial Margin Portfolio Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnPrtflCd")]
    #endif
    [IsoXmlTag("InitlMrgnPrtflCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PortfolioCode5Choice_ InitialMarginPortfolioCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PortfolioCode5Choice_ InitialMarginPortfolioCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PortfolioCode5Choice_ InitialMarginPortfolioCode { get; init; } 
    #else
    public PortfolioCode5Choice_ InitialMarginPortfolioCode { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_tnypozICEe2fXedS_ucFOA")]
    [DisplayName("Variation Margin Portfolio Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPrtflCd")]
    #endif
    [IsoXmlTag("VartnMrgnPrtflCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; init; } 
    #else
    public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
