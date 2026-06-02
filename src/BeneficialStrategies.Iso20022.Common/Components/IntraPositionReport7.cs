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
[IsoId("_ZL1JoWdCEemvNLufWGIVOQ")]
[DisplayName("Intra Position Report7")]
public record IntraPositionReport7
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_ZWzqk2dCEemvNLufWGIVOQ")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the query message sent to request this statement.
    /// </summary>
    [IsoId("_ZWzqm2dCEemvNLufWGIVOQ")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_ZWzqo2dCEemvNLufWGIVOQ")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax35Text? ReportIdentification { get; init; }

    /// <summary>
    /// Date and time when the report was created.
    /// </summary>
    [IsoId("_ZWzqpWdCEemvNLufWGIVOQ")]
    [DisplayName("Report Date Time")]
    [IsoXmlTag("RptDtTm")]
    public DateAndDateTime2Choice? ReportDateTime { get; init; }

    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_ZWzqrWdCEemvNLufWGIVOQ")]
    [DisplayName("Report Period")]
    [IsoXmlTag("RptPrd")]
    public Period7Choice? ReportPeriod { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_ZWzqtWdCEemvNLufWGIVOQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency22Choice? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_ZWzqvWdCEemvNLufWGIVOQ")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_ZWzqxWdCEemvNLufWGIVOQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
