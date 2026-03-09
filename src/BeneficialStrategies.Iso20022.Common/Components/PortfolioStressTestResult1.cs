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
/// Outcome of the application of a hypothetical scenario on the valuation of a portfolio of financial instruments.
/// </summary>
[IsoId("_pRc2MKs_Eeayv9XxdmMwKQ")]
[DisplayName("Portfolio Stress Test Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PortfolioStressTestResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PortfolioStressTestResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PortfolioStressTestResult1( GenericIdentification165 reqPortfolioIdentification,AmountAndDirection102 reqStressLoss,System.String reqCover1Flag,System.String reqCover2Flag )
    {
        PortfolioIdentification = reqPortfolioIdentification;
        StressLoss = reqStressLoss;
        Cover1Flag = reqCover1Flag;
        Cover2Flag = reqCover2Flag;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the portfolio.
    /// </summary>
    [IsoId("_0leIIKs_Eeayv9XxdmMwKQ")]
    [DisplayName("Portfolio Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtflId")]
    #endif
    [IsoXmlTag("PrtflId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification165 PortfolioIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification165 PortfolioIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165 PortfolioIdentification { get; init; } 
    #else
    public GenericIdentification165 PortfolioIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Calculated stress loss over the initial margin requirement, as used in the calculation of stress testing losses to size the default fund. Indicates whether the portfolio experienced a stress loss greater than initial margin.
    /// </summary>
    [IsoId("_Fwj7IKtAEeayv9XxdmMwKQ")]
    [DisplayName("Stress Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrssLoss")]
    #endif
    [IsoXmlTag("StrssLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 StressLoss { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 StressLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 StressLoss { get; init; } 
    #else
    public AmountAndDirection102 StressLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Calculated raw stress loss, as used in the calculation of stress testing losses to size the default fund. Indicates whether the portfolio experienced a stress loss.
    /// </summary>
    [IsoId("_wZC40OUSEem3X-64-NKdqg")]
    [DisplayName("Raw Stress Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RawStrssLoss")]
    #endif
    [IsoXmlTag("RawStrssLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection102? RawStressLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102? RawStressLoss { get; init; } 
    #else
    public AmountAndDirection102? RawStressLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the stress loss over initial margin under this scenario for the clearing member of which the corresponding account is an account, is the largest stress over initial margin used to size the default fund.
    /// </summary>
    [IsoId("_PMMvIKtAEeayv9XxdmMwKQ")]
    [DisplayName("Cover 1 Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cover1Flg")]
    #endif
    [IsoXmlTag("Cover1Flg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator Cover1Flag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Cover1Flag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Cover1Flag { get; init; } 
    #else
    public System.String Cover1Flag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the stress loss over initial margin under this scenario for the clearing member of which the corresponding account is an account, is the second largest stress over initial margin used to size the default fund.
    /// </summary>
    [IsoId("_Rk99UKtAEeayv9XxdmMwKQ")]
    [DisplayName("Cover 2 Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cover2Flg")]
    #endif
    [IsoXmlTag("Cover2Flg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator Cover2Flag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Cover2Flag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Cover2Flag { get; init; } 
    #else
    public System.String Cover2Flag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
