// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a contract valuation.
/// </summary>
[IsoId("_L1MIEExTEeywvc16MwOPfw")]
[DisplayName("Valuation Matching Criteria")]
public record ValuationMatchingCriteria1
{
    /// <summary>
    /// Specifies whether the information on the contract values are matching or not.
    /// </summary>
    [IsoId("_ZiXpwExTEeywvc16MwOPfw")]
    [DisplayName("Contract Value")]
    [IsoXmlTag("CtrctVal")]
    public CompareAmountAndDirection3? ContractValue { get; init; }

    /// <summary>
    /// Specifies whether the information on the valuation methods are matching or not.
    /// </summary>
    [IsoId("_POV_wExUEeywvc16MwOPfw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CompareValuationType1? Type { get; init; }
}
