// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual instructions included in the message.
/// </summary>
[IsoId("_7o6soQcYEeyTDbUIoCmuCw")]
[DisplayName("Group Header")]
public partial record GroupHeader104
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the message.
    /// Usage: The instructing agent has to make sure that MessageIdentification is unique per market infrastructure for a pre-agreed period.
    /// </summary>
    [IsoId("_7ua3sQcYEeyTDbUIoCmuCw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_7ua3swcYEeyTDbUIoCmuCw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Number of individual settlement requests contained in the message.
    /// </summary>
    [IsoId("_7ua3twcYEeyTDbUIoCmuCw")]
    [DisplayName("Number Of Settlement Requests")]
    [IsoXmlTag("NbOfSttlmReqs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfSettlementRequests { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_7ua3uQcYEeyTDbUIoCmuCw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; } 
    
    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the market infrastructure is completed.
    /// </summary>
    [IsoId("_7ua3vQcYEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction14? SettlementInformation { get; init; } 
    
    
    #nullable disable
    
}
