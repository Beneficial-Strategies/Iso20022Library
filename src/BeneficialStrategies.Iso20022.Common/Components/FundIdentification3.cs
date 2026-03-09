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
/// Distinct pool of financial instruments managed by a single investment policy. May or not be part of an umbrella fund.The pool is issued in at least one investment fund class.
/// </summary>
[IsoId("_S8Ai-AEcEeCQm6a_G2yO_w_740788919")]
[DisplayName("Fund Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundIdentification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundIdentification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundIdentification3( System.String reqFundIdentification )
    {
        FundIdentification = reqFundIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the investment fund.
    /// </summary>
    [IsoId("_S8Ai-QEcEeCQm6a_G2yO_w_626949853")]
    [DisplayName("Fund Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndId")]
    #endif
    [IsoXmlTag("FndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text FundIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FundIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FundIdentification { get; init; } 
    #else
    public System.String FundIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the account of the fund held with the custodian.
    /// </summary>
    [IsoId("_S8Ai-gEcEeCQm6a_G2yO_w_-256283434")]
    [DisplayName("Account Identification With Custodian")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctIdWthCtdn")]
    #endif
    [IsoXmlTag("AcctIdWthCtdn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentificationWithCustodian { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentificationWithCustodian { get; init; } 
    #else
    public System.String? AccountIdentificationWithCustodian { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the custodian which services the account of the fund.
    /// </summary>
    [IsoId("_S8Ai-wEcEeCQm6a_G2yO_w_-1253355787")]
    [DisplayName("Custodian Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnId")]
    #endif
    [IsoXmlTag("CtdnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification19Choice_? CustodianIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification19Choice_? CustodianIdentification { get; init; } 
    #else
    public PartyIdentification19Choice_? CustodianIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
