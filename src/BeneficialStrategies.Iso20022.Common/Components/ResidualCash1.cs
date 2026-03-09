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
/// Specifies whether there is cash in the account awaiting investment.
/// </summary>
[IsoId("_lCZdAJP6EemyZbjY08A1Vw")]
[DisplayName("Residual Cash")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResidualCash1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResidualCash1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResidualCash1( System.String reqResidualCashIndicator )
    {
        ResidualCashIndicator = reqResidualCashIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether there is cash in the account awaiting investment.
    /// </summary>
    [IsoId("_sjPYQZP6EemyZbjY08A1Vw")]
    [DisplayName("Residual Cash Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsdlCshInd")]
    #endif
    [IsoXmlTag("RsdlCshInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ResidualCashIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ResidualCashIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ResidualCashIndicator { get; init; } 
    #else
    public System.String ResidualCashIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the cash.
    /// </summary>
    [IsoId("___3wEJP6EemyZbjY08A1Vw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
