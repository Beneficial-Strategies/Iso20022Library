// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of an account.
/// </summary>
[IsoId("_ljU4MEzEEeafiMTDrtSnyw")]
[DisplayName("Other Account Status")]
public record OtherAccountStatus1
{
    /// <summary>
    /// Status of the account.
    /// </summary>
    [IsoId("_0IBQsEzEEeafiMTDrtSnyw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required GenericIdentification36 Status { get; init; }

    /// <summary>
    /// Reason for the status of the account.
    /// </summary>
    [IsoId("_4ZUt0EzEEeafiMTDrtSnyw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public GenericIdentification36? Reason { get; init; }
}
