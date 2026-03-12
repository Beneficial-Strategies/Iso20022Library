// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the update information.
    /// </summary>
    [KnownType(typeof(UpdateType2Choice.Code))]
    [KnownType(typeof(UpdateType2Choice.Proprietary))]
    [JsonDerivedType(typeof(UpdateType2Choice.Code),nameof(UpdateType2Choice.Code))]
    [JsonDerivedType(typeof(UpdateType2Choice.Proprietary),nameof(UpdateType2Choice.Proprietary))]
    [IsoId("_QxXJh9p-Ed-ak6NoX_4Aeg_-903172755")]
    [DisplayName("Update Type 2 Choice")]
    public abstract partial record UpdateType2Choice_
    {
    }
}
