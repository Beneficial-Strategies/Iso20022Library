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
[IsoId("_Wwrm0RODEfC1ZfCQz0xB3g")]
[DisplayName("Reported Fraud6")]
public record ReportedFraud6
{
    /// <summary>
    /// Type of fraud for which a report is established.
    /// </summary>
    [IsoId("_W31XsRODEfC1ZfCQz0xB3g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FraudType2Code Type { get; init; }

    /// <summary>
    /// Identifies the type of fraud reporting action.
    /// </summary>
    [IsoId("_W31XtRODEfC1ZfCQz0xB3g")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public required FraudReportingAction2Code Action { get; init; }

    /// <summary>
    /// Type of fraud reporting entity.
    /// </summary>
    [IsoId("_W31XuRODEfC1ZfCQz0xB3g")]
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required ATICAPartyType1Code ReportingEntity { get; init; }

    /// <summary>
    /// Identifies the type of cardholder credential that was compromised.
    /// </summary>
    [IsoId("_W31XvRODEfC1ZfCQz0xB3g")]
    [DisplayName("Compromised Credential")]
    [IsoXmlTag("CmprmsdCrdntl")]
    public SimpleValueList<AuthenticationMethod13Code> CompromisedCredential { get; init; } = [];

    /// <summary>
    /// Date of fraud as reported by the cardholder.
    /// </summary>
    [IsoId("_W31XvxODEfC1ZfCQz0xB3g")]
    [DisplayName("Cardholder Reporting Date")]
    [IsoXmlTag("CrdhldrRptgDt")]
    public IsoISODate? CardholderReportingDate { get; init; }

    /// <summary>
    /// Date fraud was confirmed by the cardholder.
    /// </summary>
    [IsoId("_W31XwRODEfC1ZfCQz0xB3g")]
    [DisplayName("Confirmation Reporting Date")]
    [IsoXmlTag("ConfRptgDt")]
    public IsoISODate? ConfirmationReportingDate { get; init; }

    /// <summary>
    /// Reference to the case as provided by the submitter.
    /// </summary>
    [IsoId("_W31XwxODEfC1ZfCQz0xB3g")]
    [DisplayName("Submitter Case Reference")]
    [IsoXmlTag("SubmitrCaseRef")]
    public IsoMax35Text? SubmitterCaseReference { get; init; }

    /// <summary>
    /// Type of market segment of confirmed fraud.
    /// </summary>
    [IsoId("_W31XxRODEfC1ZfCQz0xB3g")]
    [DisplayName("Market Segment")]
    [IsoXmlTag("MktSgmt")]
    public IsoMax35Text? MarketSegment { get; init; }

    /// <summary>
    /// Case locator number.
    /// </summary>
    [IsoId("_W31XxxODEfC1ZfCQz0xB3g")]
    [DisplayName("Case Locator Number")]
    [IsoXmlTag("CaseLctrNb")]
    public IsoMax35Text? CaseLocatorNumber { get; init; }

    /// <summary>
    /// Reference of fraudulent case.
    /// </summary>
    [IsoId("_W31XyRODEfC1ZfCQz0xB3g")]
    [DisplayName("Case Reference")]
    [IsoXmlTag("CaseRef")]
    public IsoMax35Text? CaseReference { get; init; }

    /// <summary>
    /// Indicates whether the party that committed fraud was arrested or not.
    /// </summary>
    [IsoId("_W31XyxODEfC1ZfCQz0xB3g")]
    [DisplayName("Arrest")]
    [IsoXmlTag("Arrst")]
    public IsoTrueFalseIndicator? Arrest { get; init; }

    /// <summary>
    /// Investigation status at time of submission.
    /// </summary>
    [IsoId("_W31XzRODEfC1ZfCQz0xB3g")]
    [DisplayName("Investigation Status")]
    [IsoXmlTag("InvstgtnSts")]
    public IsoMax256Text? InvestigationStatus { get; init; }
}
