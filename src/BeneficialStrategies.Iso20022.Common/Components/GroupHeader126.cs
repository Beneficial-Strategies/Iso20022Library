// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group Header126.
/// </summary>
[IsoId("_51yEcTEyEe6g-ffJsqGiSA")]
[DisplayName("Group Header126")]
public record GroupHeader126
{
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
    /// Charges Requestor.
    /// </summary>
    [DisplayName("Charges Requestor")]
    [IsoXmlTag("ChrgsRqstr")]
    public BranchAndFinancialInstitutionIdentification8? ChargesRequestor { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Total Charges.
    /// </summary>
    [DisplayName("Total Charges")]
    [IsoXmlTag("TtlChrgs")]
    public TotalCharges7? TotalCharges { get; init; }
}
