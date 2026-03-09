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
/// Cash management feature limiting the maximum risk a party accepts to take with respect to a counterparty or a set of counterparties. A risk management limit is either bilateral, ie, for a counterparty, or multilateral, ie, for a set of counterparties or all other members in a system.The limit may also apply to sponsored members, ie, indirect members. In principle, a risk management limit is calculated on the net position between two members and is expressed as a credit or debit limit, from the point of view of the party setting the limit.
/// </summary>
[IsoId("_jOt60O5NEeCisYr99QEiWA_-281816560")]
[DisplayName("Limit Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitIdentification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LimitIdentification4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LimitIdentification4( AccountIdentification4Choice_ reqAccountIdentification,LimitType4Code reqType,System.String reqAccountOwner )
    {
        AccountIdentification = reqAccountIdentification;
        Type = reqType;
        AccountOwner = reqAccountOwner;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification as assigned by the account servicer to unambiguously identify the account.
    /// </summary>
    [IsoId("_jOt60e5NEeCisYr99QEiWA_932788374")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification4Choice_ AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification4Choice_ AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_ AccountIdentification { get; init; } 
    #else
    public AccountIdentification4Choice_ AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Nature of the risk management limit.
    /// </summary>
    [IsoId("_jOt60u5NEeCisYr99QEiWA_-1514351595")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LimitType4Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LimitType4Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitType4Code Type { get; init; } 
    #else
    public LimitType4Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    [IsoId("_jOt60-5NEeCisYr99QEiWA_2125379305")]
    [DisplayName("Limit Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtCcy")]
    #endif
    [IsoXmlTag("LmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? LimitCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LimitCurrency { get; init; } 
    #else
    public string? LimitCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_jOt61O5NEeCisYr99QEiWA_-1060264326")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBICFIIdentifier AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountOwner { get; init; } 
    #else
    public System.String AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [IsoId("_jO3r0O5NEeCisYr99QEiWA_-1722859271")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilLmtCtrPtyId")]
    #endif
    [IsoXmlTag("BilLmtCtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification4? BilateralLimitCounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification4? BilateralLimitCounterpartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification4? BilateralLimitCounterpartyIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
