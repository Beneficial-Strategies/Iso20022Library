// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular triparty collateral instruction/transaction  can be confirmed. These parameters are defined by the instructing party in compliance with triparty collateral rules in the market the instruction/transaction will take place.
/// </summary>
[IsoId("_KuBgcSs9EeySlt9bF77XfA")]
[DisplayName("Collateral Parameters")]
public partial record CollateralParameters10
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [IsoId("_LIZvVys9EeySlt9bF77XfA")]
    [DisplayName("Collateral Instruction Type")]
    [IsoXmlTag("CollInstrTp")]
    public required CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_LIZvWSs9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public required ExposureType23Choice_ ExposureType { get; init; } 
    
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_LIZvWys9EeySlt9bF77XfA")]
    [DisplayName("Collateral Side")]
    [IsoXmlTag("CollSd")]
    public required CollateralRole1Code CollateralSide { get; init; } 
    
    /// <summary>
    /// Percentage by which the collateral value sought is increased, in selecting securities for a collateral basket, to reflect the taker&apos;s margin requirements.
    /// Margin or haircut to be applied on the exposure amount, expressed  as a percentage.
    /// </summary>
    [IsoId("_LIZvXSs9EeySlt9bF77XfA")]
    [DisplayName("Value Sought Margin Rate")]
    [IsoXmlTag("ValSghtMrgnRate")]
    public RateOrType1Choice_? ValueSoughtMarginRate { get; init; } 
    
    /// <summary>
    /// Change of title for the collateral. If N then collateral is pledged.
    /// </summary>
    [IsoId("_LIZvXys9EeySlt9bF77XfA")]
    [DisplayName("Transfer Title")]
    [IsoXmlTag("TrfTitl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransferTitle { get; init; } 
    
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_LIZvYSs9EeySlt9bF77XfA")]
    [DisplayName("Settlement Process")]
    [IsoXmlTag("SttlmPrc")]
    public GenericIdentification30? SettlementProcess { get; init; } 
    
    /// <summary>
    /// Specifies the priority with which the instruction needs to be executed.
    /// </summary>
    [IsoId("_LIZvYys9EeySlt9bF77XfA")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public GenericIdentification30? Priority { get; init; } 
    
    /// <summary>
    /// Specifies whether the allocation of the collateral is manual or automatic.
    /// </summary>
    [IsoId("_LIZvZSs9EeySlt9bF77XfA")]
    [DisplayName("Automatic Allocation")]
    [IsoXmlTag("AutomtcAllcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AutomaticAllocation { get; init; } 
    
    /// <summary>
    /// Specifies whether the taker is allowed to solve the failing settlement by proposing other collateral movements.
    /// </summary>
    [IsoId("_LIZvZys9EeySlt9bF77XfA")]
    [DisplayName("Failed Settlement Salvation")]
    [IsoXmlTag("FaildSttlmSlvtn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FailedSettlementSalvation { get; init; } 
    
    /// <summary>
    /// Specifies if the main trading account  is included in the pool of securities positions available for collateralisation. It is used in case of re-use of collateral to specify the account from which the securities collateral is taken from.
    /// </summary>
    [IsoId("_LIZvaSs9EeySlt9bF77XfA")]
    [DisplayName("Main Trading Account Collateralisation")]
    [IsoXmlTag("MainTradgAcctCollstn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MainTradingAccountCollateralisation { get; init; } 
    
    /// <summary>
    /// Provides information on the baskets identification and the Eligibility Set Profile.
    /// </summary>
    [IsoId("_LIZvays9EeySlt9bF77XfA")]
    [DisplayName("Basket Identification And Eligibility Set Profile")]
    [IsoXmlTag("BsktIdAndElgbltySetPrfl")]
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; init; } 
    
    /// <summary>
    /// Collateral taker&apos;s answer to the collateral giver instruction.
    /// </summary>
    [IsoId("_LIZvbSs9EeySlt9bF77XfA")]
    [DisplayName("Response Status")]
    [IsoXmlTag("RspnSts")]
    public ResponseStatus9Choice_? ResponseStatus { get; init; } 
    
    /// <summary>
    /// Provides additional information to a collateral instruction.
    /// </summary>
    [IsoId("_LIZvbys9EeySlt9bF77XfA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation24? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
