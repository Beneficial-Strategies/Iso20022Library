// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to the status of the account.
/// </summary>
[IsoId("_5CsP8BFBEeK3w4cPHH9eMA")]
[DisplayName("Account Status Modification")]
public record AccountStatusModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_EBnboBFCEeK3w4cPHH9eMA")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Status of the account.
    /// </summary>
    [IsoId("_IqUFEBFCEeK3w4cPHH9eMA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required AccountStatus3Code Status { get; init; }
}
