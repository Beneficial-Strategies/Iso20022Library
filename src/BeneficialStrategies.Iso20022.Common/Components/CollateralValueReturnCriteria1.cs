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
/// Defines the criteria used to report on collateral.
/// </summary>
[IsoId("__7yZ5zpsEemk2e6qGBk8IQ")]
[DisplayName("Collateral Value Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValueReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the cash account owner information is requested.
    /// </summary>
    [IsoId("_AF6mUTptEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Owner Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctOwnrInd")]
    #endif
    [IsoXmlTag("CshAcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CashAccountOwnerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashAccountOwnerIndicator { get; init; } 
    #else
    public System.String? CashAccountOwnerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cash account servicer information is requested.
    /// </summary>
    [IsoId("_AF6mUzptEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Servicer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctSvcrInd")]
    #endif
    [IsoXmlTag("CshAcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CashAccountServicerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashAccountServicerIndicator { get; init; } 
    #else
    public System.String? CashAccountServicerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities account owner information is requested.
    /// </summary>
    [IsoId("_LCkhFTptEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Owner Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctOwnrInd")]
    #endif
    [IsoXmlTag("SctiesAcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SecuritiesAccountOwnerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesAccountOwnerIndicator { get; init; } 
    #else
    public System.String? SecuritiesAccountOwnerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities account servicer information is requested.
    /// </summary>
    [IsoId("_LCkhFjptEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Servicer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctSvcrInd")]
    #endif
    [IsoXmlTag("SctiesAcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SecuritiesAccountServicerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesAccountServicerIndicator { get; init; } 
    #else
    public System.String? SecuritiesAccountServicerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the total value of the collateral valuation information is requested..
    /// </summary>
    [IsoId("_LCkhFzptEemk2e6qGBk8IQ")]
    [DisplayName("Total Collateral Valuation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCollValtnInd")]
    #endif
    [IsoXmlTag("TtlCollValtnInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TotalCollateralValuationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalCollateralValuationIndicator { get; init; } 
    #else
    public System.String? TotalCollateralValuationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities account information is requested.
    /// </summary>
    [IsoId("_LCkhGDptEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctInd")]
    #endif
    [IsoXmlTag("SctiesAcctInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SecuritiesAccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesAccountIndicator { get; init; } 
    #else
    public System.String? SecuritiesAccountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities account information is requested.
    /// </summary>
    [IsoId("_LCkhGTptEemk2e6qGBk8IQ")]
    [DisplayName("Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scties")]
    #endif
    [IsoXmlTag("Scties")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? Securities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Securities { get; init; } 
    #else
    public System.String? Securities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
