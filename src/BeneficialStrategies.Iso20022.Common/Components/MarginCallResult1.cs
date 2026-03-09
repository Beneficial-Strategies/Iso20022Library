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
/// Provides the summation of the call amounts per margin type and optionaly the default fund amount (only for CCP).
/// </summary>
[IsoId("_UlSuJtp-Ed-ak6NoX_4Aeg_740528065")]
[DisplayName("Margin Call Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCallResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginCallResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCallResult1( MarginCallResult1Choice_ reqMarginCallResult )
    {
        MarginCallResult = reqMarginCallResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total amount required by the clearing member to participate to the default fund.
    /// </summary>
    [IsoId("_UlSuJ9p-Ed-ak6NoX_4Aeg_1920575599")]
    [DisplayName("Default Fund Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltFndAmt")]
    #endif
    [IsoXmlTag("DfltFndAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? DefaultFundAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? DefaultFundAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? DefaultFundAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [IsoId("_UlSuKNp-Ed-ak6NoX_4Aeg_1522303182")]
    [DisplayName("Margin Call Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnCallRslt")]
    #endif
    [IsoXmlTag("MrgnCallRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarginCallResult1Choice_ MarginCallResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarginCallResult1Choice_ MarginCallResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCallResult1Choice_ MarginCallResult { get; init; } 
    #else
    public MarginCallResult1Choice_ MarginCallResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
