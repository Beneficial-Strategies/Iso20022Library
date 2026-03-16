// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a transfer type.
    /// </summary>
    [KnownType(typeof(TransferType2Choice.Code))]
    [KnownType(typeof(TransferType2Choice.Proprietary))]
    [JsonDerivedType(typeof(TransferType2Choice.Code), nameof(TransferType2Choice.Code))]
    [JsonDerivedType(
        typeof(TransferType2Choice.Proprietary),
        nameof(TransferType2Choice.Proprietary)
    )]
    [IsoId("_3NmKgaxWEemRcYBAkJyjkg")]
    [DisplayName("Transfer Type 2 Choice")]
    public abstract record TransferType2Choice_ { }
}
