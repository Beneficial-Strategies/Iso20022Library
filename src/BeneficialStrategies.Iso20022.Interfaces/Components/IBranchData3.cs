// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific branch of a financial institution.
/// </summary>
[IsoId("_-2V8QW4-EeiU9cctagi5ow")]
public interface IBranchData3 : IIsoComponent
{
    /// <summary>
    /// Unique and unambiguous identification of a branch of a financial institution.
    /// </summary>
    [IsoId("__CsWM24-EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax35Text? Identification { get; }

    /// <summary>
    /// Legal entity identification for the branch of the financial institution.
    /// </summary>
    [IsoId("_mxjV8XRyEeiH1ZOt2UD8vQ")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    IsoLEIIdentifier? LEI { get; }

    /// <summary>
    /// Name by which an agent is known and which is usually used to identify that agent.
    /// </summary>
    [IsoId("__CsWNW4-EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("__CsWN24-EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress24? PostalAddress { get; }
}
