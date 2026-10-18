// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice;

/// <summary>
/// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
/// </summary>
[IsoId("_TFehN9p-Ed-ak6NoX_4Aeg_1156630060")]
public interface IBIC : IFinancialInstitutionIdentification5Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoXmlTag("BIC")]
    BICIdentifier Value { get; }
}
