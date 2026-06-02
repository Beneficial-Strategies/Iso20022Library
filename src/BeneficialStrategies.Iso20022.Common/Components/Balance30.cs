// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report on the net position of a security, on a single securities account, for a certain date.
/// </summary>
[IsoId("_zBB40ag1EfCXwLUUylXgrQ")]
[DisplayName("Balance30")]
public record Balance30
{
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_zEwiQag1EfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Report on the net position of a security, on a single securities account, for a certain date.
    /// </summary>
    [IsoId("_zEwiQ6g1EfCXwLUUylXgrQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public ValueList<AggregateBalanceInformation47> BalanceForAccount { get; init; } = [];

    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_zEwiRag1EfCXwLUUylXgrQ")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public ValueList<SubAccountIdentification75> SubAccountDetails { get; init; } = [];

    /// <summary>
    /// Total valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_zEwiR6g1EfCXwLUUylXgrQ")]
    [DisplayName("Account Base Currency Total Amounts")]
    [IsoXmlTag("AcctBaseCcyTtlAmts")]
    public TotalValueInPageAndStatement1? AccountBaseCurrencyTotalAmounts { get; init; }
}
