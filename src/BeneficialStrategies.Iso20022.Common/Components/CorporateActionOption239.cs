// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Option239.
/// </summary>
[IsoId("_5I4L64-9Ee-COKgew96POA")]
[DisplayName("Corporate Action Option239")]
public record CorporateActionOption239
{
    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Block Chain Address Or Wallet.
    /// </summary>
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification9Choice_? CashAccount { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Instructed Balance.
    /// </summary>
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public SignedQuantityFormat11? InstructedBalance { get; init; }

    /// <summary>
    /// Option Features.
    /// </summary>
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; }

    /// <summary>
    /// Option Number.
    /// </summary>
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption41Choice_ OptionType { get; init; }

    /// <summary>
    /// Protect Balance.
    /// </summary>
    [DisplayName("Protect Balance")]
    [IsoXmlTag("PrtctBal")]
    public SignedQuantityFormat11? ProtectBalance { get; init; }

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat42Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Status Cash Amount.
    /// </summary>
    [DisplayName("Status Cash Amount")]
    [IsoXmlTag("StsCshAmt")]
    public ActiveCurrencyAndAmount? StatusCashAmount { get; init; }

    /// <summary>
    /// Status Quantity.
    /// </summary>
    [DisplayName("Status Quantity")]
    [IsoXmlTag("StsQty")]
    public Quantity51Choice_? StatusQuantity { get; init; }

    /// <summary>
    /// Total Eligible Balance.
    /// </summary>
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat11? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Uninstructed Balance.
    /// </summary>
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public SignedQuantityFormat11? UninstructedBalance { get; init; }
}
