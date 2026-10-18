// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReversalReason1Choice;

/// <summary>
/// Reason for the reversal in a coded form.
/// </summary>
[IsoId("_TPTypNp-Ed-ak6NoX_4Aeg_1404293985")]
public interface ICode : IReversalReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the reason for a transaction to be reversed by an instructed agent or somebody acting on behalf of an instructed agent.
    /// </summary>
    [IsoXmlTag("Cd")]
    TransactionReversalReason1Code Value { get; }
}
