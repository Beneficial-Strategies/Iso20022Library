// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGarnishment4"/>
[IsoId("_v9i0ETEyEe6g-ffJsqGiSA")]
[Description(@"Provides remittance information about a payment for garnishment-related purposes.")]
[DisplayName("Garnishment4")]
public partial record Garnishment4
{
    /// <inheritdoc cref="IGarnishment4.Date"/>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="IGarnishment4.EmployeeTerminationIndicator"/>
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    public IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; init; }

    /// <inheritdoc cref="IGarnishment4.FamilyMedicalInsuranceIndicator"/>
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    public IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; init; }

    /// <inheritdoc cref="IGarnishment4.Garnishee"/>
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    public PartyIdentification272? Garnishee { get; init; }

    /// <inheritdoc cref="IGarnishment4.GarnishmentAdministrator"/>
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    public PartyIdentification272? GarnishmentAdministrator { get; init; }

    /// <inheritdoc cref="IGarnishment4.ReferenceNumber"/>
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="IGarnishment4.RemittedAmount"/>
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }

    /// <inheritdoc cref="IGarnishment4.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GarnishmentType1 Type { get; init; }
}
