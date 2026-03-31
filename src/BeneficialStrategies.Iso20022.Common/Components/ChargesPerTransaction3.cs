// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charges Per Transaction3.
/// </summary>
[IsoId("_4DOhsTEyEe6g-ffJsqGiSA")]
[DisplayName("Charges Per Transaction3")]
public record ChargesPerTransaction3
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax140Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Charges Account Agent.
    /// </summary>
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification8? ChargesAccountAgent { get; init; }

    /// <summary>
    /// Charges Account Agent Account.
    /// </summary>
    [DisplayName("Charges Account Agent Account")]
    [IsoXmlTag("ChrgsAcctAgtAcct")]
    public CashAccount40? ChargesAccountAgentAccount { get; init; }

    /// <summary>
    /// Charges Identification.
    /// </summary>
    [DisplayName("Charges Identification")]
    [IsoXmlTag("ChrgsId")]
    public IsoMax35Text? ChargesIdentification { get; init; }

    /// <summary>
    /// Record.
    /// </summary>
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<ChargesPerTransactionRecord3> Record { get; init; } = [];

    /// <summary>
    /// Total Charges Per Transaction.
    /// </summary>
    [DisplayName("Total Charges Per Transaction")]
    [IsoXmlTag("TtlChrgsPerTx")]
    public TotalCharges7? TotalChargesPerTransaction { get; init; }
}
