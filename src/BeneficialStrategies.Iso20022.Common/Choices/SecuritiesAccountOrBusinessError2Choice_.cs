// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements used to report between the securities account reference data or a business error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountOrBusinessError2Choice.SecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountOrBusinessError2Choice.BusinessError))]
    [JsonDerivedType(typeof(SecuritiesAccountOrBusinessError2Choice.SecuritiesAccount),nameof(SecuritiesAccountOrBusinessError2Choice.SecuritiesAccount))]
    [JsonDerivedType(typeof(SecuritiesAccountOrBusinessError2Choice.BusinessError),nameof(SecuritiesAccountOrBusinessError2Choice.BusinessError))]
    [IsoId("_ABHykfA0EeWPfa2xBhBfLQ")]
    [DisplayName("Securities Account Or Business Error 2 Choice")]
    public abstract partial record SecuritiesAccountOrBusinessError2Choice_
    {
    }
}
