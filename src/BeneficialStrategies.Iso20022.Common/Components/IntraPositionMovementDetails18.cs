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
[IsoId("_LTFb8wVVEeqjd8n6wD9JVw")]
[DisplayName("Intra Position Movement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionMovementDetails18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraPositionMovementDetails18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraPositionMovementDetails18( FinancialInstrumentQuantity15Choice_ reqSettledQuantity,SecuritiesBalanceType8Choice_ reqBalanceTo,DateAndDateTime2Choice_ reqSettlementDate )
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
    [IsoId("_LTFb9wVVEeqjd8n6wD9JVw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public References51Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References51Choice_? Identification { get; init; } 
    #else
    public References51Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_LTFb-QVVEeqjd8n6wD9JVw")]
    [DisplayName("Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttldQty")]
    #endif
    [IsoXmlTag("SttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ SettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_LTFb-wVVEeqjd8n6wD9JVw")]
    [DisplayName("Previously Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslySttldQty")]
    #endif
    [IsoXmlTag("PrevslySttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_LTFb_QVVEeqjd8n6wD9JVw")]
    [DisplayName("Remaining To Be Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngToBeSttldQty")]
    #endif
    [IsoXmlTag("RmngToBeSttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a securities sub-balance type for example restriction identification.
    /// </summary>
    [IsoId("_LTFb_wVVEeqjd8n6wD9JVw")]
    [DisplayName("Securities Sub Balance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSubBalId")]
    #endif
    [IsoXmlTag("SctiesSubBalId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; } 
    #else
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    [IsoId("_LTFcAQVVEeqjd8n6wD9JVw")]
    [DisplayName("Balance To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTo")]
    #endif
    [IsoXmlTag("BalTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceType8Choice_ BalanceTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesBalanceType8Choice_ BalanceTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType8Choice_ BalanceTo { get; init; } 
    #else
    public SecuritiesBalanceType8Choice_ BalanceTo { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_LTFcAwVVEeqjd8n6wD9JVw")]
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
    [IsoId("_LTFcBQVVEeqjd8n6wD9JVw")]
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
    [IsoId("_LTFcBwVVEeqjd8n6wD9JVw")]
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
    [IsoId("_LTFcCQVVEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtTp")]
    #endif
    [IsoXmlTag("CorpActnEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventType101Choice_? CorporateActionEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType101Choice_? CorporateActionEventType { get; init; } 
    #else
    public CorporateActionEventType101Choice_? CorporateActionEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_LTFcCwVVEeqjd8n6wD9JVw")]
    [DisplayName("Collateral Monitor Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMntrAmt")]
    #endif
    [IsoXmlTag("CollMntrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection55? CollateralMonitorAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection55? CollateralMonitorAmount { get; init; } 
    #else
    public AmountAndDirection55? CollateralMonitorAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_LTFcDQVVEeqjd8n6wD9JVw")]
    [DisplayName("Instruction Processing Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrcgAddtlDtls")]
    #endif
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? InstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LTFcDwVVEeqjd8n6wD9JVw")]
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
