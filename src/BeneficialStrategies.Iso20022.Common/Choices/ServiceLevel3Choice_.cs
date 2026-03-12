// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the service level of the transaction.
    /// </summary>
    [KnownType(typeof(ServiceLevel3Choice.Code))]
    [KnownType(typeof(ServiceLevel3Choice.Proprietary))]
    [JsonDerivedType(typeof(ServiceLevel3Choice.Code),nameof(ServiceLevel3Choice.Code))]
    [JsonDerivedType(typeof(ServiceLevel3Choice.Proprietary),nameof(ServiceLevel3Choice.Proprietary))]
    [IsoId("_QJkwxNp-Ed-ak6NoX_4Aeg_1187501352")]
    [DisplayName("Service Level 3 Choice")]
    public abstract partial record ServiceLevel3Choice_
    {
    }
}
