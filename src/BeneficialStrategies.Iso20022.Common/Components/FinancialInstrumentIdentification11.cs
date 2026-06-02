// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security.
/// </summary>
[IsoId("1e31fb48-a643-49d9-bdfd-8cb40dfe512b")]
[DisplayName("Financial Instrument Identification11")]
public record FinancialInstrumentIdentification11
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("818fb830-c63e-4244-94e8-15e05f0b9569")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification46Choice Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("118bf13f-1191-48b5-a569-2629609498c9")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("411f0a9b-e1dd-45b1-b2c0-7ee25c3ebd06")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Type of security.
    /// </summary>
    [IsoId("23f45476-1a17-4e6f-b010-edef36452557")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice? ClassificationType { get; init; }
}
