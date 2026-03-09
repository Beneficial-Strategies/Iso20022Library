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
/// Value of total holdings reported.
/// </summary>
[IsoId("_Q7Cp9tp-Ed-ak6NoX_4Aeg_-277574684")]
[DisplayName("Total Value In Page And Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalValueInPageAndStatement
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TotalValueInPageAndStatement instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TotalValueInPageAndStatement( ActiveCurrencyAndAmount reqTotalHoldingsValueOfStatement )
    {
        TotalHoldingsValueOfStatement = reqTotalHoldingsValueOfStatement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of positions reported in this message.
    /// </summary>
    [IsoId("_Q7Cp99p-Ed-ak6NoX_4Aeg_-1277686772")]
    [DisplayName("Total Holdings Value Of Page")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlHldgsValOfPg")]
    #endif
    [IsoXmlTag("TtlHldgsValOfPg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalHoldingsValueOfPage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalHoldingsValueOfPage { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalHoldingsValueOfPage { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_Q7Ma8Np-Ed-ak6NoX_4Aeg_-1254598967")]
    [DisplayName("Total Holdings Value Of Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlHldgsValOfStmt")]
    #endif
    [IsoXmlTag("TtlHldgsValOfStmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalHoldingsValueOfStatement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalHoldingsValueOfStatement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalHoldingsValueOfStatement { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalHoldingsValueOfStatement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
