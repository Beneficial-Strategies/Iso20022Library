// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the report.
/// </summary>
[IsoId("_MxUsgWp-EemmaZLSPtWX5A")]
[DisplayName("Securities Transaction Report5")]
public record SecuritiesTransactionReport5
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_M8_xA2p-EemmaZLSPtWX5A")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the settlement and intra-position query message sent to request this report.
    /// </summary>
    [IsoId("_M8_xC2p-EemmaZLSPtWX5A")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_M8_xE2p-EemmaZLSPtWX5A")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax35Text? ReportIdentification { get; init; }

    /// <summary>
    /// Date and time when the report was created.
    /// </summary>
    [IsoId("_M8_xFWp-EemmaZLSPtWX5A")]
    [DisplayName("Report Date Time")]
    [IsoXmlTag("RptDtTm")]
    public DateAndDateTime2Choice_? ReportDateTime { get; init; }

    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_M8_xHWp-EemmaZLSPtWX5A")]
    [DisplayName("Report Period")]
    [IsoXmlTag("RptPrd")]
    public Period7Choice_? ReportPeriod { get; init; }

    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_M8_xJWp-EemmaZLSPtWX5A")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public MovementResponseType1Code? QueryType { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_M8_xLWp-EemmaZLSPtWX5A")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency22Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_M8_xNWp-EemmaZLSPtWX5A")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice_ UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_M8_xPWp-EemmaZLSPtWX5A")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
