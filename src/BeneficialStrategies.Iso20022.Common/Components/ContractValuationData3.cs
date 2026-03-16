// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract valuation.
/// </summary>
[IsoId("_Ku5_KZRwEeaIOYt3E5eJjQ")]
[DisplayName("Contract Valuation Data")]
public record ContractValuationData3
{
    /// <summary>
    /// Mark to market valuation of the contract, or mark to model valuation. The CCP’s valuation to be used for a cleared trade.
    /// </summary>
    [IsoId("_K5e3cZRwEeaIOYt3E5eJjQ")]
    [DisplayName("Contract Value")]
    [IsoXmlTag("CtrctVal")]
    public AmountAndDirection54? ContractValue { get; init; }

    /// <summary>
    /// Date and time of the last valuation.
    /// Usage: For mark-to-market valuation the date and time of publishing of reference prices shall be reported.
    /// </summary>
    [IsoId("_K5e3c5RwEeaIOYt3E5eJjQ")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TimeStamp { get; init; }

    /// <summary>
    /// Indicate whether valuation was performed mark to market, mark to model or provided by the CCP.
    /// </summary>
    [IsoId("_K5e3dZRwEeaIOYt3E5eJjQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValuationType1Code? Type { get; init; }
}
