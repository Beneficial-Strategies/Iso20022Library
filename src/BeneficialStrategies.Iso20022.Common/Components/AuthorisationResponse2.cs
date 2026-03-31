// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an authorisation initiation message.
/// </summary>
[IsoId("_Fi1vQYdNEeuBS50MFjViNw")]
[DisplayName("Authorisation Response")]
public record AuthorisationResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_FoJGAYdNEeuBS50MFjViNw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment26 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_FoJGA4dNEeuBS50MFjViNw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context13? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_FoJGBYdNEeuBS50MFjViNw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction150 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_FoJGB4dNEeuBS50MFjViNw")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData4? AddendumData { get; init; }

    /// <summary>
    /// Outcome of processing of the authorisation.
    /// </summary>
    [IsoId("_FoJGCYdNEeuBS50MFjViNw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult10 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_FoJGC4dNEeuBS50MFjViNw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_FoJGDYdNEeuBS50MFjViNw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_FoJGD4dNEeuBS50MFjViNw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
