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
/// Specifies the account within a system to or from which a securities entry is made. It holds information generic or market specific attributes such as opening or closing date, and defines the default setting for the  holding of settlement instructions involving positions related to the account.
/// </summary>
[IsoId("_yNtKNTp1Eemk2e6qGBk8IQ")]
[DisplayName("System Securities Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemSecuritiesAccount6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemSecuritiesAccount6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemSecuritiesAccount6( SystemPartyIdentification8 reqAccountOwner )
    {
        AccountOwner = reqAccountOwner;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Legal opening date of the securities account.
    /// </summary>
    [IsoId("_yX_HkTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OpeningDate { get; init; } 
    #else
    public System.DateOnly? OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Legal closing date of the securities account.
    /// </summary>
    [IsoId("_yX_Hkzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ClosingDate { get; init; } 
    #else
    public System.DateOnly? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities account is on hold or not.
    /// Usage:
    /// - Meaning when true: account is in hold status.
    /// - Meaning when false: account is in release status.
    /// </summary>
    [IsoId("_yX_HlTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Hold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldInd")]
    #endif
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HoldIndicator { get; init; } 
    #else
    public System.String? HoldIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities account can hold a negative position in a security or not.
    /// </summary>
    [IsoId("_yX_Hlzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Negative Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NegPos")]
    #endif
    [IsoXmlTag("NegPos")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NegativePosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NegativePosition { get; init; } 
    #else
    public System.String? NegativePosition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the securities account.
    /// </summary>
    [IsoId("_yX_HmTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemSecuritiesAccountType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemSecuritiesAccountType1Choice_? Type { get; init; } 
    #else
    public SystemSecuritiesAccountType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_yX_Hmzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification8 AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification8 AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8 AccountOwner { get; init; } 
    #else
    public SystemPartyIdentification8 AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of party owning the account.
    /// </summary>
    [IsoId("_yX_HnTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Party Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyTp")]
    #endif
    [IsoXmlTag("PtyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyType1Choice_? PartyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyType1Choice_? PartyType { get; init; } 
    #else
    public SystemPartyType1Choice_? PartyType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional attributes defined by a central security depositary for a securities account.
    /// </summary>
    [IsoId("_yX_Hnzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Market Specific Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktSpcfcAttr")]
    #endif
    [IsoXmlTag("MktSpcfcAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    #else
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the specific processing characteristics for a securities account to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_yX_HoTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Restriction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctn")]
    #endif
    [IsoXmlTag("Rstrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemRestriction1? Restriction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemRestriction1? Restriction { get; init; } 
    #else
    public SystemRestriction1? Restriction { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_yX_Hozp1Eemk2e6qGBk8IQ")]
    [DisplayName("End Investor Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndInvstrFlg")]
    #endif
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EndInvestorFlag { get; init; } 
    #else
    public System.String? EndInvestorFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_yX_HpTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Pricing Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricgSchme")]
    #endif
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PricingScheme { get; init; } 
    #else
    public System.String? PricingScheme { get; set; } 
    #endif
    
    
    #nullable disable
    
}
