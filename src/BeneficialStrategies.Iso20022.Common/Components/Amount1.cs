// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin amount payable by one party to the other party.
/// </summary>
[IsoId("_Ul4kBtp-Ed-ak6NoX_4Aeg_-2038049081")]
[DisplayName("Amount")]
public record Amount1
{
    /// <summary>
    /// Undisputed amount of the margin call request.
    /// </summary>
    [IsoId("_Ul4kB9p-Ed-ak6NoX_4Aeg_-1514098340")]
    [DisplayName("Agreed Amount")]
    [IsoXmlTag("AgrdAmt")]
    public required ActiveCurrencyAndAmount AgreedAmount { get; init; }

    /// <summary>
    /// Unique identifier for the margin call request.
    /// </summary>
    [IsoId("_UmCVANp-Ed-ak6NoX_4Aeg_419184137")]
    [DisplayName("Margin Call Request Identification")]
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MarginCallRequestIdentification { get; init; }

    /// <summary>
    /// Provides additional information related to the margin call amount that has been agreed.
    /// </summary>
    [IsoId("_UmCVAdp-Ed-ak6NoX_4Aeg_-131236975")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalInformation { get; init; }
}
