// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the message and individual instruction(s) for which the cancellation was requested.
/// </summary>
[IsoId("_KPVWwDUBEe2tRf29bleifQ")]
[DisplayName("Meeting Instruction Identification")]
public partial record MeetingInstructionIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the previous meeting instruction message containing the individual instruction(s) for which the cancellation was requested.
    /// </summary>
    [IsoId("_TeJ2wDUBEe2tRf29bleifQ")]
    [DisplayName("Meeting Instruction Identification")]
    [IsoXmlTag("MtgInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MeetingInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the individual instruction for which the cancellation was requested.
    /// </summary>
    [IsoId("_XMIkYDUBEe2tRf29bleifQ")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    
    
    #nullable disable
    
}
