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
/// Details of the intra-balance movement.
/// </summary>
[IsoId("_pqQzoTnfEem7JZMuWtwtsg")]
[DisplayName("Intra Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalance5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraBalance5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalance5( Amount2Choice_ reqSettlementAmount,DateAndDateTime2Choice_ reqSettlementDate,CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceFrom,CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceTo )
    {
        SettlementAmount = reqSettlementAmount;
        SettlementDate = reqSettlementDate;
        BalanceFrom = reqBalanceFrom;
        BalanceTo = reqBalanceTo;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total amount of money to be settled.
    /// </summary>
    [IsoId("_p0siBTnfEem7JZMuWtwtsg")]
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
    /// Date and time at which the amount of money is to be moved.
    /// </summary>
    [IsoId("_p0siBznfEem7JZMuWtwtsg")]
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
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_p0siDznfEem7JZMuWtwtsg")]
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
    [IsoId("_p0siFznfEem7JZMuWtwtsg")]
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
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_p0siHznfEem7JZMuWtwtsg")]
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
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_p0siITnfEem7JZMuWtwtsg")]
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
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_p0siKTnfEem7JZMuWtwtsg")]
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
    
    
    #nullable disable
    
}
