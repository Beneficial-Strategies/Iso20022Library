// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the identification of a cash or securities account.
    /// </summary>
    [KnownType(typeof(AccountIdentification2Choice.CashAccountIdentification))]
    [KnownType(typeof(AccountIdentification2Choice.SecuritiesAccountIdentification))]
    [JsonDerivedType(typeof(AccountIdentification2Choice.CashAccountIdentification),nameof(AccountIdentification2Choice.CashAccountIdentification))]
    [JsonDerivedType(typeof(AccountIdentification2Choice.SecuritiesAccountIdentification),nameof(AccountIdentification2Choice.SecuritiesAccountIdentification))]
    [IsoId("_Rjkpl9p-Ed-ak6NoX_4Aeg_63905637")]
    [DisplayName("Account Identification 2 Choice")]
    public abstract partial record AccountIdentification2Choice_
    {
    }
}
