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
    [IsoId("_Ev6wgeSmEe-qVZLXW4RRBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    [IsoId("_Ev6wg-SmEe-qVZLXW4RRBw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    [IsoId("_Ev6wheSmEe-qVZLXW4RRBw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus71Choice? ProcessingStatus { get; init; }

    [IsoId("_Ev6wjeSmEe-qVZLXW4RRBw")]
    [DisplayName("Request Reference")]
    [IsoXmlTag("ReqRef")]
    public required IsoMax35Text RequestReference { get; init; }

    [IsoId("_Ev6wj-SmEe-qVZLXW4RRBw")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public IsoISODateTime? StatusDate { get; init; }

    [IsoId("_Ev6wl-SmEe-qVZLXW4RRBw")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public RequestDetails33? RequestDetails { get; init; }

    [IsoId("_Ev6wmeSmEe-qVZLXW4RRBw")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public SettlementOrIntraPosition3Choice? Underlying { get; init; }
}
