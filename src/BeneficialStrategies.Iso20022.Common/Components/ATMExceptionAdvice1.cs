// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to exceptions occurring on the ATM.
/// </summary>
[IsoId("_92OQAK5CEeWCgYcWSNgX5g")]
[DisplayName("ATM Exception Advice")]
public record ATMExceptionAdvice1
{
    /// <summary>
    /// Environment of the exception.
    /// </summary>
    [IsoId("_E_UZoK5DEeWCgYcWSNgX5g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public ATMEnvironment16? Environment { get; init; }

    /// <summary>
    /// Context of the exception.
    /// </summary>
    [IsoId("_3A3sUK5DEeWCgYcWSNgX5g")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public ATMContext20? Context { get; init; }

    /// <summary>
    /// Transaction for which the exception is sent.
    /// </summary>
    [IsoId("_F9ZgkK5FEeWCgYcWSNgX5g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction27 Transaction { get; init; }
}
