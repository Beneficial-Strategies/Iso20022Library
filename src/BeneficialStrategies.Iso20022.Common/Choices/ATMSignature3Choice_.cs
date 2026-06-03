// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element containing the signature.
    /// </summary>
    [KnownType(typeof(ATMSignature3Choice.DigitalSignature))]
    [KnownType(typeof(ATMSignature3Choice.TRRelatedData))]
    [JsonDerivedType(typeof(ATMSignature3Choice.DigitalSignature), nameof(ATMSignature3Choice.DigitalSignature))]
    [JsonDerivedType(typeof(ATMSignature3Choice.TRRelatedData), nameof(ATMSignature3Choice.TRRelatedData))]
    [IsoId("_Aa2d8cPzEfCTf8R2j0RpdQ")]
    [DisplayName("ATMSignature3Choice")]
    public abstract record ATMSignature3Choice_ { }
}
