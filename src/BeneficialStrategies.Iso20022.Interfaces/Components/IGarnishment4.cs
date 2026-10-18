// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides remittance information about a payment for garnishment-related purposes.
/// </summary>
[IsoId("_v9i0ETEyEe6g-ffJsqGiSA")]
public interface IGarnishment4 : IIsoComponent
{
    /// <summary>
    /// Date of payment which garnishment was taken from.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    IsoISODate? Date { get; }

    /// <summary>
    /// Indicates if the employment of the person to whom the garnishment applies (that is, the ultimate debtor) has been terminated.
    /// </summary>
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; }

    /// <summary>
    /// Indicates if the person to whom the garnishment applies (that is, the ultimate debtor) has family medical insurance coverage available.
    /// </summary>
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the garnisher.
    /// </summary>
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    IPartyIdentification272? Garnishee { get; }

    /// <summary>
    /// Party on the credit side of the transaction who administers the garnishment on behalf of the ultimate beneficiary.
    /// </summary>
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    IPartyIdentification272? GarnishmentAdministrator { get; }

    /// <summary>
    /// Reference information that is specific to the agency receiving the garnishment.
    /// </summary>
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    IsoMax140Text? ReferenceNumber { get; }

    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; }

    /// <summary>
    /// Specifies the type of garnishment.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IGarnishmentType1 Type { get; }
}
