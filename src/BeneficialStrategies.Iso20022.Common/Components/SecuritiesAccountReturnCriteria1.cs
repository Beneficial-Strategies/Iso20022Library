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
/// Return criteria for information to be returned in the report deriving from a query about securities account reference data.
/// </summary>
[IsoId("_X5rHEeX3EeWawO9uAAThyQ")]
[DisplayName("Securities Account Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the identification of the account is requested.
    /// </summary>
    [IsoId("_YDWAceX3EeWawO9uAAThyQ")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the identification of the party owning the account is requested.
    /// </summary>
    [IsoId("_YDWAc-X3EeWawO9uAAThyQ")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartyIdentification { get; init; } 
    #else
    public System.String? PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the type of the party owning the account is requested.
    /// </summary>
    [IsoId("_YDWAdeX3EeWawO9uAAThyQ")]
    [DisplayName("Party Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyTp")]
    #endif
    [IsoXmlTag("PtyTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PartyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartyType { get; init; } 
    #else
    public System.String? PartyType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account servicer is requested.
    /// </summary>
    [IsoId("_YDWAd-X3EeWawO9uAAThyQ")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicer { get; init; } 
    #else
    public System.String? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_YDWAeeX3EeWawO9uAAThyQ")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountType { get; init; } 
    #else
    public System.String? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the opening date for the account is requested.
    /// </summary>
    [IsoId("_YDWAe-X3EeWawO9uAAThyQ")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OpeningDate { get; init; } 
    #else
    public System.String? OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the closing date for the account is requested.
    /// </summary>
    [IsoId("_YDWAfeX3EeWawO9uAAThyQ")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosingDate { get; init; } 
    #else
    public System.String? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_YDWAf-X3EeWawO9uAAThyQ")]
    [DisplayName("End Investor Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndInvstrFlg")]
    #endif
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EndInvestorFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EndInvestorFlag { get; init; } 
    #else
    public System.String? EndInvestorFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_YDWAgeX3EeWawO9uAAThyQ")]
    [DisplayName("Pricing Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricgSchme")]
    #endif
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PricingScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PricingScheme { get; init; } 
    #else
    public System.String? PricingScheme { get; set; } 
    #endif
    
    
    #nullable disable
    
}
