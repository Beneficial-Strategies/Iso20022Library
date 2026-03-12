// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of a cash account.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification7Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification7Choice.BBAN))]
    [KnownType(typeof(CashAccountIdentification7Choice.UPIC))]
    [KnownType(typeof(CashAccountIdentification7Choice.DomesticAccount))]
    [JsonDerivedType(typeof(CashAccountIdentification7Choice.IBAN),nameof(CashAccountIdentification7Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification7Choice.BBAN),nameof(CashAccountIdentification7Choice.BBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification7Choice.UPIC),nameof(CashAccountIdentification7Choice.UPIC))]
    [JsonDerivedType(typeof(CashAccountIdentification7Choice.DomesticAccount),nameof(CashAccountIdentification7Choice.DomesticAccount))]
    [IsoId("_oxTyQeWbEeevU7McUP3D1w")]
    [DisplayName("Cash Account Identification 7 Choice")]
    public abstract partial record CashAccountIdentification7Choice_
    {
    }
}
