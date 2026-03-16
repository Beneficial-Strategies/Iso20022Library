// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Counterparty Side Transaction Reporting3.
/// </summary>
[IsoId("_F7ysVUjrEe-KhcStGV4xTg")]
[DisplayName("Counterparty Side Transaction Reporting3")]
public record CounterpartySideTransactionReporting3
{
    /// <summary>
    /// Counterparty Side Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Counterparty Side Unique Transaction Identifier")]
    [IsoXmlTag("CtrPtySdUnqTxIdr")]
    public ValueList<UniqueTransactionIdentifier3> CounterpartySideUniqueTransactionIdentifier { get; init; } =
        [];

    /// <summary>
    /// Reporting Jurisdiction.
    /// </summary>
    [DisplayName("Reporting Jurisdiction")]
    [IsoXmlTag("RptgJursdctn")]
    public IsoMax35Text? ReportingJurisdiction { get; init; }

    /// <summary>
    /// Reporting Party.
    /// </summary>
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public PartyIdentification242Choice_? ReportingParty { get; init; }
}
