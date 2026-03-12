// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies generic information about an investigation report.
/// </summary>
[IsoId("_toznclkyEeGeoaLUQk__nA_-1793756198")]
[DisplayName("Report Header")]
public partial record ReportHeader4
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference as assigned by the case assigner to unambiguously identify the case status report.
    /// </summary>
    [IsoId("_toznc1kyEeGeoaLUQk__nA_1504138745")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Party reporting the status of the investigation case.
    /// </summary>
    [IsoId("_tozndFkyEeGeoaLUQk__nA_24301386")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party12Choice_ From { get; init; } 
    
    /// <summary>
    /// Party to which the status of the case is reported.
    /// </summary>
    [IsoId("_tozndVkyEeGeoaLUQk__nA_-196016673")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party12Choice_ To { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_to8xYFkyEeGeoaLUQk__nA_1594636115")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
