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
[IsoId("_Prgu8Rn2EeyroI8qKgB7Mg")]
[DisplayName("Corporate Action Option")]
public partial record CorporateActionOption197
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_QBQ8ixn2EeyroI8qKgB7Mg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_QBQ8kxn2EeyroI8qKgB7Mg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption41Choice_ OptionType { get; init; } 
    
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_QBQ8mxn2EeyroI8qKgB7Mg")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; } 
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_QBQ8nRn2EeyroI8qKgB7Mg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_QBQ8pRn2EeyroI8qKgB7Mg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_mrIzoiLOEeyNSNrMl2zWxg")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    [IsoId("_QBQ8rRn2EeyroI8qKgB7Mg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_QBQ8tRn2EeyroI8qKgB7Mg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_QBQ8vRn2EeyroI8qKgB7Mg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_QBQ8xRn2EeyroI8qKgB7Mg")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat11? TotalEligibleBalance { get; init; } 
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_QBQ8zRn2EeyroI8qKgB7Mg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public SignedQuantityFormat11? InstructedBalance { get; init; } 
    
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_QBQ81Rn2EeyroI8qKgB7Mg")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public SignedQuantityFormat11? UninstructedBalance { get; init; } 
    
    /// <summary>
    /// Balance of securities which are in protect status in a CSD operating a protect cover service.
    /// </summary>
    [IsoId("_S9wi0Rn2EeyroI8qKgB7Mg")]
    [DisplayName("Protect Balance")]
    [IsoXmlTag("PrtctBal")]
    public SignedQuantityFormat11? ProtectBalance { get; init; } 
    
    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    [IsoId("_QBQ83Rn2EeyroI8qKgB7Mg")]
    [DisplayName("Status Quantity")]
    [IsoXmlTag("StsQty")]
    public Quantity51Choice_? StatusQuantity { get; init; } 
    
    /// <summary>
    /// Amount of cash subscribed that has been assigned the status indicated.
    /// </summary>
    [IsoId("_QBQ83xn2EeyroI8qKgB7Mg")]
    [DisplayName("Status Cash Amount")]
    [IsoXmlTag("StsCshAmt")]
    public ActiveCurrencyAndAmount? StatusCashAmount { get; init; } 
    
    
    #nullable disable
    
}
