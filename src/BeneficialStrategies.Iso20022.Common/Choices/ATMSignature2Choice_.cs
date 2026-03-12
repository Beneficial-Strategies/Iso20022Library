// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element containing the signature.
    /// </summary>
    [KnownType(typeof(ATMSignature2Choice.DigitalSignature))]
    [KnownType(typeof(ATMSignature2Choice.TRRelatedData))]
    [JsonDerivedType(typeof(ATMSignature2Choice.DigitalSignature),nameof(ATMSignature2Choice.DigitalSignature))]
    [JsonDerivedType(typeof(ATMSignature2Choice.TRRelatedData),nameof(ATMSignature2Choice.TRRelatedData))]
    [IsoId("_h8fS4bTwEeeQy4o2AayYHg")]
    [DisplayName("ATM Signature 2 Choice")]
    public abstract partial record ATMSignature2Choice_
    {
    }
}
