// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_PXDuuNp-Ed-ak6NoX_4Aeg_818704056")]
[DisplayName("Party And Certificate")]
public record PartyAndCertificate1
{
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_PXM4oNp-Ed-ak6NoX_4Aeg_2106416666")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification41 Party { get; init; }

    /// <summary>
    /// Security certificate used to sign electronically.
    /// </summary>
    [IsoId("_PXM4odp-Ed-ak6NoX_4Aeg_1578430719")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? Certificate { get; init; }

    /// <summary>
    /// Order in which the mandate holder has to sign.
    /// </summary>
    [IsoId("_PXM4otp-Ed-ak6NoX_4Aeg_880566094")]
    [DisplayName("Signature Order")]
    [IsoXmlTag("SgntrOrdr")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    public IsoMax15PlusSignedNumericText? SignatureOrder { get; init; }

    /// <summary>
    /// Authorisation granted to a mandate holder.
    /// </summary>
    [IsoId("_PXM4o9p-Ed-ak6NoX_4Aeg_637414510")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public required Authorisation1 Authorisation { get; init; }
}
