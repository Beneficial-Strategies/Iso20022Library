// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_6XuB8ezcEd-Z2q4-Bbm3ZA")]
[DisplayName("Corporate Action Option")]
public partial record CorporateActionOption22
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_6XuB8-zcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_6XuB9ezcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption5Choice_ OptionType { get; init; } 
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_6XuB9-zcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification41Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_6XuB-ezcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    [IsoId("_6XuB--zcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_6XuB_ezcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_6XuB_-zcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification14? SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_6XuCAezcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat1? TotalEligibleBalance { get; init; } 
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_6XuCA-zcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public SignedQuantityFormat1? InstructedBalance { get; init; } 
    
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_6XuCBezcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public SignedQuantityFormat1? UninstructedBalance { get; init; } 
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument is a status quantity or a quantity to receive.
    /// </summary>
    [IsoId("_6XuCB-zcEd-Z2q4-Bbm3ZA")]
    [DisplayName("Status Quantity Or Quantity To Receive")]
    [IsoXmlTag("StsQtyOrQtyToRcv")]
    public StatusOrQuantityToReceive1Choice_? StatusQuantityOrQuantityToReceive { get; init; } 
    
    
    #nullable disable
    
}
