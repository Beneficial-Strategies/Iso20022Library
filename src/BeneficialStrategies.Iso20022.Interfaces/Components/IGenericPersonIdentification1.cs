// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification of a person.
/// </summary>
[IsoId("_P_4pRtp-Ed-ak6NoX_4Aeg_-893603485")]
public interface IGenericPersonIdentification1 : IIsoComponent
{
    /// <summary>
    /// Unique and unambiguous identification of a person.
    /// </summary>
    [IsoId("_P_4pR9p-Ed-ak6NoX_4Aeg_-740298453")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax35Text Identification { get; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_QACaQNp-Ed-ak6NoX_4Aeg_2131347934")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    IPersonIdentificationSchemeName1Choice? SchemeName { get; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_QACaQdp-Ed-ak6NoX_4Aeg_-740298392")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    IsoMax35Text? Issuer { get; }
}
