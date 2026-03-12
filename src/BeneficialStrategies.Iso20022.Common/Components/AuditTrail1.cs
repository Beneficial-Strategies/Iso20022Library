// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes information needed to identify a change for a static data, the time when it was performed and the user requesting the change and approving it.
/// </summary>
[IsoId("_kzdEBO5NEeCisYr99QEiWA_1532720417")]
[DisplayName("Audit Trail")]
public partial record AuditTrail1
{
    #nullable enable
    
    /// <summary>
    /// Name of the field whose value has been changed.
    /// </summary>
    [IsoId("_kzm1AO5NEeCisYr99QEiWA_1740662573")]
    [DisplayName("Field Name")]
    [IsoXmlTag("FldNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text FieldName { get; init; } 
    
    /// <summary>
    /// Value of the field before the change.
    /// </summary>
    [IsoId("_kzm1Ae5NEeCisYr99QEiWA_-998075288")]
    [DisplayName("Old Field Value")]
    [IsoXmlTag("OdFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text OldFieldValue { get; init; } 
    
    /// <summary>
    /// Value of the field after the change.
    /// </summary>
    [IsoId("_kzm1Au5NEeCisYr99QEiWA_-1286976113")]
    [DisplayName("New Field Value")]
    [IsoXmlTag("NewFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text NewFieldValue { get; init; } 
    
    /// <summary>
    /// Timestamp of the change.
    /// </summary>
    [IsoId("_kzm1A-5NEeCisYr99QEiWA_-1287417640")]
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    
    /// <summary>
    /// User who instructed the change.
    /// </summary>
    [IsoId("_kzm1BO5NEeCisYr99QEiWA_-1840195094")]
    [DisplayName("Instructing User")]
    [IsoXmlTag("InstgUsr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text InstructingUser { get; init; } 
    
    /// <summary>
    /// User who approved the change instructed by the instructing user.
    /// </summary>
    [IsoId("_kzm1Be5NEeCisYr99QEiWA_276002183")]
    [DisplayName("Approving User")]
    [IsoXmlTag("ApprvgUsr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? ApprovingUser { get; init; } 
    
    
    #nullable disable
    
}
