// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the account within a system to or from which a securities entry is made. It holds information generic or market specific attributes such as opening or closing date, and defines the default setting for the  holding of settlement instructions involving positions related to the account.
/// </summary>
[IsoId("_4JS-gZ5EEemQg7pJhFUUYg")]
[DisplayName("System Securities Account")]
public record SystemSecuritiesAccount7
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_4SjBIZ5EEemQg7pJhFUUYg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required SystemPartyIdentification8 AccountOwner { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_4SjBI55EEemQg7pJhFUUYg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of the securities account.
    /// </summary>
    [IsoId("_4SjBJZ5EEemQg7pJhFUUYg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SystemSecuritiesAccountType1Choice_ Type { get; init; }

    /// <summary>
    /// Legal opening date of the securities account.
    /// </summary>
    [IsoId("_4SjBJ55EEemQg7pJhFUUYg")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate OpeningDate { get; init; }

    /// <summary>
    /// Legal closing date of the securities account.
    /// </summary>
    [IsoId("_4SjBKZ5EEemQg7pJhFUUYg")]
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
    [IsoId("_4SjBK55EEemQg7pJhFUUYg")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator HoldIndicator { get; init; }

    /// <summary>
    /// Indicates whether the securities account can hold a negative position in a security or not.
    /// </summary>
    [IsoId("_4SjBLZ5EEemQg7pJhFUUYg")]
    [DisplayName("Negative Position")]
    [IsoXmlTag("NegPos")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator NegativePosition { get; init; }

    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_4SjBL55EEemQg7pJhFUUYg")]
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; }

    /// <summary>
    /// Defines the specific processing characteristics for a securities account to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_4SjBMZ5EEemQg7pJhFUUYg")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public SystemRestriction1? Restriction { get; init; }

    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_4SjBM55EEemQg7pJhFUUYg")]
    [DisplayName("End Investor Flag")]
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; }

    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_4SjBNZ5EEemQg7pJhFUUYg")]
    [DisplayName("Pricing Scheme")]
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? PricingScheme { get; init; }
}
