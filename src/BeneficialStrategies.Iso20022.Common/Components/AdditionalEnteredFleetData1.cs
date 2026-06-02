// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information entered for fleet transaction.
/// </summary>
[IsoId("_Cp6p8UYlEfCJpvfyM9roFQ")]
[DisplayName("Additional Entered Fleet Data1")]
public record AdditionalEnteredFleetData1
{
    /// <summary>
    /// Key-entered numeric data.
    /// </summary>
    [IsoId("_CsI3gUYlEfCJpvfyM9roFQ")]
    [DisplayName("Numeric")]
    [IsoXmlTag("Nmrc")]
    public IsoMax35NumericText? Numeric { get; init; }

    /// <summary>
    /// Key-entered alphanumeric data.
    /// </summary>
    [IsoId("_CsI3g0YlEfCJpvfyM9roFQ")]
    [DisplayName("Alpha Numeric")]
    [IsoXmlTag("AlphaNmrc")]
    public IsoMax350Text? AlphaNumeric { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_pVJaEkYkEfCJpvfyM9roFQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_pVJaE0YkEfCJpvfyM9roFQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
