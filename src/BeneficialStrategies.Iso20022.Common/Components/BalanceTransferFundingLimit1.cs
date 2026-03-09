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
/// Maximum value that the new bank will pay to the old bank when the closing balance on the old bank is negative.
/// </summary>
[IsoId("_x14swQ2aEeSNWNtJlXOAhg")]
[DisplayName("Balance Transfer Funding Limit")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceTransferFundingLimit1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceTransferFundingLimit1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceTransferFundingLimit1( ActiveCurrencyAndAmount reqCurrencyAmount )
    {
        CurrencyAmount = reqCurrencyAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum value and related currency that can be sent by the new account servicer to the old account servicer in case of a negative closing balance.
    /// </summary>
    [IsoId("_354PgA2aEeSNWNtJlXOAhg")]
    [DisplayName("Currency Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyAmt")]
    #endif
    [IsoXmlTag("CcyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CurrencyAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CurrencyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CurrencyAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount CurrencyAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
