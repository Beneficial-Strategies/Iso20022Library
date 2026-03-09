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
/// Provides information about total instructed balance.
/// </summary>
[IsoId("_R9gMhdp-Ed-ak6NoX_4Aeg_1405165936")]
[DisplayName("Instructed Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedBalanceDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedBalanceDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedBalanceDetails1( BalanceFormat1Choice_ reqTotalInstructedBalance )
    {
        TotalInstructedBalance = reqTotalInstructedBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_R9gMhtp-Ed-ak6NoX_4Aeg_1822595473")]
    [DisplayName("Total Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBal")]
    #endif
    [IsoXmlTag("TtlInstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat1Choice_ TotalInstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat1Choice_ TotalInstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_ TotalInstructedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_ TotalInstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_R9gMh9p-Ed-ak6NoX_4Aeg_499849105")]
    [DisplayName("Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtls")]
    #endif
    [IsoXmlTag("OptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructedCorporateActionOption1? OptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedCorporateActionOption1? OptionDetails { get; init; } 
    #else
    public InstructedCorporateActionOption1? OptionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
