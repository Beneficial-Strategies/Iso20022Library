// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.StatusReason6Choice;

/// <summary>
/// Reason for the status, as published in an external reason code list.
/// </summary>
[IsoId("_TRGiZ9p-Ed-ak6NoX_4Aeg_-1877638996")]
public interface ICode : IStatusReason6Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the status reason, as published in an external status reason code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalStatusReason1Code Value { get; }
}
