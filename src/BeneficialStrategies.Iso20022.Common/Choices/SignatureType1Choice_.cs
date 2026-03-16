// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the signature type.
    /// </summary>
    [KnownType(typeof(SignatureType1Choice.Code))]
    [KnownType(typeof(SignatureType1Choice.Proprietary))]
    [JsonDerivedType(typeof(SignatureType1Choice.Code), nameof(SignatureType1Choice.Code))]
    [JsonDerivedType(
        typeof(SignatureType1Choice.Proprietary),
        nameof(SignatureType1Choice.Proprietary)
    )]
    [IsoId("_k8doQDoHEeabspMEjqY5TQ")]
    [DisplayName("Signature Type 1 Choice")]
    public abstract record SignatureType1Choice_ { }
}
