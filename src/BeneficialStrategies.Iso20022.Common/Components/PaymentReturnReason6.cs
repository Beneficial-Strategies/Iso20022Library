// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the return of the transaction.
/// </summary>
[IsoId("_I5-c23L_EeidQ_AAdEzxQA")]
[DisplayName("Payment Return Reason")]
public record PaymentReturnReason6
{
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_JEjVJXL_EeidQ_AAdEzxQA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_JEjVJ3L_EeidQ_AAdEzxQA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_JEjVKXL_EeidQ_AAdEzxQA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; }
}
