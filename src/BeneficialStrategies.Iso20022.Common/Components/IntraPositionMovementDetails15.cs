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
/// Details of the intra-position movement.
/// </summary>
[IsoId("_yzmXaaOAEeeDTpy0mhI4TQ")]
[DisplayName("Intra Position Movement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionMovementDetails15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraPositionMovementDetails15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraPositionMovementDetails15( FinancialInstrumentQuantity1Choice_ reqSettledQuantity,SecuritiesBalanceType6Choice_ reqBalanceTo,DateAndDateTime2Choice_ reqSettlementDate )
    {
        SettledQuantity = reqSettledQuantity;
        BalanceTo = reqBalanceTo;
        SettlementDate = reqSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifications (account owner and/or account servicer) of the intra-position movement.
    /// </summary>
    [IsoId("_zBu6A6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public References42Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References42Choice_? Identification { get; init; } 
    #else
    public References42Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_zBu6BaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttldQty")]
    #endif
    [IsoXmlTag("SttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ SettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_zBu6B6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Previously Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslySttldQty")]
    #endif
    [IsoXmlTag("PrevslySttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_zBu6CaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Remaining To Be Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngToBeSttldQty")]
    #endif
    [IsoXmlTag("RmngToBeSttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a securities sub-balance type for example restriction identification.
    /// </summary>
    [IsoId("_zBu6C6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Securities Sub Balance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSubBalId")]
    #endif
    [IsoXmlTag("SctiesSubBalId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; } 
    #else
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    [IsoId("_zBu6DaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Balance To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTo")]
    #endif
    [IsoXmlTag("BalTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceType6Choice_ BalanceTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesBalanceType6Choice_ BalanceTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType6Choice_ BalanceTo { get; init; } 
    #else
    public SecuritiesBalanceType6Choice_ BalanceTo { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_zBu6D6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ SettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_zBu6EaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Available Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblDt")]
    #endif
    [IsoXmlTag("AvlblDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? AvailableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? AvailableDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? AvailableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_zBu6E6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Acknowledged Status Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AckdStsTmStmp")]
    #endif
    [IsoXmlTag("AckdStsTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AcknowledgedStatusTimeStamp { get; init; } 
    #else
    public System.DateTime? AcknowledgedStatusTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_zBu6FaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Corporate Action Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtTp")]
    #endif
    [IsoXmlTag("CorpActnEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventType73Choice_? CorporateActionEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType73Choice_? CorporateActionEventType { get; init; } 
    #else
    public CorporateActionEventType73Choice_? CorporateActionEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_zBu6F6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Collateral Monitor Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMntrAmt")]
    #endif
    [IsoXmlTag("CollMntrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection44? CollateralMonitorAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection44? CollateralMonitorAmount { get; init; } 
    #else
    public AmountAndDirection44? CollateralMonitorAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_zBu6GaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Instruction Processing Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrcgAddtlDtls")]
    #endif
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? InstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_zBu6G6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
