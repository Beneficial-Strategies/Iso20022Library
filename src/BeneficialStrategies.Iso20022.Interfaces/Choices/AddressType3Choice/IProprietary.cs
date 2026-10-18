// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AddressType3Choice;

/// <summary>
/// Type of address expressed as a proprietary code.
/// </summary>
[IsoId("_C7IDQxb-EeiyVv5j1vf1VQ")]
public interface IProprietary : IAddressType3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_P-Pqg9p-Ed-ak6NoX_4Aeg_-2101736418")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoExact4AlphaNumericText Identification { get; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_P-PqhNp-Ed-ak6NoX_4Aeg_1196158525")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    IsoMax35Text Issuer { get; }

    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_P-Pqhdp-Ed-ak6NoX_4Aeg_491043910")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    IsoMax35Text? SchemeName { get; }
}
