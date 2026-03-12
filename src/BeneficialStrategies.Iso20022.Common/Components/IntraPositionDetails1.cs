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
[IsoId("_QXkwjtp-Ed-ak6NoX_4Aeg_1327511942")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_QXkwj9p-Ed-ak6NoX_4Aeg_-48799635")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric1Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_QXuhgNp-Ed-ak6NoX_4Aeg_-329186604")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    [IsoId("_QXuhgdp-Ed-ak6NoX_4Aeg_483985631")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTimeChoice_ SettlementDate { get; init; } 
    
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_QXuhgtp-Ed-ak6NoX_4Aeg_463157706")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesBalanceType2Choice_ BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_QXuhg9p-Ed-ak6NoX_4Aeg_508410476")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesBalanceType2Choice_ BalanceTo { get; init; } 
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_QXuhhNp-Ed-ak6NoX_4Aeg_-163453955")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    
    #nullable disable
    
}
