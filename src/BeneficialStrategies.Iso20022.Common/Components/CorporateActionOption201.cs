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
[IsoId("_peXmszi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption201
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_peXmxTi7Eeydid5dcNPKvg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_peXmzTi7Eeydid5dcNPKvg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption42Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_peXm1Ti7Eeydid5dcNPKvg")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat27Choice_? OptionFeatures { get; init; }

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_peXm1zi7Eeydid5dcNPKvg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_peXm3zi7Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_peXm5zi7Eeydid5dcNPKvg")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    [IsoId("_peXm6Ti7Eeydid5dcNPKvg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification6Choice_? CashAccount { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_peXm8Ti7Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_peXm-Ti7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_peXnATi7Eeydid5dcNPKvg")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat12? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_peXnCTi7Eeydid5dcNPKvg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public SignedQuantityFormat12? InstructedBalance { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_peXnETi7Eeydid5dcNPKvg")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public SignedQuantityFormat12? UninstructedBalance { get; init; }

    /// <summary>
    /// Balance of securities which are in protect status in a CSD operating a protect cover service.
    /// </summary>
    [IsoId("_peXnGTi7Eeydid5dcNPKvg")]
    [DisplayName("Protect Balance")]
    [IsoXmlTag("PrtctBal")]
    public SignedQuantityFormat12? ProtectBalance { get; init; }

    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    [IsoId("_peXnGzi7Eeydid5dcNPKvg")]
    [DisplayName("Status Quantity")]
    [IsoXmlTag("StsQty")]
    public Quantity54Choice_? StatusQuantity { get; init; }

    /// <summary>
    /// Amount of cash subscribed that has been assigned the status indicated.
    /// </summary>
    [IsoId("_peXnHTi7Eeydid5dcNPKvg")]
    [DisplayName("Status Cash Amount")]
    [IsoXmlTag("StsCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? StatusCashAmount { get; init; }
}
