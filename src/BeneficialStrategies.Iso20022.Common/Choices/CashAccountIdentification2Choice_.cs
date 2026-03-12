// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification2Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification2Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountIdentification2Choice.IBAN),nameof(CashAccountIdentification2Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification2Choice.Proprietary),nameof(CashAccountIdentification2Choice.Proprietary))]
    [IsoId("_Pd6koNp-Ed-ak6NoX_4Aeg_252858102")]
    [DisplayName("Cash Account Identification 2 Choice")]
    public abstract partial record CashAccountIdentification2Choice_
    {
    }
}
