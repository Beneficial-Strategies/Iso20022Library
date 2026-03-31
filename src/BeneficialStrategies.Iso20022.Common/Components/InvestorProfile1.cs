// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about actions that may be taken on an account.
/// </summary>
[IsoId("_WK6_oCDNEeWPMvNwVtiMsA")]
[DisplayName("Investor Profile")]
public record InvestorProfile1
{
    /// <summary>
    /// Type of profile.
    /// </summary>
    [IsoId("_rSMUUCDNEeWPMvNwVtiMsA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ProfileType1Choice_? Type { get; init; }

    /// <summary>
    /// Status of the profile.
    /// </summary>
    [IsoId("_k6XaICDOEeWPMvNwVtiMsA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public InvestorProfileStatus1Choice_? Status { get; init; }

    /// <summary>
    /// Information about the profile for treasury trading.
    /// </summary>
    [IsoId("__bXFMCDREeWCLu74WLgP4w")]
    [DisplayName("Treasury")]
    [IsoXmlTag("Trsr")]
    public TreasuryProfile1? Treasury { get; init; }

    /// <summary>
    /// Information about the profile for high frequency trading.
    /// </summary>
    [IsoId("_GDj2UCDUEeWCLu74WLgP4w")]
    [DisplayName("High Frequency Trading")]
    [IsoXmlTag("HghFrqcyTradg")]
    public HighFrequencyTradingProfile1? HighFrequencyTrading { get; init; }

    /// <summary>
    /// Information about the profile for a market marker.
    /// </summary>
    [IsoId("_9tFosCDVEeWCLu74WLgP4w")]
    [DisplayName("Market Maker")]
    [IsoXmlTag("MktMakr")]
    public MarketMakerProfile1? MarketMaker { get; init; }
}
