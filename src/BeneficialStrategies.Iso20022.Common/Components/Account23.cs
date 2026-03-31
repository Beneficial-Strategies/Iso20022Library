// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("_43d7MWB0EeaHEJD5P6-ccw")]
[DisplayName("Account")]
public record Account23
{
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_GbkZYWB1EeaHEJD5P6-ccw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Information about the account to which the existing account is to be linked.
    /// </summary>
    [IsoId("_UF7QkGB1EeaHEJD5P6-ccw")]
    [DisplayName("Related Account Details")]
    [IsoXmlTag("RltdAcctDtls")]
    public GenericIdentification1? RelatedAccountDetails { get; init; }
}
