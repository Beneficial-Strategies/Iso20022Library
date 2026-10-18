// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides remittance information about a payment for garnishment-related purposes.
/// </summary>
[IsoId("_NcxfEKJsEeK9W_i6uXeloA")]
public interface IGarnishment1 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of garnishment.
    /// </summary>
    [IsoId("_qR8P0InoEeOORMXOfBk1Bw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IGarnishmentType1 Type { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the garnisher.
    /// </summary>
    [IsoId("_V8UeQKJsEeK9W_i6uXeloA")]
    [DisplayName("Garnishee")]
    [IsoXmlTag("Grnshee")]
    IPartyIdentification43? Garnishee { get; }

    /// <summary>
    /// Party on the credit side of the transaction who administers the garnishment on behalf of the ultimate beneficiary.
    /// </summary>
    [IsoId("_hC52AIbKEeO-HOEzMX3Cwg")]
    [DisplayName("Garnishment Administrator")]
    [IsoXmlTag("GrnshmtAdmstr")]
    IPartyIdentification43? GarnishmentAdministrator { get; }

    /// <summary>
    /// Reference information that is specific to the agency receiving the garnishment.
    /// </summary>
    [IsoId("_k7405aJsEeK9W_i6uXeloA")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    Max140Text? ReferenceNumber { get; }

    /// <summary>
    /// Date of payment which garnishment was taken from.
    /// </summary>
    [IsoId("_t8hH5aJsEeK9W_i6uXeloA")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    ISODate? Date { get; }

    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [IsoId("_ZF8FI6JtEeK9W_i6uXeloA")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; }

    /// <summary>
    /// Indicates if the person to whom the garnishment applies (that is, the ultimate debtor) has family medical insurance coverage available.
    /// </summary>
    [IsoId("_UqQ5IKJvEeK9W_i6uXeloA")]
    [DisplayName("Family Medical Insurance Indicator")]
    [IsoXmlTag("FmlyMdclInsrncInd")]
    TrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; }

    /// <summary>
    /// Indicates if the employment of the person to whom the garnishment applies (that is, the ultimate debtor) has been terminated.
    /// </summary>
    [IsoId("_hqIo4KJvEeK9W_i6uXeloA")]
    [DisplayName("Employee Termination Indicator")]
    [IsoXmlTag("MplyeeTermntnInd")]
    TrueFalseIndicator? EmployeeTerminationIndicator { get; }
}
