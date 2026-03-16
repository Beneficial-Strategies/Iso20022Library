// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of an inquiry from an ATM.
/// </summary>
[IsoId("_VMLYsa4VEeW_TaP-ygI0SQ")]
[DisplayName("ATM Inquiry Request")]
public record ATMInquiryRequest2
{
    /// <summary>
    /// Environment in which the inquiry is performed.
    /// </summary>
    [IsoId("_VYPewa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment14 Environment { get; init; }

    /// <summary>
    /// Context in which the inquiry is performed.
    /// </summary>
    [IsoId("_VYPew64VEeW_TaP-ygI0SQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext14 Context { get; init; }

    /// <summary>
    /// Inquiry information for the transaction.
    /// </summary>
    [IsoId("_VYPexa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction29 Transaction { get; init; }
}
