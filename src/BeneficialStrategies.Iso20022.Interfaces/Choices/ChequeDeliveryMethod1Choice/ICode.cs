// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ChequeDeliveryMethod1Choice;

/// <summary>
/// Specifies the delivery method of the cheque by the debtor&apos;s agent.
/// </summary>
[IsoId("_QbwF59p-Ed-ak6NoX_4Aeg_1044150030")]
public interface ICode : IChequeDeliveryMethod1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the method to be used in delivering a cheque to a party.
    /// </summary>
    [IsoXmlTag("Cd")]
    ChequeDelivery1Code Value { get; }
}
