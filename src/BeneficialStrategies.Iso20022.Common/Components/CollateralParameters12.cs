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
/// Parameters which explicitly state the conditions that must be fulfilled before a particular triparty collateral instruction/transaction  can be confirmed. These parameters are defined by the instructing party in compliance with triparty collateral rules in the market the instruction/transaction will take place.
/// ***is all the elements required/used in today, should we simplify?***
/// </summary>
[IsoId("_L3fC4Ss9EeySlt9bF77XfA")]
[DisplayName("Collateral Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralParameters12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralParameters12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralParameters12( CollateralTransactionType1Choice_ reqCollateralInstructionType,ExposureType23Choice_ reqExposureType,CollateralRole1Code reqCollateralSide )
    {
        CollateralInstructionType = reqCollateralInstructionType;
        ExposureType = reqExposureType;
        CollateralSide = reqCollateralSide;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [IsoId("_MOvFQSs9EeySlt9bF77XfA")]
    [DisplayName("Collateral Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollInstrTp")]
    #endif
    [IsoXmlTag("CollInstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    #else
    public CollateralTransactionType1Choice_ CollateralInstructionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_MOvFQys9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExposureType23Choice_ ExposureType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExposureType23Choice_ ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType23Choice_ ExposureType { get; init; } 
    #else
    public ExposureType23Choice_ ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_MOvFRSs9EeySlt9bF77XfA")]
    [DisplayName("Collateral Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSd")]
    #endif
    [IsoXmlTag("CollSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralRole1Code CollateralSide { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralRole1Code CollateralSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralRole1Code CollateralSide { get; init; } 
    #else
    public CollateralRole1Code CollateralSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_MOvFRys9EeySlt9bF77XfA")]
    [DisplayName("Settlement Process")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPrc")]
    #endif
    [IsoXmlTag("SttlmPrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? SettlementProcess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? SettlementProcess { get; init; } 
    #else
    public GenericIdentification30? SettlementProcess { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the priority with which the instruction needs to be executed.
    /// </summary>
    [IsoId("_MOvFSSs9EeySlt9bF77XfA")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? Priority { get; init; } 
    #else
    public GenericIdentification30? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the allocation of the collateral is manual or automatic.
    /// </summary>
    [IsoId("_MOvFSys9EeySlt9bF77XfA")]
    [DisplayName("Automatic Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutomtcAllcn")]
    #endif
    [IsoXmlTag("AutomtcAllcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AutomaticAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AutomaticAllocation { get; init; } 
    #else
    public System.String? AutomaticAllocation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the proposed collateral movements can be accepted.
    /// </summary>
    [IsoId("_MOvFTSs9EeySlt9bF77XfA")]
    [DisplayName("Collateral Approved")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollApprvd")]
    #endif
    [IsoXmlTag("CollApprvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CollateralApproved { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralApproved { get; init; } 
    #else
    public System.String? CollateralApproved { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the proposed collateral movements have settled or no
    /// </summary>
    [IsoId("_MOvFTys9EeySlt9bF77XfA")]
    [DisplayName("Settlement Approved")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmApprvd")]
    #endif
    [IsoXmlTag("SttlmApprvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SettlementApproved { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementApproved { get; init; } 
    #else
    public System.String? SettlementApproved { get; set; } 
    #endif
    
    
    #nullable disable
    
}
