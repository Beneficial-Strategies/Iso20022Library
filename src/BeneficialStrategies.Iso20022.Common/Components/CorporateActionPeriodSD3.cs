// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details periods details.
/// </summary>
[IsoId("_qdhPgb5WEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Period SD")]
public record CorporateActionPeriodSD3
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_qvODgb5WEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Period during which the securities can be submitted to reorganisation deposit service at DTC (The Depository Trust Corporation). DTC &quot;first day for reorganisation deposit&quot; (start date) is the day on which security is eligible for reorganisation deposit service at DTC. DTC &quot;last day for reorganisation deposit&quot; is the last day on which securities are eligible to be submitted for reorganisation deposit service at DTC.
    /// </summary>
    [IsoId("_qvODg75WEeexmbB7KsjCwA")]
    [DisplayName("DTC Reorganisation Deposit Period")]
    [IsoXmlTag("DTCReorgDpstPrd")]
    public Period13? DTCReorganisationDepositPeriod { get; init; }
}
