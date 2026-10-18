// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGarnishment3"/>
[IsoId("__Cz88248EeiU9cctagi5ow")]
[DisplayName("Garnishment")]
public partial record Garnishment3
{
    /// <inheritdoc cref="IGarnishment3.Type"/>
    [IsoId("__NrwIW48EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GarnishmentType1 Type { get; init; }

    /// <inheritdoc cref="IGarnishment3.Garnishee"/>
    [IsoId("__NrwI248EeiU9cctagi5ow")]
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    public PartyIdentification135? Garnishee { get; init; }

    /// <inheritdoc cref="IGarnishment3.GarnishmentAdministrator"/>
    [IsoId("__NrwJW48EeiU9cctagi5ow")]
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    public PartyIdentification135? GarnishmentAdministrator { get; init; }

    /// <inheritdoc cref="IGarnishment3.ReferenceNumber"/>
    [IsoId("__NrwJ248EeiU9cctagi5ow")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="IGarnishment3.Date"/>
    [IsoId("__NrwKW48EeiU9cctagi5ow")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="IGarnishment3.RemittedAmount"/>
    [IsoId("__NrwK248EeiU9cctagi5ow")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }

    /// <inheritdoc cref="IGarnishment3.FamilyMedicalInsuranceIndicator"/>
    [IsoId("__NrwLW48EeiU9cctagi5ow")]
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; init; }

    /// <inheritdoc cref="IGarnishment3.EmployeeTerminationIndicator"/>
    [IsoId("__NrwL248EeiU9cctagi5ow")]
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; init; }
}
