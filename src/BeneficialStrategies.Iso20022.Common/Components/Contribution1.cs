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
/// Provides additional information such as the contribution account identification or the requirement amount.
/// </summary>
[IsoId("_UqzgRdp-Ed-ak6NoX_4Aeg_-225785581")]
[DisplayName("Contribution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Contribution1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Contribution1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Contribution1( ActiveCurrencyAndAmount reqRequiredAmount )
    {
        RequiredAmount = reqRequiredAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Segregation done by the central counterparty based on trading venues/products or other attributes.
    /// </summary>
    [IsoId("_UqzgRtp-Ed-ak6NoX_4Aeg_-1145836666")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? Account { get; init; } 
    #else
    public AccountIdentification4Choice_? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Total contribution required by the clearing member to participate to the default fund.
    /// </summary>
    [IsoId("_UqzgR9p-Ed-ak6NoX_4Aeg_-1662301035")]
    [DisplayName("Required Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdAmt")]
    #endif
    [IsoXmlTag("ReqrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount RequiredAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount RequiredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount RequiredAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount RequiredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amount that the clearing member will have to provide to cover a risk increase. This results from a risk management decision depending on central counterparty specific criteria.
    /// </summary>
    [IsoId("_UqzgSNp-Ed-ak6NoX_4Aeg_432559077")]
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
    
    /// <summary>
    /// Provides the identification for the non-clearing member.
    /// </summary>
    [IsoId("_UqzgSdp-Ed-ak6NoX_4Aeg_-1098356779")]
    [DisplayName("Non Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonClrMmb")]
    #endif
    [IsoXmlTag("NonClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #else
    public PartyIdentificationAndAccount31? NonClearingMember { get; set; } 
    #endif
    
    
    #nullable disable
    
}
