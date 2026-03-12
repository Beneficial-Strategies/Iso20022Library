// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of status or event.
    /// </summary>
    [KnownType(typeof(TransferStatusType1Choice.Code))]
    [KnownType(typeof(TransferStatusType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TransferStatusType1Choice.Code),nameof(TransferStatusType1Choice.Code))]
    [JsonDerivedType(typeof(TransferStatusType1Choice.Proprietary),nameof(TransferStatusType1Choice.Proprietary))]
    [IsoId("_BjiYwFNYEeijdq8ilaxyOA")]
    [DisplayName("Transfer Status Type 1 Choice")]
    public abstract partial record TransferStatusType1Choice_
    {
    }
}
