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
/// Provides details about the accepted collateral substitution.
/// </summary>
[IsoId("_QnhRANp-Ed-ak6NoX_4Aeg_1142450106")]
[DisplayName("Collateral Substitution Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralSubstitutionResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralSubstitutionResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralSubstitutionResponse1( System.String reqCollateralSubstitutionRequestIdentification )
    {
        CollateralSubstitutionRequestIdentification = reqCollateralSubstitutionRequestIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the collateral substitution request identification.
    /// </summary>
    [IsoId("_QnhRAdp-Ed-ak6NoX_4Aeg_-1599404554")]
    [DisplayName("Collateral Substitution Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnReqId")]
    #endif
    [IsoXmlTag("CollSbstitnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CollateralSubstitutionRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralSubstitutionRequestIdentification { get; init; } 
    #else
    public System.String CollateralSubstitutionRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the accepted collateral substitution amount.
    /// </summary>
    [IsoId("_QnhRAtp-Ed-ak6NoX_4Aeg_492922739")]
    [DisplayName("Accepted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdAmt")]
    #endif
    [IsoXmlTag("AccptdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AcceptedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
