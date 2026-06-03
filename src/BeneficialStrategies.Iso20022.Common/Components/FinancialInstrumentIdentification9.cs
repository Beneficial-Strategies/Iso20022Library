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
[IsoId("e8f784ab-6296-4a7b-bf3b-f82500c36f0c")]
[DisplayName("Financial Instrument Identification9")]
public record FinancialInstrumentIdentification9
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("546bfa92-ec5c-4db4-8c5c-221507557a17")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification46Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("ab5b0b82-3efc-4de5-899f-dc06ddf35865")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("bf9225c0-25ba-40aa-8dac-1497c29586fe")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Type of security.
    /// </summary>
    [IsoId("41d04162-3b8d-42d1-a736-b7d13bc038ad")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Type of security offered in place of a restricted security, for example, common.
    /// </summary>
    [IsoId("2419af97-1aba-402a-8dd8-6ebdb7e90e4a")]
    [DisplayName("Alternate Security Type")]
    [IsoXmlTag("AltrnSctyTp")]
    public GenericIdentification1? AlternateSecurityType { get; init; }
}
