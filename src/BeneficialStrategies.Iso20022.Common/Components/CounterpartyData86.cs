// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to counterparties.
/// </summary>
[IsoId("_CRJNUcgtEeuGrNSsxk3B0A")]
[DisplayName("Counterparty Data")]
public record CounterpartyData86
{
    /// <summary>
    /// Set of information identifying the reporting counterparty.
    /// </summary>
    [IsoId("_CSkJo8gtEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public CounterpartyIdentification10? ReportingCounterparty { get; init; }

    /// <summary>
    /// Data specific to other counterparties and related information.
    /// </summary>
    [IsoId("_CSkJpcgtEeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public OrganisationIdentification15Choice_? OtherCounterparty { get; init; }

    /// <summary>
    /// Specifies if a triparty agent is involved in the transaction.
    /// </summary>
    [IsoId("_CSkJp8gtEeuGrNSsxk3B0A")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TripartyAgent { get; init; }

    /// <summary>
    /// Specifies if the agent lender is involved in the securities lending transaction.
    /// </summary>
    [IsoId("_CSkJqcgtEeuGrNSsxk3B0A")]
    [DisplayName("Agent Lender")]
    [IsoXmlTag("AgtLndr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AgentLender { get; init; }
}
