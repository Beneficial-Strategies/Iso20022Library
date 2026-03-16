// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This is regulatory transaction reporting information from the counterparty side party.
/// </summary>
[IsoId("_Q6_ElE4REeOHYs5EqIAeTw")]
[DisplayName("Counterparty Side Transaction Reporting")]
public record CounterpartySideTransactionReporting1
{
    /// <summary>
    /// Specifies the supervisory party to which the trade needs to be reported.
    /// </summary>
    [IsoId("_Q6_Elk4REeOHYs5EqIAeTw")]
    [DisplayName("Reporting Jurisdiction")]
    [IsoXmlTag("RptgJursdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReportingJurisdiction { get; init; }

    /// <summary>
    /// Identifies the party that is responsible for reporting the trade to the trade repository.
    /// </summary>
    [IsoId("_Q6_El04REeOHYs5EqIAeTw")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public PartyIdentification73Choice_? ReportingParty { get; init; }

    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI). This is the UTI from the Counterparty Side party.
    /// </summary>
    [IsoId("_unM10U4REeOHYs5EqIAeTw")]
    [DisplayName("Counterparty Side Unique Transaction Identifier")]
    [IsoXmlTag("CtrPtySdUnqTxIdr")]
    public ValueList<UniqueTransactionIdentifier2> CounterpartySideUniqueTransactionIdentifier { get; init; } =
        [];
}
