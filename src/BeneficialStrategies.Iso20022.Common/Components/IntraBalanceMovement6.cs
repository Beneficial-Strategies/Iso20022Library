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
/// Provides additional details of the intra-balance movements data.
/// </summary>
[IsoId("_YX0RITneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalanceMovement6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraBalanceMovement6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalanceMovement6( CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceFrom,CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceTo,Amount2Choice_ reqSettlementAmount,DateAndDateTime2Choice_ reqIntendedSettlementDate,System.DateTime reqCreationDateTime )
    {
        BalanceFrom = reqBalanceFrom;
        BalanceTo = reqBalanceTo;
        SettlementAmount = reqSettlementAmount;
        IntendedSettlementDate = reqIntendedSettlementDate;
        CreationDateTime = reqCreationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_YisEITneEem7JZMuWtwtsg")]
    [DisplayName("Balance From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalFr")]
    #endif
    [IsoXmlTag("BalFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #else
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_YisEKTneEem7JZMuWtwtsg")]
    [DisplayName("Balance To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTo")]
    #endif
    [IsoXmlTag("BalTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #else
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_YisEMTneEem7JZMuWtwtsg")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2Choice_ SettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2Choice_ SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_ SettlementAmount { get; init; } 
    #else
    public Amount2Choice_ SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_YisEMzneEem7JZMuWtwtsg")]
    [DisplayName("Settled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttldAmt")]
    #endif
    [IsoXmlTag("SttldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2Choice_? SettledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_? SettledAmount { get; init; } 
    #else
    public Amount2Choice_? SettledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_YisENTneEem7JZMuWtwtsg")]
    [DisplayName("Previously Settled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslySttldAmt")]
    #endif
    [IsoXmlTag("PrevslySttldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2Choice_? PreviouslySettledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_? PreviouslySettledAmount { get; init; } 
    #else
    public Amount2Choice_? PreviouslySettledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_YisENzneEem7JZMuWtwtsg")]
    [DisplayName("Remaining Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngSttlmAmt")]
    #endif
    [IsoXmlTag("RmngSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2Choice_? RemainingSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_? RemainingSettlementAmount { get; init; } 
    #else
    public Amount2Choice_? RemainingSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the amount of money is intended to be moved.
    /// </summary>
    [IsoId("_YisEOTneEem7JZMuWtwtsg")]
    [DisplayName("Intended Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntnddSttlmDt")]
    #endif
    [IsoXmlTag("IntnddSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ IntendedSettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ IntendedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ IntendedSettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ IntendedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the amount of money is moved.
    /// </summary>
    [IsoId("_YisEQTneEem7JZMuWtwtsg")]
    [DisplayName("Effective Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvSttlmDt")]
    #endif
    [IsoXmlTag("FctvSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_YisESTneEem7JZMuWtwtsg")]
    [DisplayName("Status Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsDt")]
    #endif
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StatusDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StatusDate { get; init; } 
    #else
    public System.DateTime? StatusDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_YisEUTneEem7JZMuWtwtsg")]
    [DisplayName("Cash Sub Balance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSubBalId")]
    #endif
    [IsoXmlTag("CshSubBalId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? CashSubBalanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? CashSubBalanceIdentification { get; init; } 
    #else
    public GenericIdentification37? CashSubBalanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_YisEUzneEem7JZMuWtwtsg")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages57? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages57? Linkages { get; init; } 
    #else
    public Linkages57? Linkages { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_YisEVTneEem7JZMuWtwtsg")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriorityNumeric4Choice_? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriorityNumeric4Choice_? Priority { get; init; } 
    #else
    public PriorityNumeric4Choice_? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_YisEXTneEem7JZMuWtwtsg")]
    [DisplayName("Message Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgOrgtr")]
    #endif
    [IsoXmlTag("MsgOrgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification8? MessageOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8? MessageOriginator { get; init; } 
    #else
    public SystemPartyIdentification8? MessageOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_YisEXzneEem7JZMuWtwtsg")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_YisEZzneEem7JZMuWtwtsg")]
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
    [IsoId("_YisEbzneEem7JZMuWtwtsg")]
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
