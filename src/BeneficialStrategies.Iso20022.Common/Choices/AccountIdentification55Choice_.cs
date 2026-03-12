// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification55Choice.IBAN))]
    [KnownType(typeof(AccountIdentification55Choice.BBAN))]
    [KnownType(typeof(AccountIdentification55Choice.UPIC))]
    [KnownType(typeof(AccountIdentification55Choice.ProprietaryAccount))]
    [JsonDerivedType(typeof(AccountIdentification55Choice.IBAN),nameof(AccountIdentification55Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification55Choice.BBAN),nameof(AccountIdentification55Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification55Choice.UPIC),nameof(AccountIdentification55Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification55Choice.ProprietaryAccount),nameof(AccountIdentification55Choice.ProprietaryAccount))]
    [IsoId("_enyf0QatEe2phaVG0lYKTw")]
    [DisplayName("Account Identification 55 Choice")]
    public abstract partial record AccountIdentification55Choice_
    {
    }
}
