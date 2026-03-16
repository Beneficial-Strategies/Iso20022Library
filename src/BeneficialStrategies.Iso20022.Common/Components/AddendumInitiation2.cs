// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum message is used in conjunction with an authorisation or financial message to provide supplemental data above that required to complete an authorisation initiation or financial initiation.
/// </summary>
[IsoId("_RtF34YdIEeuBS50MFjViNw")]
[DisplayName("Addendum Initiation")]
public record AddendumInitiation2
{
    /// <summary>
    /// Contains or describes the information pertaining to the actors interacting with the transaction.
    /// </summary>
    [IsoId("_RyTIAYdIEeuBS50MFjViNw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment30 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_RyTIA4dIEeuBS50MFjViNw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_RyTIBYdIEeuBS50MFjViNw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction148 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_RyTIB4dIEeuBS50MFjViNw")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public required AddendumData3 AddendumData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_RyTICYdIEeuBS50MFjViNw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_RyTIC4dIEeuBS50MFjViNw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
