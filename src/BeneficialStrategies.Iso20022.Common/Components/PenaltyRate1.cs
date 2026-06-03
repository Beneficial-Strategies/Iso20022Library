// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the penalty rate data if the securities is subject to penalties.
/// </summary>
[IsoId("_8Ch2YDkZEem897H7zB2RJg")]
[DisplayName("Penalty Rate1")]
public record PenaltyRate1
{
    /// <summary>
    /// Place of trade of the related transaction.
    /// </summary>
    [IsoId("_DozrQDkaEem897H7zB2RJg")]
    [DisplayName("Market Identification")]
    [IsoXmlTag("MktId")]
    public MarketIdentification1Choice_? MarketIdentification { get; init; }

    /// <summary>
    /// Binary classification whether the security was traded in a SME Growth Market or not.
    /// </summary>
    [IsoId("_PRiB4DkaEem897H7zB2RJg")]
    [DisplayName("SME Growth Market")]
    [IsoXmlTag("SMEGrwthMkt")]
    public IsoTrueFalseIndicator? SMEGrowthMarket { get; init; }

    /// <summary>
    /// Penalty rate applicable for the asset type.
    /// </summary>
    [IsoId("_UC1NsDkaEem897H7zB2RJg")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public required IsoPercentageRate Rate { get; init; }
}
