// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// References of a switch leg.
/// </summary>
[IsoId("26ce5ad0-6918-4ef6-96de-e3e0bec8798b")]
[DisplayName("Switch Leg References3")]
public record SwitchLegReferences3
{
    [IsoId("26ce5ad0-lgid-0001-0001-e3e0bec8798b")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    public required LegIdentification1Choice LegIdentification { get; init; }

    [IsoId("26ce5ad0-lgrj-0001-0002-e3e0bec8798b")]
    [DisplayName("Leg Rejection Reason")]
    [IsoXmlTag("LegRjctnRsn")]
    public IsoMax350Text? LegRejectionReason { get; init; }

    [IsoId("26ce5ad0-rprd-0001-0003-e3e0bec8798b")]
    [DisplayName("Repaired Fee")]
    [IsoXmlTag("RepairdFee")]
    public ValueList<Fee12> RepairedFee { get; init; } = [];

    [IsoId("26ce5ad0-invs-0001-0004-e3e0bec8798b")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    [IsoId("26ce5ad0-fiin-0001-0005-e3e0bec8798b")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument107? FinancialInstrumentDetails { get; init; }
}
