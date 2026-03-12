// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identification of the securities account or the cash account owned by the customer.
    /// </summary>
    [KnownType(typeof(AccountIdentification38Choice.SecuritiesAccountIdentification))]
    [KnownType(typeof(AccountIdentification38Choice.CashAccountIdentification))]
    [JsonDerivedType(typeof(AccountIdentification38Choice.SecuritiesAccountIdentification),nameof(AccountIdentification38Choice.SecuritiesAccountIdentification))]
    [JsonDerivedType(typeof(AccountIdentification38Choice.CashAccountIdentification),nameof(AccountIdentification38Choice.CashAccountIdentification))]
    [IsoId("_ma_Aj-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Account Identification 38 Choice")]
    public abstract partial record AccountIdentification38Choice_
    {
    }
}
