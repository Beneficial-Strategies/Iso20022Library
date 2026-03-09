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
/// Provides information such as the default fund account identification or the default fund amount.
/// </summary>
[IsoId("_UqpvS9p-Ed-ak6NoX_4Aeg_1890910429")]
[DisplayName("Default Fund")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DefaultFund1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DefaultFund1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DefaultFund1( AccountIdentification4Choice_ reqDefaultFundAccount,ActiveCurrencyAndAmount reqTotalDefaultFundAmount )
    {
        DefaultFundAccount = reqDefaultFundAccount;
        TotalDefaultFundAmount = reqTotalDefaultFundAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the account identification of the clearing member at the ICSD (International Central Securities Depository) or at the central bank.
    /// </summary>
    [IsoId("_UqpvTNp-Ed-ak6NoX_4Aeg_82468307")]
    [DisplayName("Default Fund Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltFndAcct")]
    #endif
    [IsoXmlTag("DfltFndAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification4Choice_ DefaultFundAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification4Choice_ DefaultFundAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_ DefaultFundAccount { get; init; } 
    #else
    public AccountIdentification4Choice_ DefaultFundAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount required by the clearing member to participate to the default fund.
    /// </summary>
    [IsoId("_UqpvTdp-Ed-ak6NoX_4Aeg_107176358")]
    [DisplayName("Total Default Fund Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDfltFndAmt")]
    #endif
    [IsoXmlTag("TtlDfltFndAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalDefaultFundAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalDefaultFundAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalDefaultFundAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalDefaultFundAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the contribution to the default fund by trading venues/products.
    /// </summary>
    [IsoId("_UqzgQNp-Ed-ak6NoX_4Aeg_-799365417")]
    [DisplayName("Contribution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntrbtn")]
    #endif
    [IsoXmlTag("Cntrbtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contribution1? Contribution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contribution1? Contribution { get; init; } 
    #else
    public Contribution1? Contribution { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amount that the clearing member will have to provide to cover a risk increase. This results from a risk management decision depending on central counterparty specific criteria.
    /// </summary>
    [IsoId("_UqzgQdp-Ed-ak6NoX_4Aeg_1324320952")]
    [DisplayName("Increase Coverage Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncrCvrgAmt")]
    #endif
    [IsoXmlTag("IncrCvrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? IncreaseCoverageAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? IncreaseCoverageAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? IncreaseCoverageAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
