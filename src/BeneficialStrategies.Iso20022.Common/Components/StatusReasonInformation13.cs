// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status reason of the transaction.
/// </summary>
[IsoId("_zyR4BaX_EeynsLtPxJMJTQ")]
[DisplayName("Status Reason Information13")]
public record StatusReasonInformation13
{
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_zyR4CaX_EeynsLtPxJMJTQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required StatusReason7Choice_ Reason { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_A8MUkKYAEeynsLtPxJMJTQ")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public SecurityIdentification19? FinancialInstrument { get; init; }

    /// <summary>
    /// Further details on the status reason.
    /// </summary>
    [IsoId("_zyR4CKX_EeynsLtPxJMJTQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
