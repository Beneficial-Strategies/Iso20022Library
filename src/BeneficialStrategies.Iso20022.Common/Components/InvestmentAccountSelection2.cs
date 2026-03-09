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
/// Choice between a unique account identification and a set of account selection criteria.
/// </summary>
[IsoId("_RRsPZ9p-Ed-ak6NoX_4Aeg_-1532088201")]
[DisplayName("Investment Account Selection")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccountSelection2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccountSelection2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccountSelection2( AccountIdentification1 reqAccountIdentification,InvestmentAccount29 reqOtherAccountSelectionData )
    {
        AccountIdentification = reqAccountIdentification;
        OtherAccountSelectionData = reqOtherAccountSelectionData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_RRsPaNp-Ed-ak6NoX_4Aeg_-1532088182")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification1 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification1 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification1 AccountIdentification { get; init; } 
    #else
    public AccountIdentification1 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Various investment account information used to select a specific account.
    /// </summary>
    [IsoId("_RR2AYNp-Ed-ak6NoX_4Aeg_-1532088147")]
    [DisplayName("Other Account Selection Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAcctSelctnData")]
    #endif
    [IsoXmlTag("OthrAcctSelctnData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount29 OtherAccountSelectionData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount29 OtherAccountSelectionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount29 OtherAccountSelectionData { get; init; } 
    #else
    public InvestmentAccount29 OtherAccountSelectionData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
