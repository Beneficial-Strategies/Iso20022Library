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
/// ***is all the elements required/used in today, should we simplify?***
/// </summary>
[IsoId("_L3fC4Ss9EeySlt9bF77XfA")]
[DisplayName("Collateral Parameters")]
public partial record CollateralParameters12
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [IsoId("_MOvFQSs9EeySlt9bF77XfA")]
    [DisplayName("Collateral Instruction Type")]
    [IsoXmlTag("CollInstrTp")]
    public required CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_MOvFQys9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public required ExposureType23Choice_ ExposureType { get; init; } 
    
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_MOvFRSs9EeySlt9bF77XfA")]
    [DisplayName("Collateral Side")]
    [IsoXmlTag("CollSd")]
    public required CollateralRole1Code CollateralSide { get; init; } 
    
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_MOvFRys9EeySlt9bF77XfA")]
    [DisplayName("Settlement Process")]
    [IsoXmlTag("SttlmPrc")]
    public GenericIdentification30? SettlementProcess { get; init; } 
    
    /// <summary>
    /// Specifies the priority with which the instruction needs to be executed.
    /// </summary>
    [IsoId("_MOvFSSs9EeySlt9bF77XfA")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public GenericIdentification30? Priority { get; init; } 
    
    /// <summary>
    /// Specifies whether the allocation of the collateral is manual or automatic.
    /// </summary>
    [IsoId("_MOvFSys9EeySlt9bF77XfA")]
    [DisplayName("Automatic Allocation")]
    [IsoXmlTag("AutomtcAllcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AutomaticAllocation { get; init; } 
    
    /// <summary>
    /// Indicates whether the proposed collateral movements can be accepted.
    /// </summary>
    [IsoId("_MOvFTSs9EeySlt9bF77XfA")]
    [DisplayName("Collateral Approved")]
    [IsoXmlTag("CollApprvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CollateralApproved { get; init; } 
    
    /// <summary>
    /// Indicates whether the proposed collateral movements have settled or no
    /// </summary>
    [IsoId("_MOvFTys9EeySlt9bF77XfA")]
    [DisplayName("Settlement Approved")]
    [IsoXmlTag("SttlmApprvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SettlementApproved { get; init; } 
    
    
    #nullable disable
    
}
