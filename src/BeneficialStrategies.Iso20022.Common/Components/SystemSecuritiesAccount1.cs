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
/// Account to or from which a securities entry is made.
/// It holds information such as opening and closing date and whether it can hold negative positions.
/// Definition of the entity includes the default setting for holding of settlement instructions involving positions related to the account.
/// Set of MarketSpecificAttributes define specific properties for the account.
/// </summary>
[IsoId("_hiu7g2liEeGaMcKyqKNRfQ_700366773")]
[DisplayName("System Securities Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemSecuritiesAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemSecuritiesAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemSecuritiesAccount1( SystemPartyIdentification3 reqAccountOwner,System.String reqIdentification,SystemSecuritiesAccountType1Code reqType,System.DateOnly reqOpeningDate,System.String reqHoldIndicator,System.String reqNegativePosition,System.String reqEndInvestorFlag,System.String reqPricingScheme )
    {
        AccountOwner = reqAccountOwner;
        Identification = reqIdentification;
        Type = reqType;
        OpeningDate = reqOpeningDate;
        HoldIndicator = reqHoldIndicator;
        NegativePosition = reqNegativePosition;
        EndInvestorFlag = reqEndInvestorFlag;
        PricingScheme = reqPricingScheme;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// It holds information such as opening and closing date and whether it can hold negative positions.
    /// Definition of the entity includes the default setting for holding of settlement instructions involving positions related to the account.
    /// Set of MarketSpecificAttributes define specific properties for the account.
    /// </summary>
    [IsoId("_hi4scGliEeGaMcKyqKNRfQ_-1527501459")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification3 AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification3 AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification3 AccountOwner { get; init; } 
    #else
    public SystemPartyIdentification3 AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_hi4scWliEeGaMcKyqKNRfQ_2143157388")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the securities account.
    /// </summary>
    [IsoId("_hi4scmliEeGaMcKyqKNRfQ_42849458")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemSecuritiesAccountType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemSecuritiesAccountType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemSecuritiesAccountType1Code Type { get; init; } 
    #else
    public SystemSecuritiesAccountType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Legal opening date for the securities account.
    /// </summary>
    [IsoId("_hi4sc2liEeGaMcKyqKNRfQ_-1002912201")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate OpeningDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly OpeningDate { get; init; } 
    #else
    public System.DateOnly OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Legal closing date for the securities account.
    /// </summary>
    [IsoId("_hi4sdGliEeGaMcKyqKNRfQ_846684152")]
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
    /// Meaning when true: Account is in Hold status.
    /// Meaning when false: Account is in Release status.
    /// </summary>
    [IsoId("_hi4sdWliEeGaMcKyqKNRfQ_-75021527")]
    [DisplayName("Hold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldInd")]
    #endif
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator HoldIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String HoldIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HoldIndicator { get; init; } 
    #else
    public System.String HoldIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the securities account can hold a negative position in a security.
    /// </summary>
    [IsoId("_hi4sdmliEeGaMcKyqKNRfQ_-1072093880")]
    [DisplayName("Negative Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NegPos")]
    #endif
    [IsoXmlTag("NegPos")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator NegativePosition { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NegativePosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NegativePosition { get; init; } 
    #else
    public System.String NegativePosition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_hi4sd2liEeGaMcKyqKNRfQ_1928173830")]
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
    [IsoId("_hi4seGliEeGaMcKyqKNRfQ_-1326040563")]
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
    [IsoId("_hi4seWliEeGaMcKyqKNRfQ_-1124519541")]
    [DisplayName("End Investor Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndInvstrFlg")]
    #endif
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact4AlphaNumericText EndInvestorFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EndInvestorFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EndInvestorFlag { get; init; } 
    #else
    public System.String EndInvestorFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_hi4semliEeGaMcKyqKNRfQ_198011686")]
    [DisplayName("Pricing Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricgSchme")]
    #endif
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact4AlphaNumericText PricingScheme { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PricingScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PricingScheme { get; init; } 
    #else
    public System.String PricingScheme { get; set; } 
    #endif
    
    
    #nullable disable
    
}
