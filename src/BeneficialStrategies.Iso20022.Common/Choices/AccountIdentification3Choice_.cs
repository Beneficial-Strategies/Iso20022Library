// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification3Choice.IBAN))]
    [KnownType(typeof(AccountIdentification3Choice.BBAN))]
    [KnownType(typeof(AccountIdentification3Choice.UPIC))]
    [KnownType(typeof(AccountIdentification3Choice.ProprietaryAccount))]
    [JsonDerivedType(typeof(AccountIdentification3Choice.IBAN),nameof(AccountIdentification3Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification3Choice.BBAN),nameof(AccountIdentification3Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification3Choice.UPIC),nameof(AccountIdentification3Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification3Choice.ProprietaryAccount),nameof(AccountIdentification3Choice.ProprietaryAccount))]
    [IsoId("_PdnCpdp-Ed-ak6NoX_4Aeg_637192562")]
    [DisplayName("Account Identification 3 Choice")]
    public abstract partial record AccountIdentification3Choice_
    {
    }
}
