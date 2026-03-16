// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charges Per Transaction4.
/// </summary>
[IsoId("_6FpFYTEyEe6g-ffJsqGiSA")]
[DisplayName("Charges Per Transaction4")]
public partial record ChargesPerTransaction4
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax140Text? AdditionalInformation { get; init; } 

    /// <summary>
    /// Charges Account.
    /// </summary>
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount40? ChargesAccount { get; init; } 

    /// <summary>
    /// Charges Account Owner.
    /// </summary>
    [DisplayName("Charges Account Owner")]
    [IsoXmlTag("ChrgsAcctOwnr")]
    public BranchAndFinancialInstitutionIdentification8? ChargesAccountOwner { get; init; } 

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
    public ValueList<ChargesPerTransactionRecord4> Record { get; init; } = [];

    /// <summary>
    /// Total Charges Per Transaction.
    /// </summary>
    [DisplayName("Total Charges Per Transaction")]
    [IsoXmlTag("TtlChrgsPerTx")]
    public TotalCharges7? TotalChargesPerTransaction { get; init; } 

    
    #nullable disable
    
}
