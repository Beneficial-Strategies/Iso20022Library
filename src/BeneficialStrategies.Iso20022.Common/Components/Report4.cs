// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics of the report.
/// </summary>
[IsoId("_m_exhfNBEeCuA5Tr22BnwA_1065800194")]
[DisplayName("Report")]
public record Report4
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_m_exhvNBEeCuA5Tr22BnwA_1065800718")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_m_exh_NBEeCuA5Tr22BnwA_2072309707")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_m_exiPNBEeCuA5Tr22BnwA_1065800233")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReportIdentification { get; init; }

    /// <summary>
    /// Date and time of the report.
    /// </summary>
    [IsoId("_m_exifNBEeCuA5Tr22BnwA_1065800255")]
    [DisplayName("Report Date Time")]
    [IsoXmlTag("RptDtTm")]
    public required DateAndDateTimeChoice_ ReportDateTime { get; init; }

    /// <summary>
    /// Preparation date and time of the report.
    /// </summary>
    [IsoId("_m_oigPNBEeCuA5Tr22BnwA_1065800317")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }

    /// <summary>
    /// Previous report date and time.
    /// </summary>
    [IsoId("_m_oigfNBEeCuA5Tr22BnwA_552028722")]
    [DisplayName("Previous Report Date Time")]
    [IsoXmlTag("PrvsRptDtTm")]
    public DateAndDateTimeChoice_? PreviousReportDateTime { get; init; }

    /// <summary>
    /// Specifies the frequency of the report.
    /// </summary>
    [IsoId("_m_oigvNBEeCuA5Tr22BnwA_1065800347")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency8Choice_ Frequency { get; init; }

    /// <summary>
    /// Specifies whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_m_oig_NBEeCuA5Tr22BnwA_1065800378")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType4Choice_ UpdateType { get; init; }

    /// <summary>
    /// Specifies the type of balance on which the report is prepared.
    /// </summary>
    [IsoId("_m_oihPNBEeCuA5Tr22BnwA_1065800717")]
    [DisplayName("Report Basis")]
    [IsoXmlTag("RptBsis")]
    public required StatementBasis6Choice_ ReportBasis { get; init; }

    /// <summary>
    /// Period for which the report is given.
    /// </summary>
    [IsoId("_m_oihfNBEeCuA5Tr22BnwA_1663646731")]
    [DisplayName("Report Period")]
    [IsoXmlTag("RptPrd")]
    public DatePeriodDetails? ReportPeriod { get; init; }

    /// <summary>
    /// Specifies the source of the report.
    /// </summary>
    [IsoId("_m_oihvNBEeCuA5Tr22BnwA_1090015501")]
    [DisplayName("Report Source")]
    [IsoXmlTag("RptSrc")]
    public StatementSource1Choice_? ReportSource { get; init; }

    /// <summary>
    /// Indicates whether the report is audited or not.
    /// </summary>
    [IsoId("_m_xscPNBEeCuA5Tr22BnwA_1065800748")]
    [DisplayName("Audited Indicator")]
    [IsoXmlTag("AudtdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AuditedIndicator { get; init; }

    /// <summary>
    /// Indicates whether there is activity or an information update reported in the report.
    /// </summary>
    [IsoId("_m_xscfNBEeCuA5Tr22BnwA_1065800439")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ActivityIndicator { get; init; }
}
