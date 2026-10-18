// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, eg, party identification or account identification.
/// </summary>
[IsoId("_P-sWdNp-Ed-ak6NoX_4Aeg_-1687943043")]
public interface IGenericIdentification4 : IIsoComponent
{
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    [IsoId("_P-sWddp-Ed-ak6NoX_4Aeg_-1304682662")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax35Text Identification { get; }

    /// <summary>
    /// Specifies the nature of the identifier.|Usage: IdentificationType is used to specify what kind of identifier is used. It should be used in case the identifier is different from the identifiers listed in the pre-defined identifier list.
    /// </summary>
    [IsoId("_P-sWdtp-Ed-ak6NoX_4Aeg_-1601134417")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    IsoMax35Text IdentificationType { get; }
}
