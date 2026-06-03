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
[IsoId("_pP7JweSmEe-qVZLXW4RRBw")]
[DisplayName("Securities Cancellation2")]
public record SecuritiesCancellation2
{
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_pX6BF-SmEe-qVZLXW4RRBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_pX6BGeSmEe-qVZLXW4RRBw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_pX6BG-SmEe-qVZLXW4RRBw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus69Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Identifies the individual transaction.
    /// </summary>
    [IsoId("_pX6BHeSmEe-qVZLXW4RRBw")]
    [DisplayName("Cancellation")]
    [IsoXmlTag("Cxl")]
    [MinLength(1)]
    public ValueList<SecuritiesCancellationTransaction2> Cancellation { get; init; } = [];
}
