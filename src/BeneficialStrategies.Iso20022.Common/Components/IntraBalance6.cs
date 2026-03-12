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
[IsoId("_B-PU4TngEem7JZMuWtwtsg")]
[DisplayName("Intra Balance")]
public partial record IntraBalance6
{
    #nullable enable
    
    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_CIOXUTngEem7JZMuWtwtsg")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public Amount2Choice_? SettledAmount { get; init; } 
    
    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_CIOXUzngEem7JZMuWtwtsg")]
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public Amount2Choice_? PreviouslySettledAmount { get; init; } 
    
    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_CIOXVTngEem7JZMuWtwtsg")]
    [DisplayName("Remaining Settlement Amount")]
    [IsoXmlTag("RmngSttlmAmt")]
    public Amount2Choice_? RemainingSettlementAmount { get; init; } 
    
    /// <summary>
    /// Date and time at which the amount of money is moved.
    /// </summary>
    [IsoId("_CIOXVzngEem7JZMuWtwtsg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 
    
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_CIOXXzngEem7JZMuWtwtsg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_CIOXZzngEem7JZMuWtwtsg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    
    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_CIOXbzngEem7JZMuWtwtsg")]
    [DisplayName("Cash Sub Balance Identification")]
    [IsoXmlTag("CshSubBalId")]
    public GenericIdentification37? CashSubBalanceIdentification { get; init; } 
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_CIOXcTngEem7JZMuWtwtsg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    
    #nullable disable
    
}
