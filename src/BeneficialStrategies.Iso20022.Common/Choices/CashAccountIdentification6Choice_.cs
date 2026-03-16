// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification6Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CashAccountIdentification6Choice.IBAN),
        nameof(CashAccountIdentification6Choice.IBAN)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification6Choice.Proprietary),
        nameof(CashAccountIdentification6Choice.Proprietary)
    )]
    [IsoId("_WO8Mitp-Ed-ak6NoX_4Aeg_-720963071")]
    [DisplayName("Cash Account Identification 6 Choice")]
    public abstract record CashAccountIdentification6Choice_ { }
}
