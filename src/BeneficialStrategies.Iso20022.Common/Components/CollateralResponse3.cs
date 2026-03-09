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
/// Provides additional information on the collateral proposal(s), that is either in cash, securities or other types.
/// </summary>
[IsoId("_wfCNlytIEeyOa655cLd-DQ")]
[DisplayName("Collateral Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralResponse3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details on the securities collateral proposal.
    /// </summary>
    [IsoId("_w3eiwytIEeyOa655cLd-DQ")]
    [DisplayName("Securities Collateral Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesCollRspn")]
    #endif
    [IsoXmlTag("SctiesCollRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCollateralResponse2? SecuritiesCollateralResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCollateralResponse2? SecuritiesCollateralResponse { get; init; } 
    #else
    public SecuritiesCollateralResponse2? SecuritiesCollateralResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the cash collateral proposal.
    /// </summary>
    [IsoId("_w3eixStIEeyOa655cLd-DQ")]
    [DisplayName("Cash Collateral Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCollRspn")]
    #endif
    [IsoXmlTag("CshCollRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashCollateralResponse3? CashCollateralResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashCollateralResponse3? CashCollateralResponse { get; init; } 
    #else
    public CashCollateralResponse3? CashCollateralResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on other collateral proposal.
    /// </summary>
    [IsoId("_w3eixytIEeyOa655cLd-DQ")]
    [DisplayName("Other Collateral Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCollRspn")]
    #endif
    [IsoXmlTag("OthrCollRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherCollateralResponse3? OtherCollateralResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherCollateralResponse3? OtherCollateralResponse { get; init; } 
    #else
    public OtherCollateralResponse3? OtherCollateralResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
