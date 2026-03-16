// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reported Fraud5.
/// </summary>
[IsoId("_uvIssZLFEe6TWIDarRgYow")]
[DisplayName("Reported Fraud5")]
public partial record ReportedFraud5
{
    #nullable enable

    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public required FraudReportingAction1Code Action { get; init; } 

    /// <summary>
    /// Case Reference.
    /// </summary>
    [DisplayName("Case Reference")]
    [IsoXmlTag("CaseRef")]
    public IsoMax35Text? CaseReference { get; init; } 

    /// <summary>
    /// Other Action.
    /// </summary>
    [DisplayName("Other Action")]
    [IsoXmlTag("OthrActn")]
    public IsoMax35Text? OtherAction { get; init; } 

    /// <summary>
    /// Other Reporting Entity.
    /// </summary>
    [DisplayName("Other Reporting Entity")]
    [IsoXmlTag("OthrRptgNtty")]
    public IsoMax35Text? OtherReportingEntity { get; init; } 

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; } 

    /// <summary>
    /// Reporting Entity.
    /// </summary>
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required PartyType26Code ReportingEntity { get; init; } 

    /// <summary>
    /// Submitter Case Reference.
    /// </summary>
    [DisplayName("Submitter Case Reference")]
    [IsoXmlTag("SubmitrCaseRef")]
    public IsoMax35Text? SubmitterCaseReference { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FraudType1Code Type { get; init; } 

    
    #nullable disable
    
}
