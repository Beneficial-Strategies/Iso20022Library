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
[IsoId("_dqPFMdcZEeqRFcf2R4bPBw")]
[DisplayName("Cash Account And Entry")]
public record CashAccountAndEntry4
{
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_drzycdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount41 Account { get; init; }

    /// <summary>
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    [IsoId("_drzyc9cZEeqRFcf2R4bPBw")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public CashEntry2? Entry { get; init; }
}
