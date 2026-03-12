// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.|It holds information such as opening and closing date and whether it can hold negative positions.|Definition of the entity includes the default setting for holding of settlement instructions involving positions related to the account.|Set of MarketSpecificAttributes define specific properties for the account.
/// </summary>
[IsoId("_hi4shWliEeGaMcKyqKNRfQ_-504173190")]
[DisplayName("System Securities Account")]
public partial record SystemSecuritiesAccount2
{
    #nullable enable
    
    /// <summary>
    /// Legal closing date for the securities account.
    /// </summary>
    [IsoId("_hi4shmliEeGaMcKyqKNRfQ_-1276235554")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; } 
    
    /// <summary>
    /// Meaning when true: Account is in Hold status.
    /// Meaning when false: Account is in Release status.
    /// </summary>
    [IsoId("_hi4sh2liEeGaMcKyqKNRfQ_-553977920")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the securities account can hold a negative position in a security.
    /// </summary>
    [IsoId("_hjB2YGliEeGaMcKyqKNRfQ_-1625982979")]
    [DisplayName("Negative Position")]
    [IsoXmlTag("NegPos")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NegativePosition { get; init; } 
    
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_hjB2YWliEeGaMcKyqKNRfQ_1482724284")]
    [DisplayName("End Investor Flag")]
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
    
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_hjB2YmliEeGaMcKyqKNRfQ_-694614118")]
    [DisplayName("Pricing Scheme")]
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
    
    
    #nullable disable
    
}
