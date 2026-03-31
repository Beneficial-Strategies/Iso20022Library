// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the communication channel method.
    /// </summary>
    [KnownType(typeof(CommunicationMethod1Choice.Code))]
    [KnownType(typeof(CommunicationMethod1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CommunicationMethod1Choice.Code),
        nameof(CommunicationMethod1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CommunicationMethod1Choice.Proprietary),
        nameof(CommunicationMethod1Choice.Proprietary)
    )]
    [IsoId("_93Z_w3ltEeG7BsjMvd1mEw_1540700249")]
    [DisplayName("Communication Method 1 Choice")]
    public abstract record CommunicationMethod1Choice_ { }
}
