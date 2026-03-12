// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-balance movement.
/// </summary>
[IsoId("_pqQzoTnfEem7JZMuWtwtsg")]
[DisplayName("Intra Balance")]
public partial record IntraBalance5
{
    #nullable enable
    
    /// <summary>
    /// Total amount of money to be settled.
    /// </summary>
    [IsoId("_p0siBTnfEem7JZMuWtwtsg")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required Amount2Choice_ SettlementAmount { get; init; } 
    
    /// <summary>
    /// Date and time at which the amount of money is to be moved.
    /// </summary>
    [IsoId("_p0siBznfEem7JZMuWtwtsg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 
    
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_p0siDznfEem7JZMuWtwtsg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_p0siFznfEem7JZMuWtwtsg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    
    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_p0siHznfEem7JZMuWtwtsg")]
    [DisplayName("Cash Sub Balance Identification")]
    [IsoXmlTag("CshSubBalId")]
    public GenericIdentification37? CashSubBalanceIdentification { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_p0siITnfEem7JZMuWtwtsg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_p0siKTnfEem7JZMuWtwtsg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    
    #nullable disable
    
}
