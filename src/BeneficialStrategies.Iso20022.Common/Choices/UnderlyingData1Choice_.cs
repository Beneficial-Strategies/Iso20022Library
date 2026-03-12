// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of an underlying transaction, on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingData1Choice.Initiation))]
    [KnownType(typeof(UnderlyingData1Choice.Interbank))]
    [KnownType(typeof(UnderlyingData1Choice.StatementEntry))]
    [KnownType(typeof(UnderlyingData1Choice.Account))]
    [KnownType(typeof(UnderlyingData1Choice.Other))]
    [JsonDerivedType(typeof(UnderlyingData1Choice.Initiation),nameof(UnderlyingData1Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingData1Choice.Interbank),nameof(UnderlyingData1Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingData1Choice.StatementEntry),nameof(UnderlyingData1Choice.StatementEntry))]
    [JsonDerivedType(typeof(UnderlyingData1Choice.Account),nameof(UnderlyingData1Choice.Account))]
    [JsonDerivedType(typeof(UnderlyingData1Choice.Other),nameof(UnderlyingData1Choice.Other))]
    [IsoId("_CXmpZVRtEe23M4WgERMsYw")]
    [DisplayName("Underlying Data 1 Choice")]
    public abstract partial record UnderlyingData1Choice_
    {
    }
}
