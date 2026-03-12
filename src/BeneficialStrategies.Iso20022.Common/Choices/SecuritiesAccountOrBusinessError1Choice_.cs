// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements used to report between the securities account reference data or a business error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountOrBusinessError1Choice.SecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountOrBusinessError1Choice.BusinessError))]
    [JsonDerivedType(typeof(SecuritiesAccountOrBusinessError1Choice.SecuritiesAccount),nameof(SecuritiesAccountOrBusinessError1Choice.SecuritiesAccount))]
    [JsonDerivedType(typeof(SecuritiesAccountOrBusinessError1Choice.BusinessError),nameof(SecuritiesAccountOrBusinessError1Choice.BusinessError))]
    [IsoId("_hjB2cWliEeGaMcKyqKNRfQ_1474195521")]
    [DisplayName("Securities Account Or Business Error 1 Choice")]
    public abstract partial record SecuritiesAccountOrBusinessError1Choice_
    {
    }
}
