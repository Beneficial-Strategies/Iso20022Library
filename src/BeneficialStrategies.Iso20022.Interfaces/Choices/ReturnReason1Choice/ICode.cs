// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason1Choice;

/// <summary>
/// Reason for the return in a coded form.
/// </summary>
[IsoId("_TOkLyNp-Ed-ak6NoX_4Aeg_191375030")]
public interface ICode : IReturnReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
    /// </summary>
    [IsoXmlTag("Cd")]
    TransactionRejectReason2Code Value { get; }
}
