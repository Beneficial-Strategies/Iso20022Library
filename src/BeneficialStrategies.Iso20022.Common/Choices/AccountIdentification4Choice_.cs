// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the unique identification of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification4Choice.IBAN))]
    [KnownType(typeof(AccountIdentification4Choice.Other))]
    [JsonDerivedType(typeof(AccountIdentification4Choice.IBAN),nameof(AccountIdentification4Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification4Choice.Other),nameof(AccountIdentification4Choice.Other))]
    [IsoId("_Pdwzodp-Ed-ak6NoX_4Aeg_-1833658219")]
    [DisplayName("Account Identification 4 Choice")]
    public abstract partial record AccountIdentification4Choice_
    {
    }
}
