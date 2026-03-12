// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode7Choice.Code))]
    [KnownType(typeof(PurposeCode7Choice.Proprietary))]
    [JsonDerivedType(typeof(PurposeCode7Choice.Code),nameof(PurposeCode7Choice.Code))]
    [JsonDerivedType(typeof(PurposeCode7Choice.Proprietary),nameof(PurposeCode7Choice.Proprietary))]
    [IsoId("_uim_UznaEeWV5sr121Fc8A")]
    [DisplayName("Purpose Code 7 Choice")]
    public abstract partial record PurposeCode7Choice_
    {
    }
}
