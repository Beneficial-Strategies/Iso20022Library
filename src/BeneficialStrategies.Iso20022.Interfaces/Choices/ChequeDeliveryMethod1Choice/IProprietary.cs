// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ChequeDeliveryMethod1Choice;

/// <summary>
/// Specifies a proprietary delivery method of the cheque by the debtor&apos;s agent.
/// </summary>
[IsoId("_QbwF6Np-Ed-ak6NoX_4Aeg_1076475245")]
public interface IProprietary : IChequeDeliveryMethod1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
