// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGarnishment1"/>
[IsoId("_NcxfEKJsEeK9W_i6uXeloA")]
[DisplayName("Garnishment")]
public partial record Garnishment1
{
    /// <inheritdoc cref="IGarnishment1.Type"/>
    [IsoId("_qR8P0InoEeOORMXOfBk1Bw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GarnishmentType1 Type { get; init; }

    /// <inheritdoc cref="IGarnishment1.Garnishee"/>
    [IsoId("_V8UeQKJsEeK9W_i6uXeloA")]
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    public PartyIdentification43? Garnishee { get; init; }

    /// <inheritdoc cref="IGarnishment1.GarnishmentAdministrator"/>
    [IsoId("_hC52AIbKEeO-HOEzMX3Cwg")]
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    public PartyIdentification43? GarnishmentAdministrator { get; init; }

    /// <inheritdoc cref="IGarnishment1.ReferenceNumber"/>
    [IsoId("_k7405aJsEeK9W_i6uXeloA")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="IGarnishment1.Date"/>
    [IsoId("_t8hH5aJsEeK9W_i6uXeloA")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="IGarnishment1.RemittedAmount"/>
    [IsoId("_ZF8FI6JtEeK9W_i6uXeloA")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }

    /// <inheritdoc cref="IGarnishment1.FamilyMedicalInsuranceIndicator"/>
    [IsoId("_UqQ5IKJvEeK9W_i6uXeloA")]
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; init; }

    /// <inheritdoc cref="IGarnishment1.EmployeeTerminationIndicator"/>
    [IsoId("_hqIo4KJvEeK9W_i6uXeloA")]
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; init; }
}
