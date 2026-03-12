// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the certification format required.
    /// </summary>
    [KnownType(typeof(CertificationTypeFormat1Choice.Code))]
    [KnownType(typeof(CertificationTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(CertificationTypeFormat1Choice.Code),nameof(CertificationTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(CertificationTypeFormat1Choice.Proprietary),nameof(CertificationTypeFormat1Choice.Proprietary))]
    [IsoId("_Q3BFl9p-Ed-ak6NoX_4Aeg_-917118670")]
    [DisplayName("Certification Type Format 1 Choice")]
    public abstract partial record CertificationTypeFormat1Choice_
    {
    }
}
