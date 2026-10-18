// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the documents referred to in the remittance information.
/// </summary>
[IsoId("_1QJJIabjEeKvUvwX_r3tzA")]
public interface IDocumentLineIdentification1 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of referred document line identification.
    /// </summary>
    [IsoId("_1Z0plabjEeKvUvwX_r3tzA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IDocumentLineType1? Type { get; }

    /// <summary>
    /// Identification of the type specified for the referred document line.
    /// </summary>
    [IsoId("_1Z0pmabjEeKvUvwX_r3tzA")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    IsoMax35Text? Number { get; }

    /// <summary>
    /// Date associated with the referred document line.
    /// </summary>
    [IsoId("_1Z0pnabjEeKvUvwX_r3tzA")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    IsoISODate? RelatedDate { get; }
}
