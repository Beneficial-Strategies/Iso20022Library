// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the service level of the transaction.
    /// </summary>
    [KnownType(typeof(ServiceLevel2Choice.Code))]
    [KnownType(typeof(ServiceLevel2Choice.Proprietary))]
    [JsonDerivedType(typeof(ServiceLevel2Choice.Code),nameof(ServiceLevel2Choice.Code))]
    [JsonDerivedType(typeof(ServiceLevel2Choice.Proprietary),nameof(ServiceLevel2Choice.Proprietary))]
    [IsoId("_QJkwwdp-Ed-ak6NoX_4Aeg_913208063")]
    [DisplayName("Service Level 2 Choice")]
    public abstract partial record ServiceLevel2Choice_
    {
    }
}
