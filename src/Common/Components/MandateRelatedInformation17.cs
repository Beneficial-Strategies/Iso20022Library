// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Related Information17.
/// </summary>
[IsoId("_VPXPQZ9qEe-nbM0aSPcoiQ")]
[DisplayName("Mandate Related Information17")]
public partial record MandateRelatedInformation17
{
    /// <summary>
    /// Mandate Identification.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public required Max35Text MandateIdentification { get; init; }

    /// <summary>
    /// Date Of Signature.
    /// </summary>
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    public ISODate? DateOfSignature { get; init; }

    /// <summary>
    /// Mandate Image.
    /// </summary>
    [DisplayName("Mandate Image")]
    [IsoXmlTag("MndtImg")]
    public Max2MBBinary? MandateImage { get; init; }

    /// <summary>
    /// Protected Mandate Image.
    /// </summary>
    [DisplayName("Protected Mandate Image")]
    [IsoXmlTag("PrtctdMndtImg")]
    public ContentInformationType39? ProtectedMandateImage { get; init; }
}
