// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the ATM.
/// </summary>
[IsoId("_-clJMYtqEeSDLd7nI4Quzw")]
[DisplayName("ATM Environment")]
public record ATMEnvironment9
{
    /// <summary>
    /// Acquirer of the ATM transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_-pPsMYtqEeSDLd7nI4Quzw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; }

    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_-pPsM4tqEeSDLd7nI4Quzw")]
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMManagerIdentification { get; init; }

    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_-pPsN4tqEeSDLd7nI4Quzw")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine7 ATM { get; init; }
}
