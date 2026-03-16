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
[IsoId("_FihUIE9MEeeg87n1YQSQ_A")]
[DisplayName("Authorisation Response")]
public record AuthorisationResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ZBCiUE9MEeeg87n1YQSQ_A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment2 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_Mr5HkE9tEeePXdaAO32Uew")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context2? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_Ye6psE9tEeePXdaAO32Uew")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction78 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_3SaDMP5pEeiLerArw36g0w")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData2? AddendumData { get; init; }

    /// <summary>
    /// Outcome of processing of the authorisation.
    /// </summary>
    [IsoId("_3GmIME9uEeePXdaAO32Uew")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult2 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("__RPOYE9uEeePXdaAO32Uew")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_f582EdXvEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_UA74UaK4EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
