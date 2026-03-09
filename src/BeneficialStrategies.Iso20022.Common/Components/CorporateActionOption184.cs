// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_KvJS0e6AEeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOption184
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOption184 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOption184( OptionNumber1Choice_ reqOptionNumber,CorporateActionOption41Choice_ reqOptionType )
    {
        OptionNumber = reqOptionNumber;
        OptionType = reqOptionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_LZsru-6AEeqc-LCjwLsUVg")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #else
    public OptionNumber1Choice_ OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_LZsrw-6AEeqc-LCjwLsUVg")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption41Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption41Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption41Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption41Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_LZsry-6AEeqc-LCjwLsUVg")]
    [DisplayName("Option Features")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnFeatrs")]
    #endif
    [IsoXmlTag("OptnFeatrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; } 
    #else
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_LZsrze6AEeqc-LCjwLsUVg")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification127Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification127Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification127Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_LZsr1e6AEeqc-LCjwLsUVg")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SafekeepingAccount { get; init; } 
    #else
    public System.String? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account on which a securities entry is made.
    /// </summary>
    [IsoId("_LZsr3e6AEeqc-LCjwLsUVg")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_LZsr5e6AEeqc-LCjwLsUVg")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_LZsr7e6AEeqc-LCjwLsUVg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_LZsr9e6AEeqc-LCjwLsUVg")]
    [DisplayName("Total Eligible Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlElgblBal")]
    #endif
    [IsoXmlTag("TtlElgblBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat7? TotalEligibleBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat7? TotalEligibleBalance { get; init; } 
    #else
    public SignedQuantityFormat7? TotalEligibleBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_LZsr_e6AEeqc-LCjwLsUVg")]
    [DisplayName("Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdBal")]
    #endif
    [IsoXmlTag("InstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat7? InstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat7? InstructedBalance { get; init; } 
    #else
    public SignedQuantityFormat7? InstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_LZssBe6AEeqc-LCjwLsUVg")]
    [DisplayName("Uninstructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UinstdBal")]
    #endif
    [IsoXmlTag("UinstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat7? UninstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat7? UninstructedBalance { get; init; } 
    #else
    public SignedQuantityFormat7? UninstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    [IsoId("_LZssDe6AEeqc-LCjwLsUVg")]
    [DisplayName("Status Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsQty")]
    #endif
    [IsoXmlTag("StsQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity6Choice_? StatusQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_? StatusQuantity { get; init; } 
    #else
    public Quantity6Choice_? StatusQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash subscribed that has been assigned the status indicated.
    /// </summary>
    [IsoId("_LZssD-6AEeqc-LCjwLsUVg")]
    [DisplayName("Status Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsCshAmt")]
    #endif
    [IsoXmlTag("StsCshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? StatusCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? StatusCashAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? StatusCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    [IsoId("_SbvLEe6AEeqc-LCjwLsUVg")]
    [DisplayName("Solicitation Dealer Fee Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnDealrFeeInd")]
    #endif
    [IsoXmlTag("SlctnDealrFeeInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SolicitationDealerFeeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SolicitationDealerFeeIndicator { get; init; } 
    #else
    public System.String? SolicitationDealerFeeIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
