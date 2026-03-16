// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the account information or on a business error.
/// </summary>
[IsoId("_fCEawdcZEeqRFcf2R4bPBw")]
[DisplayName("Account Report")]
public record AccountReport29
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_fDmEwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification4Choice_ AccountIdentification { get; init; }

    /// <summary>
    /// Requested information on the account or business error when information has not been found.
    /// </summary>
    [IsoId("_fDmEw9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Or Error")]
    [IsoXmlTag("AcctOrErr")]
    public required AccountOrBusinessError5Choice_ AccountOrError { get; init; }
}
