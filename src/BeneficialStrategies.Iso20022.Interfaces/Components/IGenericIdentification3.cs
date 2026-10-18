// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, for example, party identification or account identification.
/// </summary>
[IsoId("_P-sWcdp-Ed-ak6NoX_4Aeg_1185673654")]
public interface IGenericIdentification3 : IIsoComponent
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    [IsoId("_P-sWctp-Ed-ak6NoX_4Aeg_1256785338")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    Max35Text Identification { get; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_P-sWc9p-Ed-ak6NoX_4Aeg_1555083105")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    Max35Text? Issuer { get; }
}
