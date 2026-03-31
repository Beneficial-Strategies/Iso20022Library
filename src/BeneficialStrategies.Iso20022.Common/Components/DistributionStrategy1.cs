// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Distribution strategy criteria.
/// </summary>
[IsoId("_XogS0DcfEeidBoT_PugKiA")]
[DisplayName("Distribution Strategy")]
public record DistributionStrategy1
{
    /// <summary>
    /// Specifies to whom the product can be sold on an execution-only basis. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 06010.
    /// </summary>
    [IsoId("_gJ328DcfEeidBoT_PugKiA")]
    [DisplayName("Execution Only")]
    [IsoXmlTag("ExctnOnly")]
    public DistributionStrategy1Choice_? ExecutionOnly { get; init; }

    /// <summary>
    /// Specifies to whom the product can be sold with an appropriateness test or to a non-advised service. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 06020.
    /// </summary>
    [IsoId("_pbLDMDcfEeidBoT_PugKiA")]
    [DisplayName("Execution With Appropriateness Test Or Non Advised Services")]
    [IsoXmlTag("ExctnWthApprprtnssTstOrNonAdvsdSvcs")]
    public DistributionStrategy1Choice_? ExecutionWithAppropriatenessTestOrNonAdvisedServices { get; init; }

    /// <summary>
    /// Specifies to whom the product can be sold if investment advice has been provided. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 06030.
    /// </summary>
    [IsoId("_s0S7IDcfEeidBoT_PugKiA")]
    [DisplayName("Investment Advice")]
    [IsoXmlTag("InvstmtAdvc")]
    public DistributionStrategy1Choice_? InvestmentAdvice { get; init; }

    /// <summary>
    /// Specifies to whom the product can be sold if portfolio management has been provided. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 06040.
    /// </summary>
    [IsoId("_wMPuYDcfEeidBoT_PugKiA")]
    [DisplayName("Portfolio Management")]
    [IsoXmlTag("PrtflMgmt")]
    public DistributionStrategy1Choice_? PortfolioManagement { get; init; }

    /// <summary>
    /// Other distribution strategy.
    /// </summary>
    [IsoId("_zDR3kD8PEeih8-WNbS6hbA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherDistributionStrategy1? Other { get; init; }
}
