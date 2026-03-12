// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the account within a system to or from which a securities entry is made. It holds information generic or market specific attributes such as opening or closing date, and defines the default setting for the  holding of settlement instructions involving positions related to the account.
/// </summary>
[IsoId("_yNtKNTp1Eemk2e6qGBk8IQ")]
[DisplayName("System Securities Account")]
public partial record SystemSecuritiesAccount6
{
    #nullable enable
    
    /// <summary>
    /// Legal opening date of the securities account.
    /// </summary>
    [IsoId("_yX_HkTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OpeningDate { get; init; } 
    
    /// <summary>
    /// Legal closing date of the securities account.
    /// </summary>
    [IsoId("_yX_Hkzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the securities account is on hold or not.
    /// Usage:
    /// - Meaning when true: account is in hold status.
    /// - Meaning when false: account is in release status.
    /// </summary>
    [IsoId("_yX_HlTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the securities account can hold a negative position in a security or not.
    /// </summary>
    [IsoId("_yX_Hlzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Negative Position")]
    [IsoXmlTag("NegPos")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NegativePosition { get; init; } 
    
    /// <summary>
    /// Specifies the type of the securities account.
    /// </summary>
    [IsoId("_yX_HmTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SystemSecuritiesAccountType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_yX_Hmzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required SystemPartyIdentification8 AccountOwner { get; init; } 
    
    /// <summary>
    /// Specifies the type of party owning the account.
    /// </summary>
    [IsoId("_yX_HnTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Party Type")]
    [IsoXmlTag("PtyTp")]
    public SystemPartyType1Choice_? PartyType { get; init; } 
    
    /// <summary>
    /// Additional attributes defined by a central security depositary for a securities account.
    /// </summary>
    [IsoId("_yX_Hnzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    
    /// <summary>
    /// Defines the specific processing characteristics for a securities account to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_yX_HoTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public SystemRestriction1? Restriction { get; init; } 
    
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_yX_Hozp1Eemk2e6qGBk8IQ")]
    [DisplayName("End Investor Flag")]
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
    
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_yX_HpTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Pricing Scheme")]
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
    
    
    #nullable disable
    
}
