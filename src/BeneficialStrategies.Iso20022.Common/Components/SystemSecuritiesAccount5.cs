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
[IsoId("_8IwThzp0Eemk2e6qGBk8IQ")]
[DisplayName("System Securities Account")]
public partial record SystemSecuritiesAccount5
{
    #nullable enable
    
    /// <summary>
    /// Legal closing date of the securities account.
    /// </summary>
    [IsoId("_8VuYgTp0Eemk2e6qGBk8IQ")]
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
    [IsoId("_8VuYgzp0Eemk2e6qGBk8IQ")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the securities account can hold a negative position in a security or not.
    /// </summary>
    [IsoId("_8VuYhTp0Eemk2e6qGBk8IQ")]
    [DisplayName("Negative Position")]
    [IsoXmlTag("NegPos")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NegativePosition { get; init; } 
    
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_8VuYhzp0Eemk2e6qGBk8IQ")]
    [DisplayName("End Investor Flag")]
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
    
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_8VuYiTp0Eemk2e6qGBk8IQ")]
    [DisplayName("Pricing Scheme")]
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
    
    
    #nullable disable
    
}
