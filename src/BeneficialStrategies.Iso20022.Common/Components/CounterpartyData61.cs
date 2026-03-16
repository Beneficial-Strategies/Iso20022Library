// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related specifically to counterparty.
/// </summary>
[IsoId("_CNhc96oAEemdLtwzt4CWxg")]
[DisplayName("Counterparty Data")]
public record CounterpartyData61
{
    /// <summary>
    /// Information describing the reporting counterparty.
    /// </summary>
    [IsoId("_CVyoIaoAEemdLtwzt4CWxg")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required CounterpartyIdentification4 ReportingCounterparty { get; init; }

    /// <summary>
    /// Data specific to other counterparties and related fields.
    /// </summary>
    [IsoId("_CVyoI6oAEemdLtwzt4CWxg")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required CounterpartyIdentification2 OtherCounterparty { get; init; }
}
