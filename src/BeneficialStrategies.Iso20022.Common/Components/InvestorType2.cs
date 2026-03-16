// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investor for which a financial instrument is targeted.
/// </summary>
[IsoId("_Si1WsbSaEeq-6ssAXwSh-g")]
[DisplayName("Investor Type")]
public record InvestorType2
{
    /// <summary>
    /// Specifies whether the product is aimed at the retail investor. If neutral, the manufacturer estimates that there is neither a negative nor a positive target market. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01010.
    /// </summary>
    [IsoId("_S3OSUbSaEeq-6ssAXwSh-g")]
    [DisplayName("Investor Type Retail")]
    [IsoXmlTag("InvstrTpRtl")]
    public TargetMarket1Code? InvestorTypeRetail { get; init; }

    /// <summary>
    /// Specifies how the product is aimed at the professional investor. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01020.
    /// </summary>
    [IsoId("_S3OSU7SaEeq-6ssAXwSh-g")]
    [DisplayName("Investor Type Professional")]
    [IsoXmlTag("InvstrTpPrfssnl")]
    public TargetMarket5Choice_? InvestorTypeProfessional { get; init; }

    /// <summary>
    /// Specifies whether the product is aimed at the eligible counterparty. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01030.
    /// </summary>
    [IsoId("_S3OSVbSaEeq-6ssAXwSh-g")]
    [DisplayName("Investor Type Eligible Counterparty")]
    [IsoXmlTag("InvstrTpElgblCtrPty")]
    public TargetMarket3Code? InvestorTypeEligibleCounterparty { get; init; }

    /// <summary>
    /// Specifies another investor type.
    /// </summary>
    [IsoId("_S3OSV7SaEeq-6ssAXwSh-g")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherTargetMarketInvestor1? Other { get; init; }
}
