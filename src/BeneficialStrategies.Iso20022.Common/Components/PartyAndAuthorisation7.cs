// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party And Authorisation7.
/// </summary>
[IsoId("_1UGpETEyEe6g-ffJsqGiSA")]
[DisplayName("Party And Authorisation7")]
public record PartyAndAuthorisation7
{
    /// <summary>
    /// Authorisation.
    /// </summary>
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public required Authorisation2 Authorisation { get; init; }

    /// <summary>
    /// Party Or Group.
    /// </summary>
    [DisplayName("Party Or Group")]
    [IsoXmlTag("PtyOrGrp")]
    public required PartyOrGroup3Choice_ PartyOrGroup { get; init; }

    /// <summary>
    /// Signature Order.
    /// </summary>
    [DisplayName("Signature Order")]
    [IsoXmlTag("SgntrOrdr")]
    public IsoMax15PlusSignedNumericText? SignatureOrder { get; init; }
}
