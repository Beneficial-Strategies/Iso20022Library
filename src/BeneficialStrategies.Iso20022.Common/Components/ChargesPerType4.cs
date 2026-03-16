// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charges Per Type4.
/// </summary>
[IsoId("_6BIY6zEyEe6g-ffJsqGiSA")]
[DisplayName("Charges Per Type4")]
public record ChargesPerType4
{
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
    public ValueList<ChargesPerTypeRecord4> Record { get; init; } = [];

    /// <summary>
    /// Total Charges Per Charge Type.
    /// </summary>
    [DisplayName("Total Charges Per Charge Type")]
    [IsoXmlTag("TtlChrgsPerChrgTp")]
    public TotalCharges7? TotalChargesPerChargeType { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType3Choice_ Type { get; init; }
}
