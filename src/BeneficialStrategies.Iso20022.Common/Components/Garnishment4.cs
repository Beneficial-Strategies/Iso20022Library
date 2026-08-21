// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides remittance information about a payment for garnishment-related purposes.
/// </summary>
[IsoId("_v9i0ETEyEe6g-ffJsqGiSA")]
[Description(@"Provides remittance information about a payment for garnishment-related purposes.")]
[DisplayName("Garnishment4")]
public record Garnishment4
{
    /// <summary>
    /// Date of payment which garnishment was taken from.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Indicates if the employment of the person to whom the garnishment applies (that is, the ultimate debtor) has been terminated.
    /// </summary>
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    public IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; init; }

    /// <summary>
    /// Indicates if the person to whom the garnishment applies (that is, the ultimate debtor) has family medical insurance coverage available.
    /// </summary>
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    public IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the garnisher.
    /// </summary>
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    public PartyIdentification272? Garnishee { get; init; }

    /// <summary>
    /// Party on the credit side of the transaction who administers the garnishment on behalf of the ultimate beneficiary.
    /// </summary>
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    public PartyIdentification272? GarnishmentAdministrator { get; init; }

    /// <summary>
    /// Reference information that is specific to the agency receiving the garnishment.
    /// </summary>
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }

    /// <summary>
    /// Specifies the type of garnishment.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GarnishmentType1 Type { get; init; }
}
