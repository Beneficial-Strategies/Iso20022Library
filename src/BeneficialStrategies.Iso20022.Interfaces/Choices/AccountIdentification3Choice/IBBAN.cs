// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice;

/// <summary>
/// Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer.
/// </summary>
[IsoId("_PdnCp9p-Ed-ak6NoX_4Aeg_639037244")]
public interface IBBAN : IAccountIdentification3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Basic Bank Account Number (BBAN). Identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), which uniquely identifies the account of a customer.
    /// </summary>
    [IsoXmlTag("BBAN")]
    BBANIdentifier Value { get; }
}
