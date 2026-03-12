// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of status or event.
    /// </summary>
    [KnownType(typeof(TransferStatusType3Choice.Code))]
    [KnownType(typeof(TransferStatusType3Choice.Proprietary))]
    [JsonDerivedType(typeof(TransferStatusType3Choice.Code),nameof(TransferStatusType3Choice.Code))]
    [JsonDerivedType(typeof(TransferStatusType3Choice.Proprietary),nameof(TransferStatusType3Choice.Proprietary))]
    [IsoId("_SVhIAdydEeqzDbuoooxhdw")]
    [DisplayName("Transfer Status Type 3 Choice")]
    public abstract partial record TransferStatusType3Choice_
    {
    }
}
