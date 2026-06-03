// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the transactions in the report.
/// </summary>
[IsoId("_7bnZQQNrEfG_3cM8uyJ20w")]
[DisplayName("Securities Settlement Transactions6")]
public record SecuritiesSettlementTransactions6
{
    [IsoId("_87vvRQNrEfG_3cM8uyJ20w")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    [IsoId("_87vvRwNrEfG_3cM8uyJ20w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    [IsoId("_87vvSQNrEfG_3cM8uyJ20w")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public StatusAndReason52? StatusAndReason { get; init; }

    [IsoId("_87vvSwNrEfG_3cM8uyJ20w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    [MinLength(1)]
    public ValueList<Transaction169> Transaction { get; init; } = [];
}
