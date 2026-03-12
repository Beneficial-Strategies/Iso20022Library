// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
/// </summary>
[IsoId("_tps_UVkyEeGeoaLUQk__nA_-859843302")]
[DisplayName("Message Identification")]
public partial record MessageIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the assigner, and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The assigner has to make sure that MessageIdentification is unique per assignee for a pre-agreed period.
    /// </summary>
    [IsoId("_tps_UlkyEeGeoaLUQk__nA_1629104731")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_tps_U1kyEeGeoaLUQk__nA_-251200909")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; } 
    
    /// <summary>
    /// Identifies the first agent in the identification chain, following the payment initiating party.
    /// </summary>
    [IsoId("_tp2JQFkyEeGeoaLUQk__nA_1181378892")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public BranchAndFinancialInstitutionIdentification5? FirstAgent { get; init; } 
    
    
    #nullable disable
    
}
