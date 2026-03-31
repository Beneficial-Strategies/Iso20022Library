// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_XO_0I249EeiU9cctagi5ow")]
[DisplayName("Cash Account And Entry")]
public record CashAccountAndEntry3
{
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_XYZAo249EeiU9cctagi5ow")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount39 Account { get; init; }

    /// <summary>
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    [IsoId("_XYZApW49EeiU9cctagi5ow")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public CashEntry2? Entry { get; init; }
}
