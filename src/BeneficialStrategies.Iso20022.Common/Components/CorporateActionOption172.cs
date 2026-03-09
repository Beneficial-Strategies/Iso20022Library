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
[IsoId("_bfb6DQVSEeqjd8n6wD9JVw")]
[DisplayName("Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOption172
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOption172 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOption172( OptionNumber1Choice_ reqOptionNumber,CorporateActionOption35Choice_ reqOptionType,SecuritiesQuantityOrAmount5Choice_ reqSecuritiesQuantityOrInstructedAmount )
    {
        OptionNumber = reqOptionNumber;
        OptionType = reqOptionType;
        SecuritiesQuantityOrInstructedAmount = reqSecuritiesQuantityOrInstructedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_bfb6FQVSEeqjd8n6wD9JVw")]
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
    [IsoId("_bfb6HQVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption35Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption35Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption35Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption35Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_bfb6JQVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Features")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnFeatrs")]
    #endif
    [IsoXmlTag("OptnFeatrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionFeaturesFormat27Choice_? OptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionFeaturesFormat27Choice_? OptionFeatures { get; init; } 
    #else
    public OptionFeaturesFormat27Choice_? OptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    [IsoId("_bfb6JwVSEeqjd8n6wD9JVw")]
    [DisplayName("Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnDspstn")]
    #endif
    [IsoXmlTag("FrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType29Choice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType29Choice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType29Choice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    [IsoId("_bfb6LwVSEeqjd8n6wD9JVw")]
    [DisplayName("Change Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngTp")]
    #endif
    [IsoXmlTag("ChngTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionChangeTypeFormat7Choice_? ChangeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionChangeTypeFormat7Choice_? ChangeType { get; init; } 
    #else
    public CorporateActionChangeTypeFormat7Choice_? ChangeType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    [IsoId("_bfb6NwVSEeqjd8n6wD9JVw")]
    [DisplayName("Eligible For Collateral Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblForCollInd")]
    #endif
    [IsoXmlTag("ElgblForCollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EligibleForCollateralIndicator { get; init; } 
    #else
    public System.String? EligibleForCollateralIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    [IsoId("_bfb6PwVSEeqjd8n6wD9JVw")]
    [DisplayName("Currency To Buy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyToBuy")]
    #endif
    [IsoXmlTag("CcyToBuy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyToBuy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyToBuy { get; init; } 
    #else
    public string? CurrencyToBuy { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    [IsoId("_bfb6RwVSEeqjd8n6wD9JVw")]
    [DisplayName("Currency To Sell")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyToSell")]
    #endif
    [IsoXmlTag("CcyToSell")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyToSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyToSell { get; init; } 
    #else
    public string? CurrencyToSell { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_bfb6TwVSEeqjd8n6wD9JVw")]
    [DisplayName("Currency Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyOptn")]
    #endif
    [IsoXmlTag("CcyOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyOption { get; init; } 
    #else
    public string? CurrencyOption { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_bfb6VwVSEeqjd8n6wD9JVw")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification20? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification20? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_bfb6XwVSEeqjd8n6wD9JVw")]
    [DisplayName("Securities Quantity Or Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyOrInstdAmt")]
    #endif
    [IsoXmlTag("SctiesQtyOrInstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesQuantityOrAmount5Choice_ SecuritiesQuantityOrInstructedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesQuantityOrAmount5Choice_ SecuritiesQuantityOrInstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesQuantityOrAmount5Choice_ SecuritiesQuantityOrInstructedAmount { get; init; } 
    #else
    public SecuritiesQuantityOrAmount5Choice_ SecuritiesQuantityOrInstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_bfb6ZwVSEeqjd8n6wD9JVw")]
    [DisplayName("Execution Requested Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnReqdDtTm")]
    #endif
    [IsoXmlTag("ExctnReqdDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ExecutionRequestedDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ExecutionRequestedDateTime { get; init; } 
    #else
    public DateAndDateTime2Choice_? ExecutionRequestedDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_bfb6bwVSEeqjd8n6wD9JVw")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate73? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate73? RateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRate73? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_bfb6dwVSEeqjd8n6wD9JVw")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice62? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice62? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice62? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    [IsoId("_bfb6fwVSEeqjd8n6wD9JVw")]
    [DisplayName("Shareholder Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrhldrNb")]
    #endif
    [IsoXmlTag("ShrhldrNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax25Text? ShareholderNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShareholderNumber { get; init; } 
    #else
    public System.String? ShareholderNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_bfb6gQVSEeqjd8n6wD9JVw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative33? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative33? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative33? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
