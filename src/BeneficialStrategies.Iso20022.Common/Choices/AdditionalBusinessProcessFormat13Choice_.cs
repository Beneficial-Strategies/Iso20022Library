// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat13Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat13Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat13Choice.Code),nameof(AdditionalBusinessProcessFormat13Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat13Choice.Proprietary),nameof(AdditionalBusinessProcessFormat13Choice.Proprietary))]
    [IsoId("_5k0TyZqPEeWNO_b7eN4F_w")]
    [DisplayName("Additional Business Process Format 13 Choice")]
    public abstract partial record AdditionalBusinessProcessFormat13Choice_
    {
    }
}
