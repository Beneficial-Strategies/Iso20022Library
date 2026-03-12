// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_OfUtEQzCEeuTPv2wqaotHg")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails55
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_OuM2lwzCEeuTPv2wqaotHg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_OuM2nwzCEeuTPv2wqaotHg")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; } 
    
    /// <summary>
    /// Number identifying a securities sub balance type (for example, restriction identification etc…).
    /// </summary>
    [IsoId("_OuM2pwzCEeuTPv2wqaotHg")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    [IsoId("_OuM2qQzCEeuTPv2wqaotHg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 
    
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_OuM2sQzCEeuTPv2wqaotHg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_OuM2uQzCEeuTPv2wqaotHg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    
    /// <summary>
    /// Provides additional settlement processing information which cannot be included within the structured fields of the message.
    /// </summary>
    [IsoId("_OuM2wQzCEeuTPv2wqaotHg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    
    #nullable disable
    
}
