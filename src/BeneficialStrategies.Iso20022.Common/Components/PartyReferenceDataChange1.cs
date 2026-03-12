// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
[IsoId("_k2vBhO5NEeCisYr99QEiWA_-253138342")]
[DisplayName("Party Reference Data Change")]
public partial record PartyReferenceDataChange1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the party for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_k24ygO5NEeCisYr99QEiWA_-763132473")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification3 PartyIdentification { get; init; } 
    
    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    [IsoId("_k24yge5NEeCisYr99QEiWA_-366977408")]
    [DisplayName("Field Name")]
    [IsoXmlTag("FldNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text FieldName { get; init; } 
    
    /// <summary>
    /// Value of the related field before the change was applied.
    /// </summary>
    [IsoId("_k24ygu5NEeCisYr99QEiWA_-1364049761")]
    [DisplayName("Old Field Value")]
    [IsoXmlTag("OdFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text OldFieldValue { get; init; } 
    
    /// <summary>
    /// Value of the related field after the change was applied.
    /// </summary>
    [IsoId("_k24yg-5NEeCisYr99QEiWA_-18100137")]
    [DisplayName("New Field Value")]
    [IsoXmlTag("NewFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text NewFieldValue { get; init; } 
    
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_k24yhO5NEeCisYr99QEiWA_-1250210695")]
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    
    
    #nullable disable
    
}
