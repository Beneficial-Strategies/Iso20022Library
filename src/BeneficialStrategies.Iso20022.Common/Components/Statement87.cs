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
    [IsoId("_R4PwJFdOEfCb5MzBL2XS4A")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public IsoMax35Text? QueryReference { get; init; }

    [IsoId("_Ht09E9_NEe-Ned3-G07x_A")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    public IsoMax35Text? StatementIdentification { get; init; }

    [IsoId("_sU_uNN_NEe-Ned3-G07x_A")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; }

    [IsoId("_Ht09Hd_NEe-Ned3-G07x_A")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency25Choice_? Frequency { get; init; }

    [IsoId("_DQ9WpFdOEfCb5MzBL2XS4A")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType16Choice_ UpdateType { get; init; }

    [IsoId("_Ht09Nd_NEe-Ned3-G07x_A")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
