// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fraud reporting type information
/// </summary>
[IsoId("_Nfi6oZjCEeefZKJHxQTztg")]
[DisplayName("Reported Fraud")]
public record ReportedFraud2
{
    /// <summary>
    /// Type of fraud for which a report is established.
    /// </summary>
    [IsoId("_NtFnYZjCEeefZKJHxQTztg")]
    [DisplayName("Fraud Type")]
    [IsoXmlTag("FrdTp")]
    public required FraudType1Code FraudType { get; init; }

    /// <summary>
    /// Other type of fraud.
    /// </summary>
    [IsoId("_NtFnY5jCEeefZKJHxQTztg")]
    [DisplayName("Other Fraud Type")]
    [IsoXmlTag("OthrFrdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherFraudType { get; init; }

    /// <summary>
    /// Identifies the type of reported fraudulent transaction.
    /// </summary>
    [IsoId("_NtFnZZjCEeefZKJHxQTztg")]
    [DisplayName("Fraud Reporting Action")]
    [IsoXmlTag("FrdRptgActn")]
    public required FraudReportingAction1Code FraudReportingAction { get; init; }

    /// <summary>
    /// Other fraud reporting action.
    /// </summary>
    [IsoId("_NtFnZ5jCEeefZKJHxQTztg")]
    [DisplayName("Other Fraud Reporting Action")]
    [IsoXmlTag("OthrFrdRptgActn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherFraudReportingAction { get; init; }

    /// <summary>
    /// Type of fraud reporting entity.
    /// </summary>
    [IsoId("_NtFnaZjCEeefZKJHxQTztg")]
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required PartyType25Code ReportingEntity { get; init; }

    /// <summary>
    /// Other type of fraud reporting entity.
    /// </summary>
    [IsoId("_NtFna5jCEeefZKJHxQTztg")]
    [DisplayName("Other Reporting Entity")]
    [IsoXmlTag("OthrRptgNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherReportingEntity { get; init; }

    /// <summary>
    /// Reference to the case as provided by the submitter.
    /// </summary>
    [IsoId("_NtFnc5jCEeefZKJHxQTztg")]
    [DisplayName("Submitter Case Reference")]
    [IsoXmlTag("SubmitrCaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubmitterCaseReference { get; init; }

    /// <summary>
    /// Reference to fraudulent case.
    /// </summary>
    [IsoId("_NtFneZjCEeefZKJHxQTztg")]
    [DisplayName("Case Reference")]
    [IsoXmlTag("CaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CaseReference { get; init; }
}
