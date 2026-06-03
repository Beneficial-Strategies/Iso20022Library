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
[IsoId("55352a29-aa1a-467b-8ab8-43ee5a0afa99")]
[DisplayName("Financial Instrument Identification8")]
public record FinancialInstrumentIdentification8
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("a9536aac-e499-46f8-a091-eccca461a5c6")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification46Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("1cfbf440-58c0-441b-8090-b1a434798ee7")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("c34a5aec-ff0e-42a3-9113-35e54e35a5a1")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Type of security.
    /// </summary>
    [IsoId("fff82049-432a-44af-a3bf-21c84574db68")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Indicates whether the security is a restricted security.
    /// </summary>
    [IsoId("a84909b7-cdc7-4d74-a681-87cb6766602c")]
    [DisplayName("Restricted Indicator")]
    [IsoXmlTag("RstrctdInd")]
    public IsoYesNoIndicator? RestrictedIndicator { get; init; }

    /// <summary>
    /// Alternative security offered in place of a restricted security.
    /// </summary>
    [IsoId("df9edcbe-aa96-4588-b1b8-a26c9ab1f1f8")]
    [DisplayName("Alternate Security")]
    [IsoXmlTag("AltrnScty")]
    public ValueList<FinancialInstrumentIdentification9> AlternateSecurity { get; init; } = [];
}
