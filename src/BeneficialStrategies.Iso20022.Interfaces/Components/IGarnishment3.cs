// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides remittance information about a payment for garnishment-related purposes.
/// </summary>
[IsoId("__Cz88248EeiU9cctagi5ow")]
public interface IGarnishment3 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of garnishment.
    /// </summary>
    [IsoId("__NrwIW48EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IGarnishmentType1 Type { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the garnisher.
    /// </summary>
    [IsoId("__NrwI248EeiU9cctagi5ow")]
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    IPartyIdentification135? Garnishee { get; }

    /// <summary>
    /// Party on the credit side of the transaction who administers the garnishment on behalf of the ultimate beneficiary.
    /// </summary>
    [IsoId("__NrwJW48EeiU9cctagi5ow")]
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    IPartyIdentification135? GarnishmentAdministrator { get; }

    /// <summary>
    /// Reference information that is specific to the agency receiving the garnishment.
    /// </summary>
    [IsoId("__NrwJ248EeiU9cctagi5ow")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    IsoMax140Text? ReferenceNumber { get; }

    /// <summary>
    /// Date of payment which garnishment was taken from.
    /// </summary>
    [IsoId("__NrwKW48EeiU9cctagi5ow")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    IsoISODate? Date { get; }

    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [IsoId("__NrwK248EeiU9cctagi5ow")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; }

    /// <summary>
    /// Indicates if the person to whom the garnishment applies (that is, the ultimate debtor) has family medical insurance coverage available.
    /// </summary>
    [IsoId("__NrwLW48EeiU9cctagi5ow")]
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; }

    /// <summary>
    /// Indicates if the employment of the person to whom the garnishment applies (that is, the ultimate debtor) has been terminated.
    /// </summary>
    [IsoId("__NrwL248EeiU9cctagi5ow")]
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; }
}
