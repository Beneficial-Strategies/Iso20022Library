// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a choice for the method of communication for documents.
    /// </summary>
    [KnownType(typeof(CommunicationMethod2Choice.Code))]
    [KnownType(typeof(CommunicationMethod2Choice.Proprietary))]
    [JsonDerivedType(typeof(CommunicationMethod2Choice.Code),nameof(CommunicationMethod2Choice.Code))]
    [JsonDerivedType(typeof(CommunicationMethod2Choice.Proprietary),nameof(CommunicationMethod2Choice.Proprietary))]
    [IsoId("_vGYggA1fEeKGXqvMN6jpiw")]
    [DisplayName("Communication Method 2 Choice")]
    public abstract partial record CommunicationMethod2Choice_
    {
    }
}
