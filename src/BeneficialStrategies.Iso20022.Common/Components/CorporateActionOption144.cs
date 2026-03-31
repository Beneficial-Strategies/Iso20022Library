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
[IsoId("_DSGg283iEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption144
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_DSGg583iEee5nJBZsW8MFQ")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_DSGg783iEee5nJBZsW8MFQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption22Choice_ OptionType { get; init; }

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_DSGg983iEee5nJBZsW8MFQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification103Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_DSGg_83iEee5nJBZsW8MFQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    [IsoId("_DSGhB83iEee5nJBZsW8MFQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification6Choice_? CashAccount { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_DSGhD83iEee5nJBZsW8MFQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat11Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_DSGhF83iEee5nJBZsW8MFQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_DSGhH83iEee5nJBZsW8MFQ")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat8? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_DSGhJ83iEee5nJBZsW8MFQ")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public SignedQuantityFormat8? InstructedBalance { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_DSGhL83iEee5nJBZsW8MFQ")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public SignedQuantityFormat8? UninstructedBalance { get; init; }

    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    [IsoId("_DSGhN83iEee5nJBZsW8MFQ")]
    [DisplayName("Status Quantity")]
    [IsoXmlTag("StsQty")]
    public Quantity10Choice_? StatusQuantity { get; init; }

    /// <summary>
    /// Amount of cash subscribed that has been assigned the status indicated.
    /// </summary>
    [IsoId("_DSGhOc3iEee5nJBZsW8MFQ")]
    [DisplayName("Status Cash Amount")]
    [IsoXmlTag("StsCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? StatusCashAmount { get; init; }
}
