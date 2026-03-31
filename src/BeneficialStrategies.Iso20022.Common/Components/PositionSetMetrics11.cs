// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets.
/// </summary>
[IsoId("_MVJnAa5REeuo-IflVgGqiA")]
[DisplayName("Position Set Metrics")]
public record PositionSetMetrics11
{
    /// <summary>
    /// Numeric variables calculated on the number of transactions or on market exposures.
    /// </summary>
    [IsoId("_Mkfqka5REeuo-IflVgGqiA")]
    [DisplayName("Volume Metrics")]
    [IsoXmlTag("VolMtrcs")]
    public VolumeMetrics4? VolumeMetrics { get; init; }

    /// <summary>
    /// Average interest rate received on cash collateral reinvestment by the lender for reinvestment of cash collateral.
    /// </summary>
    [IsoId("_Mkfqk65REeuo-IflVgGqiA")]
    [DisplayName("Cash Reinvestment Rate")]
    [IsoXmlTag("CshRinvstmtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CashReinvestmentRate { get; init; }
}
