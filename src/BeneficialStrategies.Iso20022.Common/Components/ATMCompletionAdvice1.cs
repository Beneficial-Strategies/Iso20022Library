// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the completion of an operation on the ATM.
/// </summary>
[IsoId("_wLvg4IqmEeS4a4abTJTSSw")]
[DisplayName("ATM Completion Advice")]
public record ATMCompletionAdvice1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_DHGXoIqnEeS4a4abTJTSSw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment3 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_U5uEsIqnEeS4a4abTJTSSw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext3 Context { get; init; }

    /// <summary>
    /// Transaction for which the completion is sent.
    /// </summary>
    [IsoId("_K42AMIqoEeS4a4abTJTSSw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction5 Transaction { get; init; }
}
