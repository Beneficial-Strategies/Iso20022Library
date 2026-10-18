// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ProxyAccountType1Choice;

/// <summary>
/// Name of the identification scheme, in a coded form as published in an external list.
/// </summary>
[IsoId("_dyoclXh3EeidzqjNEfehPg")]
public interface ICode : IProxyAccountType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the external proxy account type code, as published in the proxy account type external code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalProxyAccountType1Code Value { get; }
}
