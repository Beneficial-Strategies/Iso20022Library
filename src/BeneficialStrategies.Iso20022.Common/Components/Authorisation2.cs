// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Autorisation of the mandate holder.
/// </summary>
[IsoId("_xZZNIw3wEeKGXqvMN6jpiw")]
[DisplayName("Authorisation")]
public record Authorisation2
{
    /// <summary>
    /// Maximum amount allowed by the mandate for each transaction.
    /// </summary>
    [IsoId("_xujkxQ3wEeKGXqvMN6jpiw")]
    [DisplayName("Maximum Amount By Transaction")]
    [IsoXmlTag("MaxAmtByTx")]
    public FixedAmountOrUnlimited1Choice_? MaximumAmountByTransaction { get; init; }

    /// <summary>
    /// Maximum amount allowed over a specific period of time.
    /// </summary>
    [IsoId("_xujkyQ3wEeKGXqvMN6jpiw")]
    [DisplayName("Maximum Amount By Period")]
    [IsoXmlTag("MaxAmtByPrd")]
    public ValueList<MaximumAmountByPeriod1> MaximumAmountByPeriod { get; init; } = [];

    /// <summary>
    /// Specifies the maximum amount for each bulk submission.
    /// </summary>
    [IsoId("_RK4zUA3yEeKGXqvMN6jpiw")]
    [DisplayName("Maximum Amount By Bulk Submission")]
    [IsoXmlTag("MaxAmtByBlkSubmissn")]
    public FixedAmountOrUnlimited1Choice_? MaximumAmountByBulkSubmission { get; init; }
}
