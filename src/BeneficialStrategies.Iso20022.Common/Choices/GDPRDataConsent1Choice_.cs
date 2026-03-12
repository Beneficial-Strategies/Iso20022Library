// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of consent.
    /// </summary>
    [KnownType(typeof(GDPRDataConsent1Choice.Code))]
    [KnownType(typeof(GDPRDataConsent1Choice.Proprietary))]
    [JsonDerivedType(typeof(GDPRDataConsent1Choice.Code),nameof(GDPRDataConsent1Choice.Code))]
    [JsonDerivedType(typeof(GDPRDataConsent1Choice.Proprietary),nameof(GDPRDataConsent1Choice.Proprietary))]
    [IsoId("_His4MJTTEemC09f0MxYkRg")]
    [DisplayName("GDPR Data Consent 1 Choice")]
    public abstract partial record GDPRDataConsent1Choice_
    {
    }
}
