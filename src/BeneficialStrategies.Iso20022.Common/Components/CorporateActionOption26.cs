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
[IsoId("_qVQk6-aPEd-q8fx_Zl_34A")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption26
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_qVQk7eaPEd-q8fx_Zl_34A")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_qVQk7-aPEd-q8fx_Zl_34A")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption5Choice_ OptionType { get; init; }

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_qVQk8eaPEd-q8fx_Zl_34A")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification36Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_qVQk8-aPEd-q8fx_Zl_34A")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    [IsoId("_qVQk9eaPEd-q8fx_Zl_34A")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_qVQk9-aPEd-q8fx_Zl_34A")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_qVQk-eaPEd-q8fx_Zl_34A")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification14? SecurityIdentification { get; init; }

    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_qVQk--aPEd-q8fx_Zl_34A")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat1? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_qVQk_eaPEd-q8fx_Zl_34A")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public SignedQuantityFormat1? InstructedBalance { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_qVQk_-aPEd-q8fx_Zl_34A")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public SignedQuantityFormat1? UninstructedBalance { get; init; }

    /// <summary>
    /// Specifies whether the quantity of financial instrument is a status quantity or a quantity to receive.
    /// </summary>
    [IsoId("_qVQlAeaPEd-q8fx_Zl_34A")]
    [DisplayName("Status Quantity Or Quantity To Receive")]
    [IsoXmlTag("StsQtyOrQtyToRcv")]
    public StatusOrQuantityToReceive1Choice_? StatusQuantityOrQuantityToReceive { get; init; }
}
