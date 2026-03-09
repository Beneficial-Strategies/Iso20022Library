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
[IsoId("_B-PU4TngEem7JZMuWtwtsg")]
[DisplayName("Intra Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalance6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraBalance6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalance6( DateAndDateTime2Choice_ reqSettlementDate,CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceFrom,CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceTo )
    {
        SettlementDate = reqSettlementDate;
        BalanceFrom = reqBalanceFrom;
        BalanceTo = reqBalanceTo;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_CIOXUTngEem7JZMuWtwtsg")]
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
    [IsoId("_CIOXUzngEem7JZMuWtwtsg")]
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
    [IsoId("_CIOXVTngEem7JZMuWtwtsg")]
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
    /// Date and time at which the amount of money is moved.
    /// </summary>
    [IsoId("_CIOXVzngEem7JZMuWtwtsg")]
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
    [IsoId("_CIOXXzngEem7JZMuWtwtsg")]
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
    [IsoId("_CIOXZzngEem7JZMuWtwtsg")]
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
    [IsoId("_CIOXbzngEem7JZMuWtwtsg")]
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
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_CIOXcTngEem7JZMuWtwtsg")]
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
