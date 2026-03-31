// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Creditor Reference Type2Choice.
    /// </summary>
    [KnownType(typeof(CreditorReferenceType2Choice.Code))]
    [KnownType(typeof(CreditorReferenceType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CreditorReferenceType2Choice.Code),
        nameof(CreditorReferenceType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CreditorReferenceType2Choice.Proprietary),
        nameof(CreditorReferenceType2Choice.Proprietary)
    )]
    [IsoId("_7zR6pTEsEe6GxLzpkVnWYg")]
    [DisplayName("Creditor Reference Type2Choice")]
    public abstract record CreditorReferenceType2Choice_ { }
}
