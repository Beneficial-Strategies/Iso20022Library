// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGarnishment2"/>
[IsoId("_ncGuUbTREeeyuKckOGlwuA")]
[DisplayName("Garnishment")]
public partial record Garnishment2
{
    /// <inheritdoc cref="IGarnishment2.Type"/>
    [IsoId("_nkw7EbTREeeyuKckOGlwuA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GarnishmentType1 Type { get; init; }

    /// <inheritdoc cref="IGarnishment2.Garnishee"/>
    [IsoId("_nkw7E7TREeeyuKckOGlwuA")]
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    public PartyIdentification125? Garnishee { get; init; }

    /// <inheritdoc cref="IGarnishment2.GarnishmentAdministrator"/>
    [IsoId("_nkw7FbTREeeyuKckOGlwuA")]
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    public PartyIdentification125? GarnishmentAdministrator { get; init; }

    /// <inheritdoc cref="IGarnishment2.ReferenceNumber"/>
    [IsoId("_nkw7F7TREeeyuKckOGlwuA")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="IGarnishment2.Date"/>
    [IsoId("_nkw7GbTREeeyuKckOGlwuA")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="IGarnishment2.RemittedAmount"/>
    [IsoId("_nkw7G7TREeeyuKckOGlwuA")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }

    /// <inheritdoc cref="IGarnishment2.FamilyMedicalInsuranceIndicator"/>
    [IsoId("_nkw7HbTREeeyuKckOGlwuA")]
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; init; }

    /// <inheritdoc cref="IGarnishment2.EmployeeTerminationIndicator"/>
    [IsoId("_nkxiIbTREeeyuKckOGlwuA")]
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; init; }
}
