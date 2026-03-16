// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the unique identification of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification8Choice.Other))]
    [KnownType(typeof(CashAccountIdentification8Choice.IBAN))]
    [JsonDerivedType(
        typeof(CashAccountIdentification8Choice.Other),
        nameof(CashAccountIdentification8Choice.Other)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification8Choice.IBAN),
        nameof(CashAccountIdentification8Choice.IBAN)
    )]
    [IsoId("_lFOOAbfLEeuDTOqGwU_8EQ")]
    [DisplayName("Cash Account Identification 8 Choice")]
    public abstract record CashAccountIdentification8Choice_ { }
}
