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
[IsoId("_lejCIDcKEeiIxKQErQxblg")]
[DisplayName("Investor Type")]
public record InvestorType1
{
    /// <summary>
    /// Specifies whether the product is aimed at the retail investor. If neutral, the manufacturer estimates that there is neither a negative nor a positive target market. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01010.
    /// </summary>
    [IsoId("_pMSfMTcKEeiIxKQErQxblg")]
    [DisplayName("Investor Type Retail")]
    [IsoXmlTag("InvstrTpRtl")]
    public TargetMarket1Code? InvestorTypeRetail { get; init; }

    /// <summary>
    /// Specifies how the product is aimed at the professional investor. If neutral, the manufacturer estimates that there is neither a negative nor a positive target market. Professional per se or elective professional should only be used if the distinction is done in the prospectus. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01020.
    /// </summary>
    [IsoId("_J9RB8DcLEeiIxKQErQxblg")]
    [DisplayName("Investor Type Professional")]
    [IsoXmlTag("InvstrTpPrfssnl")]
    public TargetMarket4Choice_? InvestorTypeProfessional { get; init; }

    /// <summary>
    /// Specifies whether the product is aimed at the eligible counterparty. If neutral, the manufacturer estimates that there is neither a negative nor a positive target market. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01030.
    /// </summary>
    [IsoId("_qrEKUTcKEeiIxKQErQxblg")]
    [DisplayName("Investor Type Eligible Counterparty")]
    [IsoXmlTag("InvstrTpElgblCtrPty")]
    public TargetMarket1Code? InvestorTypeEligibleCounterparty { get; init; }

    /// <summary>
    /// Specifies another investor type.
    /// </summary>
    [IsoId("_3ng9MDcLEeiIxKQErQxblg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherTargetMarketInvestor1> Other { get; init; } = [];
}
