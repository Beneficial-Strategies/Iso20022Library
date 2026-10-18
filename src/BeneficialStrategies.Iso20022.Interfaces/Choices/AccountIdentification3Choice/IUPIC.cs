// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice;

/// <summary>
/// Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
/// </summary>
[IsoId("_PdnCqNp-Ed-ak6NoX_4Aeg_639959793")]
public interface IUPIC : IAccountIdentification3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Universal Payment Identification Code (UPIC). Identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
    /// </summary>
    [IsoXmlTag("UPIC")]
    IsoUPICIdentifier Value { get; }
}
