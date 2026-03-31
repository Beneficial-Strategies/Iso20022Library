// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_xWboVTq3EeWQ1Y7f8kds2A")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption116
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_xiegJzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_xiegLzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption21Choice_ OptionType { get; init; }

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_xiegNzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification92Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_xiegPzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    [IsoId("_xiegRzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_xiegTzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_xiegVzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_xiegXzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat7? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_xiegZzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public SignedQuantityFormat7? InstructedBalance { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_xiegbzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public SignedQuantityFormat7? UninstructedBalance { get; init; }

    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    [IsoId("_7UBMkWOREeW4z96Yfj3Wng")]
    [DisplayName("Status Quantity")]
    [IsoXmlTag("StsQty")]
    public required Quantity6Choice_ StatusQuantity { get; init; }
}
