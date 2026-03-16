// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of the certificate data set.
/// </summary>
[IsoId("_TnwH19p-Ed-ak6NoX_4Aeg_1225128644")]
[DisplayName("Required Submission")]
public record RequiredSubmission5
{
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    [IsoId("_TnwH2Np-Ed-ak6NoX_4Aeg_1225129107")]
    [DisplayName("Submitter")]
    [IsoXmlTag("Submitr")]
    public ValueList<BICIdentification1> Submitter { get; init; } = [];

    // ID for the above is _TnwH2Np-Ed-ak6NoX_4Aeg_1225129107

    /// <summary>
    /// Specifies the type of the certificate.
    /// </summary>
    [IsoId("_Tn5RwNp-Ed-ak6NoX_4Aeg_1225128736")]
    [DisplayName("Certificate Type")]
    [IsoXmlTag("CertTp")]
    public required TradeCertificateType2Code CertificateType { get; init; }
}
