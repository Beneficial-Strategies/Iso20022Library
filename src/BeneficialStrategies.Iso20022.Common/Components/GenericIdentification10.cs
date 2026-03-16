// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the identification of an individual person.
/// </summary>
[IsoId("_QAVVMtp-Ed-ak6NoX_4Aeg_-1527540623")]
[DisplayName("Generic Identification")]
public record GenericIdentification10
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_QAVVM9p-Ed-ak6NoX_4Aeg_-1520154884")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the nature of the identification.
    /// </summary>
    [IsoId("_QAVVNNp-Ed-ak6NoX_4Aeg_-1520154824")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required PersonIdentificationType1Code IdentificationType { get; init; }

    /// <summary>
    /// Specifies the nature of the identification.
    /// </summary>
    [IsoId("_QAVVNdp-Ed-ak6NoX_4Aeg_-1520154729")]
    [DisplayName("Extended Identification Type")]
    [IsoXmlTag("XtndedIdTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedIdentificationType { get; init; }
}
