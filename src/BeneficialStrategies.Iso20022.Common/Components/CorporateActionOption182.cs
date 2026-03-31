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
[IsoId("_hzoOce35Eeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption182
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_ifEYK-35Eeqc-LCjwLsUVg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_ifEYM-35Eeqc-LCjwLsUVg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption41Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_ifEYO-35Eeqc-LCjwLsUVg")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; }

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_ifEYPe35Eeqc-LCjwLsUVg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_ifEYRe35Eeqc-LCjwLsUVg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    [IsoId("_ifEYTe35Eeqc-LCjwLsUVg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_ifEYVe35Eeqc-LCjwLsUVg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_ifEYXe35Eeqc-LCjwLsUVg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_ifEYZe35Eeqc-LCjwLsUVg")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat7? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_ifEYbe35Eeqc-LCjwLsUVg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public SignedQuantityFormat7? InstructedBalance { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_ifEYde35Eeqc-LCjwLsUVg")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public SignedQuantityFormat7? UninstructedBalance { get; init; }

    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    [IsoId("_ifEYfe35Eeqc-LCjwLsUVg")]
    [DisplayName("Status Quantity")]
    [IsoXmlTag("StsQty")]
    public Quantity6Choice_? StatusQuantity { get; init; }

    /// <summary>
    /// Amount of cash subscribed that has been assigned the status indicated.
    /// </summary>
    [IsoId("_ifEYf-35Eeqc-LCjwLsUVg")]
    [DisplayName("Status Cash Amount")]
    [IsoXmlTag("StsCshAmt")]
    public ActiveCurrencyAndAmount? StatusCashAmount { get; init; }
}
