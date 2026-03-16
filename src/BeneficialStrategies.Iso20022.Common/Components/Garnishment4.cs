// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Garnishment4.
/// </summary>
[IsoId("_v9i0ETEyEe6g-ffJsqGiSA")]
[DisplayName("Garnishment4")]
public partial record Garnishment4
{
    #nullable enable

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; } 

    /// <summary>
    /// Employee Termination Indicator.
    /// </summary>
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    public IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; init; } 

    /// <summary>
    /// Family Medical Insurance Indicator.
    /// </summary>
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    public IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; init; } 

    /// <summary>
    /// Garnishee.
    /// </summary>
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    public PartyIdentification272? Garnishee { get; init; } 

    /// <summary>
    /// Garnishment Administrator.
    /// </summary>
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    public PartyIdentification272? GarnishmentAdministrator { get; init; } 

    /// <summary>
    /// Reference Number.
    /// </summary>
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    public IsoMax140Text? ReferenceNumber { get; init; } 

    /// <summary>
    /// Remitted Amount.
    /// </summary>
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GarnishmentType1 Type { get; init; } 

    
    #nullable disable
    
}
