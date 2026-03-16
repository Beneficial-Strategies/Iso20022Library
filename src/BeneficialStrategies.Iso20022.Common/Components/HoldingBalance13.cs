// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_vh_0oTUEEe2tRf29bleifQ")]
[DisplayName("Holding Balance")]
public record HoldingBalance13
{
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_v4DkMzUEEe2tRf29bleifQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required SignedQuantityFormat14 Balance { get; init; }

    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_v4DkNTUEEe2tRf29bleifQ")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public required SecuritiesEntryType3Code BalanceType { get; init; }
}
