// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of the certificate data set.
/// </summary>
[IsoId("_7keh8QgIEeSeS5xdjFfOTw")]
[DisplayName("Required Submission")]
public partial record RequiredSubmission6
{
    #nullable enable
    
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    [IsoId("_77-b8QgIEeSeS5xdjFfOTw")]
    [DisplayName("Submitter")]
    [IsoXmlTag("Submitr")]
    public ValueList<BICIdentification1> Submitter { get; init; } = [];
    // ID for the above is _77-b8QgIEeSeS5xdjFfOTw
    
    /// <summary>
    /// Specifies the type of the certificate, in 4 letters, for example BENE for beneficiary certificate, SHIP for shipping line certifcate.
    /// </summary>
    [IsoId("_77-b8wgIEeSeS5xdjFfOTw")]
    [DisplayName("Certificate Type")]
    [IsoXmlTag("CertTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText CertificateType { get; init; } 
    
    /// <summary>
    /// Description of the certificate type required.
    /// </summary>
    [IsoId("_klV3QAgJEeSeS5xdjFfOTw")]
    [DisplayName("Certificate Type Description")]
    [IsoXmlTag("CertTpDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text CertificateTypeDescription { get; init; } 
    
    
    #nullable disable
    
}
