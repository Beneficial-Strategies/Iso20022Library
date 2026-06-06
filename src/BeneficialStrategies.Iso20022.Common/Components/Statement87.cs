// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
[IsoId("_HpYh4d_NEe-Ned3-G07x_A")]
[DisplayName("Statement87")]
public record Statement87
{
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_R4PwJFdOEfCb5MzBL2XS4A")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_Ht09E9_NEe-Ned3-G07x_A")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_sU_uNN_NEe-Ned3-G07x_A")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_Ht09Hd_NEe-Ned3-G07x_A")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency25Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_DQ9WpFdOEfCb5MzBL2XS4A")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType16Choice_ UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_Ht09Nd_NEe-Ned3-G07x_A")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
