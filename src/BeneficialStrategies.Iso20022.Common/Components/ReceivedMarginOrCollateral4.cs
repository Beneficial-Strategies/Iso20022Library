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
/// Information on the received margin or collateral of the transaction.
/// </summary>
[IsoId("_Gw_uEa2lEeujnrmCqLd8pg")]
[DisplayName("Received Margin Or Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceivedMarginOrCollateral4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty.
    /// Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// </summary>
    [IsoId("_HAfioa2lEeujnrmCqLd8pg")]
    [DisplayName("Initial Margin Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRcvd")]
    #endif
    [IsoXmlTag("InitlMrgnRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? InitialMarginReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? InitialMarginReceived { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? InitialMarginReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty. 
    /// Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// </summary>
    [IsoId("_HAfio62lEeujnrmCqLd8pg")]
    [DisplayName("Variation Margin Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRcvd")]
    #endif
    [IsoXmlTag("VartnMrgnRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? VariationMarginReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? VariationMarginReceived { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? VariationMarginReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_HAfipa2lEeujnrmCqLd8pg")]
    [DisplayName("Excess Collateral Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollRcvd")]
    #endif
    [IsoXmlTag("XcssCollRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ExcessCollateralReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ExcessCollateralReceived { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ExcessCollateralReceived { get; set; } 
    #endif
    
    
    #nullable disable
    
}
