// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[IsoId("_pX6BH-SmEe-qVZLXW4RRBw")]
[DisplayName("Securities Cancellation Transaction2")]
public record SecuritiesCancellationTransaction2
{
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_pf1OAeSmEe-qVZLXW4RRBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_pf1OA-SmEe-qVZLXW4RRBw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_pf1OBeSmEe-qVZLXW4RRBw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus69Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Unambiguous identification of the cancellation request.
    /// </summary>
    [IsoId("_pf1ODeSmEe-qVZLXW4RRBw")]
    [DisplayName("Request Reference")]
    [IsoXmlTag("ReqRef")]
    public required IsoMax35Text RequestReference { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_pf1OD-SmEe-qVZLXW4RRBw")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public IsoISODateTime? StatusDate { get; init; }

    /// <summary>
    /// References of the transaction for which the intra-position modification is requested.
    /// </summary>
    [IsoId("_pf1OF-SmEe-qVZLXW4RRBw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public References33? TransactionIdentification { get; init; }

    /// <summary>
    /// Identifies additional details of the transaction.
    /// </summary>
    [IsoId("_pf1OH-SmEe-qVZLXW4RRBw")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public SettlementOrIntraPosition3Choice_? Underlying { get; init; }
}
