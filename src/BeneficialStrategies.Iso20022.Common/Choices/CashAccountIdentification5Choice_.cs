// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification5Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification5Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountIdentification5Choice.IBAN),nameof(CashAccountIdentification5Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification5Choice.Proprietary),nameof(CashAccountIdentification5Choice.Proprietary))]
    [IsoId("_PdUHwtp-Ed-ak6NoX_4Aeg_-912371635")]
    [DisplayName("Cash Account Identification 5 Choice")]
    public abstract partial record CashAccountIdentification5Choice_
    {
    }
}
