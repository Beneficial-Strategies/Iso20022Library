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
[IsoId("_EmOB-eSmEe-qVZLXW4RRBw")]
[DisplayName("Securities Modification Transaction2")]
public record SecuritiesModificationTransaction2
{
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_Ev6wgeSmEe-qVZLXW4RRBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Ev6wg-SmEe-qVZLXW4RRBw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_Ev6wheSmEe-qVZLXW4RRBw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus71Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Unambiguous identification of the modification request.
    /// </summary>
    [IsoId("_Ev6wjeSmEe-qVZLXW4RRBw")]
    [DisplayName("Request Reference")]
    [IsoXmlTag("ReqRef")]
    public required IsoMax35Text RequestReference { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_Ev6wj-SmEe-qVZLXW4RRBw")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public IsoISODateTime? StatusDate { get; init; }

    /// <summary>
    /// Details of the request providing the changes and references of the instruction for which the modification is requested.
    /// </summary>
    [IsoId("_Ev6wl-SmEe-qVZLXW4RRBw")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public RequestDetails33? RequestDetails { get; init; }

    /// <summary>
    /// Identifies additional details of the transaction.
    /// </summary>
    [IsoId("_Ev6wmeSmEe-qVZLXW4RRBw")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public SettlementOrIntraPosition3Choice_? Underlying { get; init; }
}
