// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fraud reporting type information.
/// </summary>
[IsoId("_n_HyYXRzEfC68Y4jZPNEug")]
[DisplayName("Reported Fraud7")]
public record ReportedFraud7
{
    /// <summary>
    /// Type of fraud for which a report is established.
    /// </summary>
    [IsoId("_oAT9UXRzEfC68Y4jZPNEug")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FraudType2Code Type { get; init; }

    /// <summary>
    /// Identifies the type of fraud reporting action.
    /// </summary>
    [IsoId("_oAT9VXRzEfC68Y4jZPNEug")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public required FraudReportingAction2Code Action { get; init; }

    /// <summary>
    /// Type of fraud reporting entity.
    /// </summary>
    [IsoId("_oAT9WXRzEfC68Y4jZPNEug")]
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required ATICAPartyType1Code ReportingEntity { get; init; }

    /// <summary>
    /// Reference to the case as provided by the submitter.
    /// </summary>
    [IsoId("_oAT9XXRzEfC68Y4jZPNEug")]
    [DisplayName("Submitter Case Reference")]
    [IsoXmlTag("SubmitrCaseRef")]
    public IsoMax35Text? SubmitterCaseReference { get; init; }

    /// <summary>
    /// Reference of fraudulent case.
    /// </summary>
    [IsoId("_oAT9YXRzEfC68Y4jZPNEug")]
    [DisplayName("Case Reference")]
    [IsoXmlTag("CaseRef")]
    public IsoMax35Text? CaseReference { get; init; }
}
