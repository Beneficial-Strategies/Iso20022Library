// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reported Fraud4.
/// </summary>
[IsoId("_w1rKIZK_Ee6TWIDarRgYow")]
[DisplayName("Reported Fraud4")]
public record ReportedFraud4
{
    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public required FraudReportingAction1Code Action { get; init; }

    /// <summary>
    /// Arrest.
    /// </summary>
    [DisplayName("Arrest")]
    [IsoXmlTag("Arrst")]
    public IsoTrueFalseIndicator? Arrest { get; init; }

    /// <summary>
    /// Cardholder Reporting Date.
    /// </summary>
    [DisplayName("Cardholder Reporting Date")]
    [IsoXmlTag("CrdhldrRptgDt")]
    public IsoISODate? CardholderReportingDate { get; init; }

    /// <summary>
    /// Case Locator Number.
    /// </summary>
    [DisplayName("Case Locator Number")]
    [IsoXmlTag("CaseLctrNb")]
    public IsoMax35Text? CaseLocatorNumber { get; init; }

    /// <summary>
    /// Case Reference.
    /// </summary>
    [DisplayName("Case Reference")]
    [IsoXmlTag("CaseRef")]
    public IsoMax35Text? CaseReference { get; init; }

    /// <summary>
    /// Compromised Credential.
    /// </summary>
    [DisplayName("Compromised Credential")]
    [IsoXmlTag("CmprmsdCrdntl")]
    public ValueList<AuthenticationMethod12Code> CompromisedCredential { get; init; } = [];

    /// <summary>
    /// Confirmation Reporting Date.
    /// </summary>
    [DisplayName("Confirmation Reporting Date")]
    [IsoXmlTag("ConfRptgDt")]
    public IsoISODate? ConfirmationReportingDate { get; init; }

    /// <summary>
    /// Investigation Status.
    /// </summary>
    [DisplayName("Investigation Status")]
    [IsoXmlTag("InvstgtnSts")]
    public IsoMax256Text? InvestigationStatus { get; init; }

    /// <summary>
    /// Market Segment.
    /// </summary>
    [DisplayName("Market Segment")]
    [IsoXmlTag("MktSgmt")]
    public IsoMax35Text? MarketSegment { get; init; }

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
}
