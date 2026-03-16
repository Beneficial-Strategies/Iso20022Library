// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to an original transaction
/// </summary>
[IsoId("_mdH0wOFLEeeL6cBQHtS6kw")]
[DisplayName("Original Transaction")]
public record OriginalTransaction1
{
    /// <summary>
    /// Details of the original message for which a retrieval is being requested.
    /// </summary>
    [IsoId("_21mIsOwQEeiMkKo2clXHdQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public Environment6? Environment { get; init; }

    /// <summary>
    /// Details of the original message for which a retrieval is being requested.
    /// </summary>
    [IsoId("_WZ384OwTEeiMkKo2clXHdQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context3? Context { get; init; }

    /// <summary>
    /// Contains the original transaction details.
    /// </summary>
    [IsoId("_vh7dIOFLEeeL6cBQHtS6kw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction85? Transaction { get; init; }

    /// <summary>
    /// Contains the processing results of the transaction to be retrieved.
    /// </summary>
    [IsoId("_bCcSgKZOEeiva6IOmhpVHw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult2? ProcessingResult { get; init; }
}
