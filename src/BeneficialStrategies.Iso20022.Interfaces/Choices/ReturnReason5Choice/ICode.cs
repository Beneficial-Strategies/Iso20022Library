// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice;

/// <summary>
/// Reason for the return, as published in an external reason code list.
/// </summary>
[IsoId("_TP6Pktp-Ed-ak6NoX_4Aeg_-1676326035")]
public interface ICode : IReturnReason5Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the return reason, as published in an external return reason code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalReturnReason1Code Value { get; }
}
