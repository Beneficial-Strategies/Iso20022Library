// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The final result of a single invoice financing request.
/// </summary>
[IsoId("_TiFktdp-Ed-ak6NoX_4Aeg_1101123529")]
[DisplayName("Financing Result")]
public record FinancingResult1
{
    /// <summary>
    /// Specifies the status of the financing request (e.g. financed. not financed).
    /// </summary>
    [IsoId("_TiFkttp-Ed-ak6NoX_4Aeg_352221392")]
    [DisplayName("Financing Request Status")]
    [IsoXmlTag("FincgReqSts")]
    public required RequestStatus1Code FinancingRequestStatus { get; init; }

    /// <summary>
    /// Indicates the reasons that have determined the result of the single request.
    /// </summary>
    [IsoId("_TiFkt9p-Ed-ak6NoX_4Aeg_564525140")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReason4Choice_? StatusReason { get; init; }

    /// <summary>
    /// Further details on the status reason.
    /// </summary>
    [IsoId("_TiFkuNp-Ed-ak6NoX_4Aeg_-99752141")]
    [DisplayName("Additional Status Reason Information")]
    [IsoXmlTag("AddtlStsRsnInf")]
    public SimpleValueList<IsoMax105Text> AdditionalStatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Indicates amount financed related to the request.
    /// </summary>
    [IsoId("_TiOuoNp-Ed-ak6NoX_4Aeg_603605189")]
    [DisplayName("Financed Amount")]
    [IsoXmlTag("FincdAmt")]
    public FinancingRateOrAmountChoice_? FinancedAmount { get; init; }
}
