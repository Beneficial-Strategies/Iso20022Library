// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the rejected collateral substitution.
/// </summary>
[IsoId("_FS7TSytJEeyOa655cLd-DQ")]
[DisplayName("Collateral Substitution Response")]
public record CollateralSubstitutionResponse3
{
    /// <summary>
    /// Reference to the collateral substitution request identification.
    /// </summary>
    [IsoId("_FqxLgStJEeyOa655cLd-DQ")]
    [DisplayName("Collateral Substitution Request Identification")]
    [IsoXmlTag("CollSbstitnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the collateral substitution amount that is rejected.
    /// </summary>
    [IsoId("_FqxLgytJEeyOa655cLd-DQ")]
    [DisplayName("Rejected Amount")]
    [IsoXmlTag("RjctdAmt")]
    public required ActiveCurrencyAndAmount RejectedAmount { get; init; }

    /// <summary>
    /// Specifies the reasons why the collateral substitution is rejected.
    /// </summary>
    [IsoId("_FqxLhStJEeyOa655cLd-DQ")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public required RejectionReason68Code RejectionReason { get; init; }

    /// <summary>
    /// Provides additional information about the collateral substitution request rejection.
    /// </summary>
    [IsoId("_FqxLhytJEeyOa655cLd-DQ")]
    [DisplayName("Rejection Reason Information")]
    [IsoXmlTag("RjctnRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? RejectionReasonInformation { get; init; }
}
