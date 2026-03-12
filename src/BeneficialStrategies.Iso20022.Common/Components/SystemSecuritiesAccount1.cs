// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// It holds information such as opening and closing date and whether it can hold negative positions.
/// Definition of the entity includes the default setting for holding of settlement instructions involving positions related to the account.
/// Set of MarketSpecificAttributes define specific properties for the account.
/// </summary>
[IsoId("_hiu7g2liEeGaMcKyqKNRfQ_700366773")]
[DisplayName("System Securities Account")]
public partial record SystemSecuritiesAccount1
{
    #nullable enable
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// It holds information such as opening and closing date and whether it can hold negative positions.
    /// Definition of the entity includes the default setting for holding of settlement instructions involving positions related to the account.
    /// Set of MarketSpecificAttributes define specific properties for the account.
    /// </summary>
    [IsoId("_hi4scGliEeGaMcKyqKNRfQ_-1527501459")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required SystemPartyIdentification3 AccountOwner { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_hi4scWliEeGaMcKyqKNRfQ_2143157388")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Specifies the type of the securities account.
    /// </summary>
    [IsoId("_hi4scmliEeGaMcKyqKNRfQ_42849458")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SystemSecuritiesAccountType1Code Type { get; init; } 
    
    /// <summary>
    /// Legal opening date for the securities account.
    /// </summary>
    [IsoId("_hi4sc2liEeGaMcKyqKNRfQ_-1002912201")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate OpeningDate { get; init; } 
    
    /// <summary>
    /// Legal closing date for the securities account.
    /// </summary>
    [IsoId("_hi4sdGliEeGaMcKyqKNRfQ_846684152")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; } 
    
    /// <summary>
    /// Meaning when true: Account is in Hold status.
    /// Meaning when false: Account is in Release status.
    /// </summary>
    [IsoId("_hi4sdWliEeGaMcKyqKNRfQ_-75021527")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator HoldIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the securities account can hold a negative position in a security.
    /// </summary>
    [IsoId("_hi4sdmliEeGaMcKyqKNRfQ_-1072093880")]
    [DisplayName("Negative Position")]
    [IsoXmlTag("NegPos")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator NegativePosition { get; init; } 
    
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_hi4sd2liEeGaMcKyqKNRfQ_1928173830")]
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    
    /// <summary>
    /// Defines the specific processing characteristics for a securities account to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_hi4seGliEeGaMcKyqKNRfQ_-1326040563")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public SystemRestriction1? Restriction { get; init; } 
    
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_hi4seWliEeGaMcKyqKNRfQ_-1124519541")]
    [DisplayName("End Investor Flag")]
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText EndInvestorFlag { get; init; } 
    
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_hi4semliEeGaMcKyqKNRfQ_198011686")]
    [DisplayName("Pricing Scheme")]
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText PricingScheme { get; init; } 
    
    
    #nullable disable
    
}
