// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a financial instrument contract type.
/// </summary>
[IsoId("_Z5cVsExCEeywvc16MwOPfw")]
[DisplayName("Compare Financial Instrument Contract Type")]
public record CompareFinancialInstrumentContractType1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_oUfqAExCEeywvc16MwOPfw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public FinancialInstrumentContractType2Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_rQ4ioExCEeywvc16MwOPfw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public FinancialInstrumentContractType2Code? Value2 { get; init; }
}
