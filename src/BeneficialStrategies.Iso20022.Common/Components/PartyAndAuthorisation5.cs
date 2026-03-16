// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and related authorisation.
/// </summary>
[IsoId("_LH4RU249EeiU9cctagi5ow")]
[DisplayName("Party And Authorisation")]
public record PartyAndAuthorisation5
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_LUGvYW49EeiU9cctagi5ow")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Specifies a party or a group of parties.
    /// </summary>
    [IsoId("_LUGvY249EeiU9cctagi5ow")]
    [DisplayName("Party Or Group")]
    [IsoXmlTag("PtyOrGrp")]
    public required PartyOrGroup2Choice_ PartyOrGroup { get; init; }

    /// <summary>
    /// Order in which the mandate holder has to sign.
    /// </summary>
    [IsoId("_LUGvZW49EeiU9cctagi5ow")]
    [DisplayName("Signature Order")]
    [IsoXmlTag("SgntrOrdr")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    public IsoMax15PlusSignedNumericText? SignatureOrder { get; init; }

    /// <summary>
    /// Authorisation granted to a mandate holder.
    /// </summary>
    [IsoId("_LUGvZ249EeiU9cctagi5ow")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public required Authorisation2 Authorisation { get; init; }
}
