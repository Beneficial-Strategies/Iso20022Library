// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DocumentType1Choice;

/// <summary>
/// Document type, in a proprietary form.
/// </summary>
[IsoId("_iYH70XiJEeidzqjNEfehPg")]
public interface IProprietary : IDocumentType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    [IsoId("_QALkONp-Ed-ak6NoX_4Aeg_-1748202217")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax35Text Identification { get; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_QAVVMNp-Ed-ak6NoX_4Aeg_-1748202215")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    IsoMax35Text? SchemeName { get; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_QAVVMdp-Ed-ak6NoX_4Aeg_-1748202216")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    IsoMax35Text? Issuer { get; }
}
