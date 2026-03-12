// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the certificate type.
    /// </summary>
    [KnownType(typeof(CertificationType1Choice.Code))]
    [KnownType(typeof(CertificationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(CertificationType1Choice.Code),nameof(CertificationType1Choice.Code))]
    [JsonDerivedType(typeof(CertificationType1Choice.Proprietary),nameof(CertificationType1Choice.Proprietary))]
    [IsoId("_c49DwxdEEeK5g-3oYI0_9Q")]
    [DisplayName("Certification Type 1 Choice")]
    public abstract partial record CertificationType1Choice_
    {
    }
}
