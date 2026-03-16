// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Application specific information defined by the service provider.
/// </summary>
[IsoId("_jLluUe5NEeCisYr99QEiWA_17771453")]
[DisplayName("Application Specifics")]
public record ApplicationSpecifics1
{
    /// <summary>
    /// A system user is a user account defined in the static data. It represents an individual or an application that interacts with the system administrator (e. g. T2S), triggering the available functions. The set of functions available to each system user stems from the set of privileges for which the system user is grantee. System administrator does not provide any attribute for distinguishing between individuals and applications.
    /// </summary>
    [IsoId("_hdq1QWliEeGaMcKyqKNRfQ_64695608")]
    [DisplayName("System User")]
    [IsoXmlTag("SysUsr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SystemUser { get; init; }

    /// <summary>
    /// Contains the digital signature of the Business Entity authorised to sign this Business File.
    /// </summary>
    [IsoId("_hdq1QmliEeGaMcKyqKNRfQ_1022556874")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public SignatureEnvelope? Signature { get; init; }

    /// <summary>
    /// Gives the total number of instances (messages) within the file.
    /// </summary>
    [IsoId("_jLluUu5NEeCisYr99QEiWA_1016478772")]
    [DisplayName("Total Number Of Documents")]
    [IsoXmlTag("TtlNbOfDocs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TotalNumberOfDocuments { get; init; }
}
