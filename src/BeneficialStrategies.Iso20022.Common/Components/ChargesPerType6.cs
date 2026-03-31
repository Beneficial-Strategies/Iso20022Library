// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charges Per Type6.
/// </summary>
[IsoId("_I__DMT0QEe-thIfLZ94a1w")]
[DisplayName("Charges Per Type6")]
public record ChargesPerType6
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
    public ValueList<ChargesPerTypeRecord6> Record { get; init; } = [];

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
