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
[IsoId("_Y3VxIHbHEeef9c2nwgY9Xw")]
[DisplayName("Reported Fraud")]
public record ReportedFraud1
{
    /// <summary>
    /// Type of fraud for which a report is established.
    /// </summary>
    [IsoId("_8bgNMHbHEeef9c2nwgY9Xw")]
    [DisplayName("Fraud Type")]
    [IsoXmlTag("FrdTp")]
    public required FraudType1Code FraudType { get; init; }

    /// <summary>
    /// Other type of fraud.
    /// </summary>
    [IsoId("_QeeMQHbIEeef9c2nwgY9Xw")]
    [DisplayName("Other Fraud Type")]
    [IsoXmlTag("OthrFrdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherFraudType { get; init; }

    /// <summary>
    /// Identifies the type of reported fraudulent transaction.
    /// </summary>
    [IsoId("_WJgzMZiYEee2DZ9xp6Fx_g")]
    [DisplayName("Fraud Reporting Action")]
    [IsoXmlTag("FrdRptgActn")]
    public required FraudReportingAction1Code FraudReportingAction { get; init; }

    /// <summary>
    /// Other fraud reporting action.
    /// </summary>
    [IsoId("_ZJlR8ZiYEee2DZ9xp6Fx_g")]
    [DisplayName("Other Fraud Reporting Action")]
    [IsoXmlTag("OthrFrdRptgActn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherFraudReportingAction { get; init; }

    /// <summary>
    /// Type of fraud reporting entity.
    /// </summary>
    [IsoId("_ujCokHbHEeef9c2nwgY9Xw")]
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required PartyType26Code ReportingEntity { get; init; }

    /// <summary>
    /// Other type of fraud reporting entity.
    /// </summary>
    [IsoId("_0tn7gHbHEeef9c2nwgY9Xw")]
    [DisplayName("Other Reporting Entity")]
    [IsoXmlTag("OthrRptgNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherReportingEntity { get; init; }

    /// <summary>
    /// Identifies the type of cardholder credential that was compromised.
    /// </summary>
    [IsoId("_ffFEsHbIEeef9c2nwgY9Xw")]
    [DisplayName("Compromised Credential")]
    [IsoXmlTag("CmprmsdCrdntl")]
    public SimpleValueList<AuthenticationMethod11Code> CompromisedCredential { get; init; } = [];

    /// <summary>
    /// Date of fraud as reported by the cardholder
    /// </summary>
    [IsoId("_tTXT8HbIEeef9c2nwgY9Xw")]
    [DisplayName("Cardholder Reporting Date")]
    [IsoXmlTag("CrdhldrRptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CardholderReportingDate { get; init; }

    /// <summary>
    /// Date fraud was confirmed by the cardholder.
    /// </summary>
    [IsoId("_3nJ38HbIEeef9c2nwgY9Xw")]
    [DisplayName("Confirmation Reporting Date")]
    [IsoXmlTag("ConfRptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConfirmationReportingDate { get; init; }

    /// <summary>
    /// Reference to the case as provided by the submitter.
    /// </summary>
    [IsoId("_HUIHIHbJEeef9c2nwgY9Xw")]
    [DisplayName("Submitter Case Reference")]
    [IsoXmlTag("SubmitrCaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubmitterCaseReference { get; init; }

    /// <summary>
    /// Details of fraudulent case.
    /// </summary>
    [IsoId("_eNuWsZiXEee2DZ9xp6Fx_g")]
    [DisplayName("Fraud Case Details")]
    [IsoXmlTag("FrdCaseDtls")]
    public FraudCaseDetails1? FraudCaseDetails { get; init; }

    /// <summary>
    /// Status of submitter investigation at time of submission.
    /// </summary>
    [IsoId("_cK3_QJjFEeepepmc9PHSnw")]
    [DisplayName("Fraud Investigation Status")]
    [IsoXmlTag("FrdInvstgtnSts")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? FraudInvestigationStatus { get; init; }
}
