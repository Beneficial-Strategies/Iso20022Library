// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trading Side Transaction Reporting3.
/// </summary>
[IsoId("_FuYiqUjrEe-KhcStGV4xTg")]
[DisplayName("Trading Side Transaction Reporting3")]
public record TradingSideTransactionReporting3
{
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

    /// <summary>
    /// Trading Side Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Trading Side Unique Transaction Identifier")]
    [IsoXmlTag("TradgSdUnqTxIdr")]
    public ValueList<UniqueTransactionIdentifier3> TradingSideUniqueTransactionIdentifier { get; init; } =
        [];
}
